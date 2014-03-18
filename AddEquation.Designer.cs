namespace SoftEquation
{
    partial class AddEquation
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
            this.TextDescricao = new System.Windows.Forms.RichTextBox();
            this.TextNome = new System.Windows.Forms.TextBox();
            this.TextCriador = new System.Windows.Forms.TextBox();
            this.BotaoOk = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextCategoria = new System.Windows.Forms.ComboBox();
            this.TextEquation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextDescricao
            // 
            this.TextDescricao.Location = new System.Drawing.Point(12, 103);
            this.TextDescricao.Name = "TextDescricao";
            this.TextDescricao.Size = new System.Drawing.Size(360, 118);
            this.TextDescricao.TabIndex = 4;
            this.TextDescricao.Text = "";
            // 
            // TextNome
            // 
            this.TextNome.Location = new System.Drawing.Point(67, 12);
            this.TextNome.Name = "TextNome";
            this.TextNome.Size = new System.Drawing.Size(305, 20);
            this.TextNome.TabIndex = 0;
            // 
            // TextCriador
            // 
            this.TextCriador.Location = new System.Drawing.Point(67, 38);
            this.TextCriador.Name = "TextCriador";
            this.TextCriador.Size = new System.Drawing.Size(120, 20);
            this.TextCriador.TabIndex = 1;
            // 
            // BotaoOk
            // 
            this.BotaoOk.Location = new System.Drawing.Point(216, 227);
            this.BotaoOk.Name = "BotaoOk";
            this.BotaoOk.Size = new System.Drawing.Size(75, 23);
            this.BotaoOk.TabIndex = 5;
            this.BotaoOk.Text = "&OK";
            this.BotaoOk.UseVisualStyleBackColor = true;
            this.BotaoOk.Click += new System.EventHandler(this.BotaoOk_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BotaoCancelar.Location = new System.Drawing.Point(297, 227);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 6;
            this.BotaoCancelar.Text = "&Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Criador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descrição";
            // 
            // TextCategoria
            // 
            this.TextCategoria.FormattingEnabled = true;
            this.TextCategoria.Location = new System.Drawing.Point(251, 38);
            this.TextCategoria.Name = "TextCategoria";
            this.TextCategoria.Size = new System.Drawing.Size(121, 21);
            this.TextCategoria.TabIndex = 2;
            // 
            // TextEquation
            // 
            this.TextEquation.Location = new System.Drawing.Point(67, 64);
            this.TextEquation.Name = "TextEquation";
            this.TextEquation.Size = new System.Drawing.Size(305, 20);
            this.TextEquation.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Equação";
            // 
            // AddEquation
            // 
            this.AcceptButton = this.BotaoOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BotaoCancelar;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextEquation);
            this.Controls.Add(this.TextCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoOk);
            this.Controls.Add(this.TextCriador);
            this.Controls.Add(this.TextNome);
            this.Controls.Add(this.TextDescricao);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "AddEquation";
            this.ShowIcon = false;
            this.Text = "Nova Equação";
            this.Load += new System.EventHandler(this.AddEquation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextDescricao;
        private System.Windows.Forms.TextBox TextNome;
        private System.Windows.Forms.TextBox TextCriador;
        private System.Windows.Forms.Button BotaoOk;
        private System.Windows.Forms.Button BotaoCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TextCategoria;
        private System.Windows.Forms.TextBox TextEquation;
        private System.Windows.Forms.Label label5;
    }
}