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
    public partial class EditExercise : Form
    {
        string equation;

        public EditExercise(string nome)
        {
            InitializeComponent();

            equation = nome;
        }

        private void EditExercise_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Equations\\" + equation + ".xml");

            XmlNodeList exercises = doc.GetElementsByTagName("Exercise");

            int count = 0;

            foreach (XmlNode node in exercises)
            {
                XmlElement element = (XmlElement)node;

                count++;
                TabPage page = new TabPage();

                page.Padding = new System.Windows.Forms.Padding(3);
                page.Size = new System.Drawing.Size(376, 395);
                page.Text = count.ToString();
                page.Name = count.ToString();
                page.UseVisualStyleBackColor = true;

                Label Pergunta = new Label();
                Pergunta.AutoSize = true;
                Pergunta.Text = "Pergunta";
                Pergunta.Name = "LabelPergunta" + count.ToString();
                Pergunta.Location = new Point(8, 3);
                Pergunta.Size = new Size(50, 13);
                page.Controls.Add(Pergunta);

                RichTextBox TextPergunta = new RichTextBox();
                TextPergunta.Name = "TextPergunta" + count.ToString();
                TextPergunta.Location = new Point(8, 19);
                TextPergunta.Size = new Size(360, 101);
                TextPergunta.TabIndex = 0;
                TextPergunta.Text = element.GetElementsByTagName("Question")[0].InnerText;
                page.Controls.Add(TextPergunta);

                GroupBox AnswerGroup = new GroupBox();
                AnswerGroup.Location = new Point(8, 126);
                AnswerGroup.Name = "AnswerGroup" + count.ToString();
                AnswerGroup.Size = new Size(360, 266);
                AnswerGroup.Text = "Respostas";
                page.Controls.Add(AnswerGroup);

                RadioButton RadioResposta1 = new RadioButton(); 
                RadioResposta1.Location = new Point(6, 19);
                RadioResposta1.Name = "RadioResposta1-" + count.ToString();
                RadioResposta1.Size = new Size(79, 17);
                RadioResposta1.TabIndex = 1;
                RadioResposta1.TabStop = true;
                RadioResposta1.Text = "Resposta 1";
                RadioResposta1.UseVisualStyleBackColor = true;
                if (element.GetAttribute("Correct") == "1")
                {
                    RadioResposta1.Checked = true;
                }
                AnswerGroup.Controls.Add(RadioResposta1);

                TextBox TextResposta1 = new TextBox();
                TextResposta1.Location = new Point(6, 42);
                TextResposta1.Name = "TextResposta1-" + count.ToString();
                TextResposta1.Size = new Size(348, 20);
                TextResposta1.TabIndex = 2;
                TextResposta1.Text = element.GetElementsByTagName("Answer1")[0].InnerText;
                AnswerGroup.Controls.Add(TextResposta1);

                RadioButton RadioResposta2 = new RadioButton(); 
                RadioResposta2.Location = new Point(6, 68);
                RadioResposta2.Name = "RadioResposta2-" + count.ToString();
                RadioResposta2.Size = new Size(79, 17);
                RadioResposta2.TabIndex = 3;
                RadioResposta2.TabStop = true;
                RadioResposta2.Text = "Resposta 2";
                RadioResposta2.UseVisualStyleBackColor = true;
                if (element.GetAttribute("Correct") == "2")
                {
                    RadioResposta2.Checked = true;
                }
                AnswerGroup.Controls.Add(RadioResposta2);

                TextBox TextResposta2 = new TextBox(); 
                TextResposta2.Location = new Point(6, 91);
                TextResposta2.Name = "TextResposta2-" + count.ToString();
                TextResposta2.Size = new Size(348, 20);
                TextResposta2.TabIndex = 4;
                TextResposta2.Text = element.GetElementsByTagName("Answer2")[0].InnerText;
                AnswerGroup.Controls.Add(TextResposta2);

                RadioButton RadioResposta3 = new RadioButton(); 
                RadioResposta3.Location = new Point(6, 117);
                RadioResposta3.Name = "RadioResposta3-" + count.ToString();
                RadioResposta3.Size = new Size(79, 17);
                RadioResposta3.TabIndex = 5;
                RadioResposta3.TabStop = true;
                RadioResposta3.Text = "Resposta 3";
                RadioResposta3.UseVisualStyleBackColor = true;
                if (element.GetAttribute("Correct") == "3")
                {
                    RadioResposta3.Checked = true;
                }
                AnswerGroup.Controls.Add(RadioResposta3);

                TextBox TextResposta3 = new TextBox(); 
                TextResposta3.Location = new Point(6, 140);
                TextResposta3.Name = "TextResposta3-" + count.ToString();
                TextResposta3.Size = new Size(348, 20);
                TextResposta3.TabIndex = 6;
                TextResposta3.Text = element.GetElementsByTagName("Answer3")[0].InnerText;
                AnswerGroup.Controls.Add(TextResposta3);

                RadioButton RadioResposta4 = new RadioButton(); 
                RadioResposta4.Location = new Point(6, 166);
                RadioResposta4.Name = "RadioResposta4-" + count.ToString();
                RadioResposta4.Size = new Size(79, 17);
                RadioResposta4.TabIndex = 7;
                RadioResposta4.TabStop = true;
                RadioResposta4.Text = "Resposta 4";
                RadioResposta4.UseVisualStyleBackColor = true;
                if (element.GetAttribute("Correct") == "4")
                {
                    RadioResposta4.Checked = true;
                }
                AnswerGroup.Controls.Add(RadioResposta4);

                TextBox TextResposta4 = new TextBox(); 
                TextResposta4.Location = new Point(6, 189);
                TextResposta4.Name = "TextResposta4-" + count.ToString();
                TextResposta4.Size = new Size(348, 20);
                TextResposta4.TabIndex = 8;
                TextResposta4.Text = element.GetElementsByTagName("Answer4")[0].InnerText;
                AnswerGroup.Controls.Add(TextResposta4);

                RadioButton RadioResposta5 = new RadioButton();
                RadioResposta5.Location = new Point(6, 215);
                RadioResposta5.Name = "RadioResposta5-" + count.ToString();
                RadioResposta5.Size = new Size(79, 17);
                RadioResposta5.TabIndex = 9;
                RadioResposta5.TabStop = true;
                RadioResposta5.Text = "Resposta 5";
                RadioResposta5.UseVisualStyleBackColor = true;
                if (element.GetAttribute("Correct") == "5")
                {
                    RadioResposta5.Checked = true;
                }
                AnswerGroup.Controls.Add(RadioResposta5);

                TextBox TextResposta5 = new TextBox();
                TextResposta5.Location = new Point(6, 238);
                TextResposta5.Name = "TextResposta5-" + count.ToString();
                TextResposta5.Size = new Size(348, 20);
                TextResposta5.TabIndex = 10;
                TextResposta5.Text = element.GetElementsByTagName("Answer5")[0].InnerText;
                AnswerGroup.Controls.Add(TextResposta5);

                TabExercises.TabPages.Add(page);
            }
        }

        private void BotaoOK_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Equations\\" + equation + ".xml");

            XmlNodeList exercises = doc.GetElementsByTagName("Exercise");

            int count = 0;

            foreach (XmlNode node in exercises)
            {
                XmlElement element = (XmlElement)node;

                count++;

                int resp = 0;
                
                if (((RadioButton)TabExercises.TabPages[count.ToString()].Controls["AnswerGroup" + count.ToString()].Controls["RadioResposta1-" + count.ToString()]).Checked)
                {
                    resp = 1;
                }
                else if (((RadioButton)TabExercises.TabPages[count.ToString()].Controls["AnswerGroup" + count.ToString()].Controls["RadioResposta2-" + count.ToString()]).Checked)
                {
                    resp = 2;
                }
                else if (((RadioButton)TabExercises.TabPages[count.ToString()].Controls["AnswerGroup" + count.ToString()].Controls["RadioResposta3-" + count.ToString()]).Checked)
                {
                    resp = 3;
                }
                else if (((RadioButton)TabExercises.TabPages[count.ToString()].Controls["AnswerGroup" + count.ToString()].Controls["RadioResposta4-" + count.ToString()]).Checked)
                {
                    resp = 4;
                }
                else if (((RadioButton)TabExercises.TabPages[count.ToString()].Controls["AnswerGroup" + count.ToString()].Controls["RadioResposta5-" + count.ToString()]).Checked)
                {
                    resp = 5;
                }

                if (resp > 0 && resp <= 5)
                {
                    element.GetElementsByTagName("Question")[0].InnerText = TabExercises.TabPages[count.ToString()].Controls["TextPergunta" + count.ToString()].Text;
                    element.SetAttribute("Correct", resp.ToString());
                    element.GetElementsByTagName("Answer1")[0].InnerText = TabExercises.TabPages[count.ToString()].Controls["AnswerGroup" + count.ToString()].Controls["TextResposta1-" + count.ToString()].Text;
                    element.GetElementsByTagName("Answer2")[0].InnerText = TabExercises.TabPages[count.ToString()].Controls["AnswerGroup" + count.ToString()].Controls["TextResposta2-" + count.ToString()].Text;
                    element.GetElementsByTagName("Answer3")[0].InnerText = TabExercises.TabPages[count.ToString()].Controls["AnswerGroup" + count.ToString()].Controls["TextResposta3-" + count.ToString()].Text;
                    element.GetElementsByTagName("Answer4")[0].InnerText = TabExercises.TabPages[count.ToString()].Controls["AnswerGroup" + count.ToString()].Controls["TextResposta4-" + count.ToString()].Text;
                    element.GetElementsByTagName("Answer5")[0].InnerText = TabExercises.TabPages[count.ToString()].Controls["AnswerGroup" + count.ToString()].Controls["TextResposta5-" + count.ToString()].Text;
                }
            }

            doc.Save("Equations\\" + equation + ".xml");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
