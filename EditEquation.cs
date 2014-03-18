using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Xml;
using System.IO;

namespace SoftEquation
{
    public partial class EditEquation : Form
    {
        string equation;

        public EditEquation(string nome)
        {
            InitializeComponent();

            equation = nome;
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BotaoOk_Click(object sender, EventArgs e)
        {
            if (TextNome.Text != "" && TextCategoria.Text != "")
            {
                if (TextCategoria.Text.IndexOfAny(Path.GetInvalidFileNameChars()) == -1 && TextNome.Text.IndexOfAny(Path.GetInvalidFileNameChars()) == -1)
                {
                    if (equation != (TextCategoria.Text + "\\" + TextNome.Text) && File.Exists("Equations\\" + TextCategoria.Text + "\\" + TextNome.Text + ".xml"))
                    {
                        MessageBox.Show("Já existe um arquivo com este nome, favor escolher outro.", "Arquivo Já Existe!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (!Directory.Exists("Equations\\" + TextCategoria.Text))
                        {
                            Directory.CreateDirectory("Equations\\" + TextCategoria.Text);
                        }

                        if (File.Exists("Equations\\" + equation + ".xml"))
                        {
                            if (equation != (TextCategoria.Text + "\\" + TextNome.Text))
                            {
                                File.Move("Equations\\" + equation + ".xml", "Equations\\" + TextCategoria.Text + "\\" + TextNome.Text + ".xml");
                            }
                        }

                        XmlDocument doc = new XmlDocument();
                        doc.Load("Equations\\" + TextCategoria.Text + "\\" + TextNome.Text + ".xml");

                        XmlElement element = (XmlElement)doc.GetElementsByTagName("Equation")[0];

                        element.SetAttribute("Name", TextNome.Text);
                        element.SetAttribute("Category", TextCategoria.Text);
                        element.SetAttribute("Creator", TextCriador.Text);
                        element.SetAttribute("Eq", TextEquation.Text);

                        XmlElement desc = (XmlElement)element.GetElementsByTagName("Description")[0];

                        desc.InnerText = TextDescricao.Text;

                        doc.Save("Equations\\" + TextCategoria.Text + "\\" + TextNome.Text + ".xml");

                        if (Directory.GetFiles("Equations\\" + equation.Remove(equation.LastIndexOf("\\"))).Length == 0)
                        {
                            Directory.Delete("Equations\\" + equation.Remove(equation.LastIndexOf("\\")));
                        }

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Não é permitido o uso de caracteres especiais no nome da Equação.", "Nome da Equação inválido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha nome e categoria.", "Nome da Equação inválido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EditEquation_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Equations\\" + equation + ".xml");

            XmlNodeList equations = doc.GetElementsByTagName("Equation");

            foreach (XmlNode node in equations)
            {
                XmlElement element = (XmlElement)node;

                if (element.HasAttributes)
                {
                    TextNome.Text = equation.Substring(equation.LastIndexOf("\\")+1);
                    if (element.HasAttribute("Creator"))
                    {
                        TextCriador.Text = element.Attributes["Creator"].InnerText;
                    }
                    if (element.HasAttribute("Category"))
                    {
                        TextCategoria.Text = element.Attributes["Category"].InnerText;
                    }
                    if (element.HasAttribute("Eq"))
                    {
                        TextEquation.Text = element.Attributes["Eq"].InnerText;
                    }

                }

                TextDescricao.Text = element.GetElementsByTagName("Description")[0].InnerText;
            }

            DirectoryInfo dir = new DirectoryInfo("Equations");
            foreach (DirectoryInfo cat in dir.GetDirectories())
            {

                if (!TextCategoria.Items.Contains(cat.Name))
                {
                    TextCategoria.Items.Add(cat.Name);
                }
            }
        }
    }
}
