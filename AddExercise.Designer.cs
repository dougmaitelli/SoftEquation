namespace SoftEquation
{
    partial class AddExercise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.BotaoOK = new System.Windows.Forms.Button();
            this.TextPergunta = new System.Windows.Forms.RichTextBox();
            this.TextResposta2 = new System.Windows.Forms.TextBox();
            this.TextResposta1 = new System.Windows.Forms.TextBox();
            this.TextResposta5 = new System.Windows.Forms.TextBox();
            this.TextResposta4 = new System.Windows.Forms.TextBox();
            this.TextResposta3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioResposta5 = new System.Windows.Forms.RadioButton();
            this.RadioResposta4 = new System.Windows.Forms.RadioButton();
            this.RadioResposta3 = new System.Windows.Forms.RadioButton();
            this.RadioResposta2 = new System.Windows.Forms.RadioButton();
            this.RadioResposta1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BotaoCancelar.Location = new System.Drawing.Point(297, 427);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 7;
            this.BotaoCancelar.Text = "Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // BotaoOK
            // 
            this.BotaoOK.Location = new System.Drawing.Point(216, 427);
            this.BotaoOK.Name = "BotaoOK";
            this.BotaoOK.Size = new System.Drawing.Size(75, 23);
            this.BotaoOK.TabIndex = 6;
            this.BotaoOK.Text = "OK";
            this.BotaoOK.UseVisualStyleBackColor = true;
            this.BotaoOK.Click += new System.EventHandler(this.BotaoOK_Click);
            // 
            // TextPergunta
            // 
            this.TextPergunta.Location = new System.Drawing.Point(12, 25);
            this.TextPergunta.Name = "TextPergunta";
            this.TextPergunta.Size = new System.Drawing.Size(360, 96);
            this.TextPergunta.TabIndex = 0;
            this.TextPergunta.Text = "";
            // 
            // TextResposta2
            // 
            this.TextResposta2.Location = new System.Drawing.Point(6, 91);
            this.TextResposta2.Name = "TextResposta2";
            this.TextResposta2.Size = new System.Drawing.Size(348, 20);
            this.TextResposta2.TabIndex = 2;
            // 
            // TextResposta1
            // 
            this.TextResposta1.Location = new System.Drawing.Point(6, 42);
            this.TextResposta1.Name = "TextResposta1";
            this.TextResposta1.Size = new System.Drawing.Size(348, 20);
            this.TextResposta1.TabIndex = 1;
            // 
            // TextResposta5
            // 
            this.TextResposta5.Location = new System.Drawing.Point(6, 238);
            this.TextResposta5.Name = "TextResposta5";
            this.TextResposta5.Size = new System.Drawing.Size(348, 20);
            this.TextResposta5.TabIndex = 5;
            // 
            // TextResposta4
            // 
            this.TextResposta4.Location = new System.Drawing.Point(6, 189);
            this.TextResposta4.Name = "TextResposta4";
            this.TextResposta4.Size = new System.Drawing.Size(348, 20);
            this.TextResposta4.TabIndex = 4;
            // 
            // TextResposta3
            // 
            this.TextResposta3.Location = new System.Drawing.Point(6, 140);
            this.TextResposta3.Name = "TextResposta3";
            this.TextResposta3.Size = new System.Drawing.Size(348, 20);
            this.TextResposta3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pergunta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioResposta5);
            this.groupBox1.Controls.Add(this.RadioResposta4);
            this.groupBox1.Controls.Add(this.RadioResposta3);
            this.groupBox1.Controls.Add(this.RadioResposta2);
            this.groupBox1.Controls.Add(this.RadioResposta1);
            this.groupBox1.Controls.Add(this.TextResposta2);
            this.groupBox1.Controls.Add(this.TextResposta1);
            this.groupBox1.Controls.Add(this.TextResposta5);
            this.groupBox1.Controls.Add(this.TextResposta4);
            this.groupBox1.Controls.Add(this.TextResposta3);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 266);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Respostas";
            // 
            // RadioResposta5
            // 
            this.RadioResposta5.AutoSize = true;
            this.RadioResposta5.Location = new System.Drawing.Point(6, 215);
            this.RadioResposta5.Name = "RadioResposta5";
            this.RadioResposta5.Size = new System.Drawing.Size(79, 17);
            this.RadioResposta5.TabIndex = 18;
            this.RadioResposta5.TabStop = true;
            this.RadioResposta5.Text = "Resposta 5";
            this.RadioResposta5.UseVisualStyleBackColor = true;
            // 
            // RadioResposta4
            // 
            this.RadioResposta4.AutoSize = true;
            this.RadioResposta4.Location = new System.Drawing.Point(6, 166);
            this.RadioResposta4.Name = "RadioResposta4";
            this.RadioResposta4.Size = new System.Drawing.Size(79, 17);
            this.RadioResposta4.TabIndex = 17;
            this.RadioResposta4.TabStop = true;
            this.RadioResposta4.Text = "Resposta 4";
            this.RadioResposta4.UseVisualStyleBackColor = true;
            // 
            // RadioResposta3
            // 
            this.RadioResposta3.AutoSize = true;
            this.RadioResposta3.Location = new System.Drawing.Point(6, 117);
            this.RadioResposta3.Name = "RadioResposta3";
            this.RadioResposta3.Size = new System.Drawing.Size(79, 17);
            this.RadioResposta3.TabIndex = 16;
            this.RadioResposta3.TabStop = true;
            this.RadioResposta3.Text = "Resposta 3";
            this.RadioResposta3.UseVisualStyleBackColor = true;
            // 
            // RadioResposta2
            // 
            this.RadioResposta2.AutoSize = true;
            this.RadioResposta2.Location = new System.Drawing.Point(6, 68);
            this.RadioResposta2.Name = "RadioResposta2";
            this.RadioResposta2.Size = new System.Drawing.Size(79, 17);
            this.RadioResposta2.TabIndex = 15;
            this.RadioResposta2.TabStop = true;
            this.RadioResposta2.Text = "Resposta 2";
            this.RadioResposta2.UseVisualStyleBackColor = true;
            // 
            // RadioResposta1
            // 
            this.RadioResposta1.AutoSize = true;
            this.RadioResposta1.Location = new System.Drawing.Point(6, 19);
            this.RadioResposta1.Name = "RadioResposta1";
            this.RadioResposta1.Size = new System.Drawing.Size(79, 17);
            this.RadioResposta1.TabIndex = 14;
            this.RadioResposta1.TabStop = true;
            this.RadioResposta1.Text = "Resposta 1";
            this.RadioResposta1.UseVisualStyleBackColor = true;
            // 
            // AddExercise
            // 
            this.AcceptButton = this.BotaoOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BotaoCancelar;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextPergunta);
            this.Controls.Add(this.BotaoOK);
            this.Controls.Add(this.BotaoCancelar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "AddExercise";
            this.ShowIcon = false;
            this.Text = "Adicionar Exercício";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotaoCancelar;
        private System.Windows.Forms.Button BotaoOK;
        private System.Windows.Forms.RichTextBox TextPergunta;
        private System.Windows.Forms.TextBox TextResposta2;
        private System.Windows.Forms.TextBox TextResposta1;
        private System.Windows.Forms.TextBox TextResposta5;
        private System.Windows.Forms.TextBox TextResposta4;
        private System.Windows.Forms.TextBox TextResposta3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioResposta1;
        private System.Windows.Forms.RadioButton RadioResposta5;
        private System.Windows.Forms.RadioButton RadioResposta4;
        private System.Windows.Forms.RadioButton RadioResposta3;
        private System.Windows.Forms.RadioButton RadioResposta2;
    }
}