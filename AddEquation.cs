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
    public partial class AddEquation : Form
    {
        string category;

        public AddEquation(string name)
        {
            InitializeComponent();

            category = name;
        }

        private void BotaoOk_Click(object sender, EventArgs e)
        {
            if (File.Exists("Equations\\" + TextCategoria.Text + "\\" + TextNome.Text + ".xml"))
            {
                MessageBox.Show("Já existe um arquivo com este nome, favor escolher outro.", "Arquivo Já Existe!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (TextNome.Text != "" && TextCategoria.Text != "")
                {
                    if (TextCategoria.Text.IndexOfAny(Path.GetInvalidFileNameChars()) == -1 && TextNome.Text.IndexOfAny(Path.GetInvalidFileNameChars()) == -1)
                    {
                        if (!Directory.Exists("Equations\\" + TextCategoria.Text))
                        {
                            Directory.CreateDirectory("Equations\\" + TextCategoria.Text);
                        }

                        XmlTextWriter textWriter = new XmlTextWriter("Equations\\" + TextCategoria.Text + "\\" + TextNome.Text + ".xml", null);

                        textWriter.Formatting = Formatting.Indented;

                        textWriter.WriteStartDocument();
                        textWriter.WriteStartElement("Equation");
                        textWriter.WriteAttributeString("Name", TextNome.Text);
                        textWriter.WriteAttributeString("Category", TextCategoria.Text);
                        textWriter.WriteAttributeString("Creator", TextCriador.Text);
                        textWriter.WriteAttributeString("Eq", TextEquation.Text);
                        textWriter.WriteStartElement("Description");
                        textWriter.WriteString(TextDescricao.Text);
                        textWriter.WriteEndElement();
                        textWriter.WriteEndElement();
                        textWriter.WriteEndDocument();
                        textWriter.Close();

                        this.DialogResult = DialogResult.OK;
                        this.Close();
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
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddEquation_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo("Equations");
            foreach (DirectoryInfo cat in dir.GetDirectories())
            {
                if (!TextCategoria.Items.Contains(cat.Name))
                {
                    TextCategoria.Items.Add(cat.Name);
                }
            }

            TextCategoria.Text = category;
        }
    }
}
