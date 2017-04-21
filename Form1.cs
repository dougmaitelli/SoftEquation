using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Xml;
using System.Xml.Schema;
using System.IO;
using System.Diagnostics;

namespace SoftEquation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport("MimeTex.dll")]
        internal static extern int CreateGifFromEq(string expr, string fileName);

        private void RenderEq(String eq)
        {
            CreateGifFromEq("\\reverse x", "temp.gif");
            CreateGifFromEq("\\Huge " + eq, "temp.gif");
            EquationBox.Image = Image.FromFile("temp.gif");
            CreateGifFromEq("\\reverse x", "temp.gif");
        }

        private void MenuSobre_Click(object sender, EventArgs e)
        {
            AboutBox SobreDialog = new AboutBox();
            SobreDialog.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel2MinSize = splitContainer1.Size.Width - 400;

            AtualizarMenu();
        }

        private void ListMenu_DoubleClick(object sender, EventArgs e)
        {
            ListMenu.SelectedItems[0].Checked = !ListMenu.SelectedItems[0].Checked;

            XmlDocument doc = new XmlDocument();
            doc.Load("Equations\\" + ListMenu.SelectedItems[0].Group.Name + "\\" + ListMenu.SelectedItems[0].Text + ".xml");

            XmlElement element = (XmlElement)doc.GetElementsByTagName("Equation")[0];

            Titulo.Text = ListMenu.SelectedItems[0].Text;
            Categoria.Text = ListMenu.SelectedItems[0].Group.Name;
            Descricao.Text = element.GetElementsByTagName("Description")[0].InnerText;
            WriteEquation(element.Attributes["Eq"].InnerText);

            BotaoExercicios.Enabled = element.GetElementsByTagName("Exercise").Count > 0;
        }

        private void WriteEquation(string equation)
        {
            if (EquationBox.Image != null)
            {
                EquationBox.Image.Dispose();
            }

            if (equation.Length > 0)
            {
                try
                {
                    RenderEq(equation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (splitContainer1.Size.Width > 250)
            {
                splitContainer1.Panel2MinSize = splitContainer1.Size.Width - 250;
            }
        }

        private void MenuAdicionarEquacao_Click(object sender, EventArgs e)
        {
            AddEquation AdicionarEquacao = new AddEquation("");
            if (AdicionarEquacao.ShowDialog() == DialogResult.OK)
            {
                AtualizarMenu();
            }
        }

        private void AtualizarMenu()
        {
            ListMenu.BeginUpdate();

            ListMenu.Items.Clear();

            DirectoryInfo dir = new DirectoryInfo("Equations");
            foreach (DirectoryInfo cat in dir.GetDirectories()){
                foreach (FileInfo file in cat.GetFiles("*.xml"))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(file.FullName.ToString());

                    XmlNodeList equations = doc.GetElementsByTagName("Equation");

                    foreach (XmlNode node in equations)
                    {
                        XmlElement element = (XmlElement)node;

                        if (element.HasAttributes)
                        {
                            if (file.Name.Replace(file.Extension, "").ToLower().Contains(MenuBusca.Text.ToLower()) || cat.Name.ToLower().Contains(MenuBusca.Text.ToLower()))
                            {
                                String[] str = new String[2];
                                str[0] = file.Name.Replace(file.Extension, "");
                                str[1] = element.Attributes["Creator"].InnerText;
                                ListViewGroup group = new ListViewGroup(cat.Name, cat.Name);
                                if (!ListMenu.Groups.Contains(ListMenu.Groups[cat.Name]))
                                {
                                    ListMenu.Groups.Add(group);
                                }
                                else
                                {
                                    group = ListMenu.Groups[cat.Name];
                                }
                                ListViewItem item = new ListViewItem(str, group);
                                ListMenu.Items.Add(item);
                            }
                        }
                    }
                }
            }

            ListMenu.EndUpdate();
        }

        private void MenuExcluirEquacoes_Click(object sender, EventArgs e)
        {
            if (ListMenu.CheckedItems.Count > 0)
            {
                if (MessageBox.Show("Você tem certeza de que deseja excluir as Equações selcionadas?", "Excluir Equações", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (ListViewItem item in ListMenu.CheckedItems)
                    {
                        FileInfo file = new FileInfo("Equations\\" + item.Group.Name + "\\" + item.Text + ".xml");
                        file.Delete();
                        if (Directory.GetFiles("Equations\\" + item.Group.Name).Length == 0)
                        {
                            Directory.Delete("Equations\\" + item.Group.Name);
                        }
                        ListMenu.Items.Remove(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("É necessário selecionar as Equações antes.", "Não há Equações selecionadas!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MenuImportarEquacoes_Click(object sender, EventArgs e)
        {
            if (ImportEquationsDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string name in ImportEquationsDialog.FileNames)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(name);

                    XmlNodeList equations = doc.GetElementsByTagName("Equation");

                    foreach (XmlNode node in equations)
                    {
                        XmlElement element = (XmlElement)node;

                        if (element.HasAttribute("Category") && element.HasAttribute("Name"))
                        {
                            if (!Directory.Exists("Equations\\" + element.Attributes["Category"].InnerText))
                            {
                                Directory.CreateDirectory("Equations\\" + element.Attributes["Category"].InnerText);
                            }

                            string name2 = "Equations\\" + element.Attributes["Category"].InnerText + "\\" + element.Attributes["Name"].InnerText + ".xml";

                            if (File.Exists(name2))
                            {
                                switch (MessageBox.Show("Já existe no programa uma Equação com um dos nomes selecionados. O que você deseja fazer? Escolha Sim para substituir o arquivo, Não para importar com outro nome, e Cancelar para não fazer nada.", "Arquivo já Existe!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                                {
                                    case DialogResult.Yes:
                                        XmlDocument textWriter = new XmlDocument();
                                        textWriter.LoadXml(element.OuterXml);
                                        textWriter.Save(name2);
                                        break;
                                    case DialogResult.No:
                                        for (int i = 2; ; i++)
                                        {
                                            if (!File.Exists(name2.Insert(name2.LastIndexOf("."), " " + i)))
                                            {
                                                XmlDocument textWriter2 = new XmlDocument();
                                                textWriter2.LoadXml(element.OuterXml);
                                                textWriter2.Save(name2.Insert(name2.LastIndexOf("."), " " + i));
                                                break;
                                            }
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                XmlDocument textWriter = new XmlDocument();
                                textWriter.LoadXml(element.OuterXml);
                                textWriter.Save(name2);
                            }
                        }
                    }
                }

                AtualizarMenu();
            }
        }

        private void MenuExportarEquacoes_Click(object sender, EventArgs e)
        {
            if (ListMenu.CheckedItems.Count > 0)
            {
                if (ExportEquationsDialog.ShowDialog() == DialogResult.OK)
                {
                    XmlDocument textWriter = new XmlDocument();
                    textWriter.LoadXml("<Equations></Equations>");

                    foreach (ListViewItem item in ListMenu.CheckedItems)
                    {
                        XmlDocument textReader = new XmlDocument();
                        textReader.Load("Equations\\" + item.Group.Name + "\\" + item.Text + ".xml");

                        XmlNode node = textWriter.ImportNode(textReader.GetElementsByTagName("Equation")[0], true);
                        textWriter.DocumentElement.AppendChild(node); 
                    }

                    textWriter.Save(ExportEquationsDialog.FileName);
                }
            }
            else
            {
                MessageBox.Show("É necessário selecionar as Equações antes.", "Não há Equações selecionadas!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void splitContainer1_Panel2_Resize(object sender, EventArgs e)
        {
            Titulo.Width = Convert.ToInt32(splitContainer1.Panel2.Width * 0.67);

            Categoria.Left = Titulo.Left + Titulo.Width + 10;

            Categoria.Width = splitContainer1.Panel2.Width - Categoria.Left;

            Descricao.Width = splitContainer1.Panel2.Width - Descricao.Location.X - 10;

            EquationBox.Width = splitContainer1.Panel2.Width - Descricao.Location.X - 10;

            BotaoExercicios.Location = new Point(splitContainer1.Panel2.Width - BotaoExercicios.Width - 10, splitContainer1.Panel2.Height - BotaoExercicios.Height - 10);
        }

        private void ListMenuContextSelecionarCategoria_Click(object sender, EventArgs e)
        {
            if (ListMenu.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in ListMenu.SelectedItems[0].Group.Items)
                {
                    item.Checked = true;
                }
            }
        }

        private void ListMenuContextSelecionarTudo_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListMenu.Items)
            {
                item.Checked = true;
            }
        }

        private void ListMenuContextExcluirEquacao_Click(object sender, EventArgs e)
        {
            if (ListMenu.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Você tem certeza de que deseja excluir a Equação selcionada?", "Excluir Equação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FileInfo file = new FileInfo("Equations\\" + ListMenu.SelectedItems[0].Group.Name + "\\" + ListMenu.SelectedItems[0].Text + ".xml");
                    file.Delete();
                    if (Directory.GetFiles("Equations\\" + ListMenu.SelectedItems[0].Group.Name).Length == 0)
                    {
                        Directory.Delete("Equations\\" + ListMenu.SelectedItems[0].Group.Name);
                    }
                    ListMenu.SelectedItems[0].Remove();
                }
            }
            else
            {
                MessageBox.Show("É necessário selecionar a Equação antes.", "Não há uma Equação selecionada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MenuEditarEquacao_Click(object sender, EventArgs e)
        {
            if (ListMenu.SelectedItems.Count > 0)
            {
                EditEquation EditarEquacao = new EditEquation(ListMenu.SelectedItems[0].Group.Name + "\\" + ListMenu.SelectedItems[0].Text);
                if (EditarEquacao.ShowDialog() == DialogResult.OK)
                {
                    AtualizarMenu();
                }
            }
            else
            {
                MessageBox.Show("É necessário selecionar a Equação antes.", "Não há uma Equação selecionada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BotaoExercicios_Click(object sender, EventArgs e)
        {
            ExercisesForm FormExercicios = new ExercisesForm(Categoria.Text + "\\" + Titulo.Text);
            FormExercicios.Show();
        }

        private void ListMenuContextAdicionarEquacao_Click(object sender, EventArgs e)
        {
            if (ListMenu.SelectedItems.Count > 0)
            {
                AddEquation AdicionarEquacao = new AddEquation(ListMenu.SelectedItems[0].Group.Header);
                if (AdicionarEquacao.ShowDialog() == DialogResult.OK)
                {
                    AtualizarMenu();
                }
            }
            else
            {
                AddEquation AdicionarEquacao = new AddEquation("");
                if (AdicionarEquacao.ShowDialog() == DialogResult.OK)
                {
                    AtualizarMenu();
                }
            }
        }

        private void MenuExportarImagens_Click(object sender, EventArgs e)
        {
            if (ListMenu.CheckedItems.Count > 0)
            {
                if (ExportImagesDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (ListViewItem item in ListMenu.CheckedItems)
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.Load("Equations\\" + item.Group.Name + "\\" + item.Text + ".xml");

                        XmlElement element = (XmlElement)doc.GetElementsByTagName("Equation")[0];

                        if (File.Exists(ExportImagesDialog.SelectedPath + "\\" + item.Text + ".gif"))
                        {
                            if (MessageBox.Show("Um dos nomes de arquivo necessários para a exportação das Equações já está em uso na pasta selecionada. Deseja substituir este arquivo?", "Arquivo já Existe!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                            {
                                return;
                            }
                        }

                        CreateGifFromEq("\\Huge " + element.Attributes["Eq"].InnerText, ExportImagesDialog.SelectedPath + "\\" + item.Text + ".gif");
                    }
                }
            }
            else
            {
                MessageBox.Show("É necessário selecionar as Equações antes.", "Não há Equações selecionadas!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MenuBusca_TextChanged(object sender, EventArgs e)
        {
               AtualizarMenu();
        }

        private void ListMenuContextAdicionarExercicio_Click(object sender, EventArgs e)
        {
            if (ListMenu.SelectedItems.Count > 0)
            {
                AddExercise AdicionarExercicio = new AddExercise(ListMenu.SelectedItems[0].Group.Name + "\\" + ListMenu.SelectedItems[0].Text);
                AdicionarExercicio.ShowDialog();
            }
            else
            {
                MessageBox.Show("É necessário selecionar a Equação antes.", "Não há uma Equação selecionada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ListMenuContextEditarExercicios_Click(object sender, EventArgs e)
        {
            if (ListMenu.SelectedItems.Count > 0)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Equations\\" + ListMenu.SelectedItems[0].Group.Name + "\\" + ListMenu.SelectedItems[0].Text + ".xml");

                if (doc.GetElementsByTagName("Exercise").Count > 0)
                {
                    EditExercise EditarExercicio = new EditExercise(ListMenu.SelectedItems[0].Group.Name + "\\" + ListMenu.SelectedItems[0].Text);
                    EditarExercicio.ShowDialog();
                }
                else
                {
                    MessageBox.Show("A Equação selecionada não possui nenhum Exercício.", "Não há uma Exercícios para editar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("É necessário selecionar a Equação antes.", "Não há uma Equação selecionada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ListMenu_DragDrop(object sender, DragEventArgs e)
        {
            if (ListMenu.SelectedItems.Count > 0) 
            {
                Point cp = ListMenu.PointToClient(new Point(e.X, e.Y));
                ListViewGroup group = ListMenu.GetItemAt(cp.X, cp.Y).Group;

                if (group != null && group != ListMenu.SelectedItems[0].Group)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("Equations\\" + ListMenu.SelectedItems[0].Group.Name + "\\" + ListMenu.SelectedItems[0].Text + ".xml");

                    XmlElement element = (XmlElement)doc.GetElementsByTagName("Equation")[0];
                    element.SetAttribute("Category", group.Name);

                    doc.Save("Equations\\" + group.Name + "\\" + ListMenu.SelectedItems[0].Text + ".xml");

                    File.Delete("Equations\\" + ListMenu.SelectedItems[0].Group.Name + "\\" + ListMenu.SelectedItems[0].Text + ".xml");

                    if (Directory.GetFiles("Equations\\" + ListMenu.SelectedItems[0].Group.Name).Length == 0)
                    {
                        Directory.Delete("Equations\\" + ListMenu.SelectedItems[0].Group.Name);
                    }

                    ListMenu.SelectedItems[0].Group = group;
                }
            }
        }

        private void ListMenu_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ListMenu.DoDragDrop(ListMenu.SelectedItems, DragDropEffects.Move);
        }

        private void ListMenu_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetFormats()[0].Equals("System.Windows.Forms.ListView+SelectedListViewItemCollection"))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void ListMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (ListMenu.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Você tem certeza de que deseja excluir a Equação selcionada?", "Excluir Equação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FileInfo file = new FileInfo("Equations\\" + ListMenu.SelectedItems[0].Group.Name + "\\" + ListMenu.SelectedItems[0].Text + ".xml");
                        file.Delete();

                        if (Directory.GetFiles("Equations\\" + ListMenu.SelectedItems[0].Group.Name).Length == 0)
                        {
                            Directory.Delete("Equations\\" + ListMenu.SelectedItems[0].Group.Name);
                        }

                        ListMenu.SelectedItems[0].Remove();
                    }
                }
            }
        }

        private void exportarImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Titulo.Text != "")
            {
                if (ExportImagesDialog.ShowDialog() == DialogResult.OK)
                {
                        XmlDocument doc = new XmlDocument();
                        doc.Load("Equations\\" + Categoria.Text + "\\" + Titulo.Text + ".xml");

                        XmlElement element = (XmlElement)doc.GetElementsByTagName("Equation")[0];

                        if (File.Exists(ExportImagesDialog.SelectedPath + "\\" + Titulo.Text + ".gif"))
                        {
                            if (MessageBox.Show("Um dos nomes de arquivo necessários para a exportação das Equações já está em uso na pasta selecionada. Deseja substituir este arquivo?", "Arquivo já Existe!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                            {
                                return;
                            }
                        }

                        CreateGifFromEq("\\Huge " + element.Attributes["Eq"].InnerText, ExportImagesDialog.SelectedPath + "\\" + Titulo.Text + ".gif");
                }
            }
        }

        private void exportarParaTextoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ListMenu.CheckedItems.Count > 0)
            {
                if (ExportTextDialog.ShowDialog() == DialogResult.OK)
                {
                    /*Microsoft.Office.Interop.Word.Application oWord = new Microsoft.Office.Interop.Word.Application();
                    oWord.Visible = false;

                    object oMissing = System.Reflection.Missing.Value;
                    Microsoft.Office.Interop.Word.Document oDoc = oWord.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);

                    foreach (ListViewItem item in ListMenu.CheckedItems)
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.Load("Equations\\" + item.Group.Name + "\\" + item.Text + ".xml");

                        XmlElement element = (XmlElement)doc.GetElementsByTagName("Equation")[0];

                        Microsoft.Office.Interop.Word.Paragraph oPara;
                        oPara = oDoc.Paragraphs.Add(ref oMissing);
                        oPara.Range.Text = item.Text + "\n" + element.GetElementsByTagName("Description")[0].InnerText;
                        oPara.Range.InsertParagraphAfter();
                    }

                    object fileName = ExportTextDialog.FileName;
                    oDoc.SaveAs(ref fileName, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);

                    oDoc.Close(ref oMissing, ref oMissing, ref oMissing);
                    oWord.Quit(ref oMissing, ref oMissing, ref oMissing);
                    oWord = null;*/
                }
            }
            else
            {
                MessageBox.Show("É necessário selecionar as Equações antes.", "Não há Equações selecionadas!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
