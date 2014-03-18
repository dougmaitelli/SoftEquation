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
    public partial class AddExercise : Form
    {
        string equation;

        public AddExercise(string nome)
        {
            InitializeComponent();

            equation = nome;
        }

        private void BotaoOK_Click(object sender, EventArgs e)
        {
            int resp = 0;

            if (RadioResposta1.Checked)
            {
                resp = 1;
            }
            else if (RadioResposta2.Checked)
            {
                resp = 2;
            }
            else if (RadioResposta3.Checked)
            {
                resp = 3;
            }
            else if (RadioResposta4.Checked)
            {
                resp = 4;
            }
            else if (RadioResposta5.Checked)
            {
                resp = 5;
            }

            if (resp > 0 && resp <= 5)
            {

                XmlDocument doc = new XmlDocument();
                doc.Load("Equations\\" + equation + ".xml");

                XmlElement element = (XmlElement)doc.GetElementsByTagName("Equation")[0].AppendChild(doc.CreateElement("Exercise"));

                element.Attributes.Append(doc.CreateAttribute("Correct"));

                element.SetAttribute("Correct", resp.ToString());

                element.AppendChild(doc.CreateElement("Question")).InnerText = TextPergunta.Text;
                element.AppendChild(doc.CreateElement("Answer1")).InnerText = TextResposta1.Text;
                element.AppendChild(doc.CreateElement("Answer2")).InnerText = TextResposta2.Text;
                element.AppendChild(doc.CreateElement("Answer3")).InnerText = TextResposta3.Text;
                element.AppendChild(doc.CreateElement("Answer4")).InnerText = TextResposta4.Text;
                element.AppendChild(doc.CreateElement("Answer5")).InnerText = TextResposta5.Text;

                doc.Save("Equations\\" + equation + ".xml");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, insira um número correto para a resposta correta.", "Resposta correta inválida!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
