namespace SoftEquation
{
    partial class EditExercise
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
            this.BotaoOK = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.TabExercises = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // BotaoOK
            // 
            this.BotaoOK.Location = new System.Drawing.Point(216, 427);
            this.BotaoOK.Name = "BotaoOK";
            this.BotaoOK.Size = new System.Drawing.Size(75, 23);
            this.BotaoOK.TabIndex = 19;
            this.BotaoOK.Text = "OK";
            this.BotaoOK.UseVisualStyleBackColor = true;
            this.BotaoOK.Click += new System.EventHandler(this.BotaoOK_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BotaoCancelar.Location = new System.Drawing.Point(297, 427);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 20;
            this.BotaoCancelar.Text = "Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // TabExercises
            // 
            this.TabExercises.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabExercises.Location = new System.Drawing.Point(0, 0);
            this.TabExercises.Name = "TabExercises";
            this.TabExercises.SelectedIndex = 0;
            this.TabExercises.Size = new System.Drawing.Size(384, 421);
            this.TabExercises.TabIndex = 18;
            // 
            // EditExercise
            // 
            this.AcceptButton = this.BotaoOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BotaoCancelar;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.BotaoOK);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.TabExercises);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "EditExercise";
            this.ShowIcon = false;
            this.Text = "Editar Exercício";
            this.Load += new System.EventHandler(this.EditExercise_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotaoOK;
        private System.Windows.Forms.Button BotaoCancelar;
        private System.Windows.Forms.TabControl TabExercises;
    }
}