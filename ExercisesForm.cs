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
    public partial class ExercisesForm : Form
    {
        string equation;

        public ExercisesForm(string nome)
        {
            InitializeComponent();

            equation = nome;
        }

        private void ExercisesForm_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Equations\\" + equation + ".xml");

            XmlNodeList nodes = doc.GetElementsByTagName("Exercise");

            for (int i = 1; i <= nodes.Count; i++)
            {
                XmlElement element = (XmlElement)nodes[i - 1];

                Label Titulo = new Label();
                Titulo.Text = "Exercício " + i;
                Titulo.Name = "Titulo" + i;
                Titulo.Location = new Point(10, 10 + 230 * (i - 1));
                Titulo.Size = new Size(Size.Width - Titulo.Left - 10, Titulo.Height);
                Titulo.Font = new Font(Titulo.Name, 12, Titulo.Font.Style | FontStyle.Bold);
                Painel.Controls.Add(Titulo);

                Label Question = new Label();
                Question.Text = element.GetElementsByTagName("Question")[0].InnerText;
                Question.Name = "Questao" + i;
                Question.Location = new Point(15, 35 + 230 * (i - 1));
                Question.Size = new Size(Size.Width - Question.Left - 50, 70);
                Question.Font = new Font(Question.Name, 8);
                Painel.Controls.Add(Question);

                GroupBox AnswerGroup = new GroupBox();
                AnswerGroup.Text = "Respostas";
                AnswerGroup.Name = "AnswerGroup" + i;
                AnswerGroup.Location = new Point(15, 110 + 230 * (i - 1));
                AnswerGroup.Size = new Size(Size.Width - AnswerGroup.Left - 50, 125);
                Painel.Controls.Add(AnswerGroup);

                RadioButton Answer1 = new RadioButton();
                Answer1.Text = element.GetElementsByTagName("Answer1")[0].InnerText;
                Answer1.AutoSize = false;
                Answer1.Size = new Size(Size.Width - Answer1.Left - 30, Answer1.Height);
                Answer1.Name = "Answer1-" + i;
                Answer1.Location = new Point(15, 15);
                AnswerGroup.Controls.Add(Answer1);

                RadioButton Answer2 = new RadioButton();
                Answer2.Text = element.GetElementsByTagName("Answer2")[0].InnerText;
                Answer2.AutoSize = false;
                Answer2.Size = new Size(Size.Width - Answer2.Left - 30, Answer2.Height);
                Answer2.Name = "Answer2-" + i;
                Answer2.Location = new Point(15, 35);
                AnswerGroup.Controls.Add(Answer2);

                RadioButton Answer3 = new RadioButton();
                Answer3.Text = element.GetElementsByTagName("Answer3")[0].InnerText;
                Answer3.AutoSize = false;
                Answer3.Size = new Size(Size.Width - Answer3.Left - 30, Answer3.Height);
                Answer3.Name = "Answer3-" + i;
                Answer3.Location = new Point(15, 55);
                AnswerGroup.Controls.Add(Answer3);

                RadioButton Answer4 = new RadioButton();
                Answer4.Text = element.GetElementsByTagName("Answer4")[0].InnerText;
                Answer4.AutoSize = false;
                Answer4.Size = new Size(Size.Width - Answer4.Left - 30, Answer4.Height);
                Answer4.Name = "Answer4-" + i;
                Answer4.Location = new Point(15, 75);
                AnswerGroup.Controls.Add(Answer4);

                RadioButton Answer5 = new RadioButton();
                Answer5.Text = element.GetElementsByTagName("Answer5")[0].InnerText;
                Answer5.AutoSize = false;
                Answer5.Size = new Size(Size.Width - Answer5.Left - 30, Answer5.Height);
                Answer5.Name = "Answer5-" + i;
                Answer5.Location = new Point(15, 95);
                AnswerGroup.Controls.Add(Answer5);
            }

            Acertos.Top = 10 + 230 * nodes.Count;
            Nota.Top = 10 + 230 * nodes.Count;
            BotaoConferir.Top = 10 + 230 * nodes.Count;
        }

        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Painel.Top = -ScrollBar.Value;
        }

        private void BotaoConferir_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Equations\\" + equation + ".xml");

            XmlNodeList nodes = doc.GetElementsByTagName("Exercise");

            int certas = 0;

            for (int i = 1; i <= nodes.Count; i++)
            {
                XmlElement element = (XmlElement)nodes[i - 1];

                if (element.HasAttributes)
                {
                    GroupBox group = (GroupBox)Painel.Controls["AnswerGroup" + i];
                    RadioButton radio = (RadioButton)group.Controls["Answer" + element.Attributes["Correct"].InnerText + "-" + i];
                    if (radio.Checked)
                    {
                        radio.Font = new Font(radio.Font, radio.Font.Style | FontStyle.Bold);
                        radio.ForeColor = Color.Green;

                        certas++;
                    }
                    else
                    {
                        radio.Font = new Font(radio.Font, radio.Font.Style | FontStyle.Bold);
                        radio.ForeColor = Color.Red;
                    }
                }
            }

            Acertos.Text = certas + "/" + nodes.Count;
            Nota.Text = String.Format("{0:0.##}", (float)certas * (float)10 / (float)nodes.Count);

            BotaoConferir.Enabled = false;
        }
    }
}
