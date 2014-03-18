namespace SoftEquation
{
    partial class ExercisesForm
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
            this.Painel = new System.Windows.Forms.Panel();
            this.Nota = new System.Windows.Forms.Label();
            this.Acertos = new System.Windows.Forms.Label();
            this.BotaoConferir = new System.Windows.Forms.Button();
            this.ScrollBar = new System.Windows.Forms.VScrollBar();
            this.Painel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Painel
            // 
            this.Painel.Controls.Add(this.Nota);
            this.Painel.Controls.Add(this.Acertos);
            this.Painel.Controls.Add(this.BotaoConferir);
            this.Painel.Location = new System.Drawing.Point(0, 0);
            this.Painel.Name = "Painel";
            this.Painel.Size = new System.Drawing.Size(472, 1500);
            this.Painel.TabIndex = 0;
            // 
            // Nota
            // 
            this.Nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nota.Location = new System.Drawing.Point(118, 523);
            this.Nota.Name = "Nota";
            this.Nota.Size = new System.Drawing.Size(100, 23);
            this.Nota.TabIndex = 2;
            // 
            // Acertos
            // 
            this.Acertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acertos.Location = new System.Drawing.Point(12, 527);
            this.Acertos.Name = "Acertos";
            this.Acertos.Size = new System.Drawing.Size(100, 23);
            this.Acertos.TabIndex = 1;
            // 
            // BotaoConferir
            // 
            this.BotaoConferir.Location = new System.Drawing.Point(389, 527);
            this.BotaoConferir.Name = "BotaoConferir";
            this.BotaoConferir.Size = new System.Drawing.Size(75, 23);
            this.BotaoConferir.TabIndex = 0;
            this.BotaoConferir.Text = "Conferir";
            this.BotaoConferir.UseVisualStyleBackColor = true;
            this.BotaoConferir.Click += new System.EventHandler(this.BotaoConferir_Click);
            // 
            // ScrollBar
            // 
            this.ScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScrollBar.Location = new System.Drawing.Point(467, 0);
            this.ScrollBar.Maximum = 700;
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.Size = new System.Drawing.Size(17, 562);
            this.ScrollBar.TabIndex = 1;
            this.ScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar_Scroll);
            // 
            // ExercisesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 562);
            this.Controls.Add(this.ScrollBar);
            this.Controls.Add(this.Painel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "ExercisesForm";
            this.ShowIcon = false;
            this.Text = "Exercícios";
            this.Load += new System.EventHandler(this.ExercisesForm_Load);
            this.Painel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Painel;
        private System.Windows.Forms.VScrollBar ScrollBar;
        private System.Windows.Forms.Button BotaoConferir;
        private System.Windows.Forms.Label Nota;
        private System.Windows.Forms.Label Acertos;


    }
}