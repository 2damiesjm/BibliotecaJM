namespace BibliotecaJM
{
    partial class FM_Modelo
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
            this.tbPrueba = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPrueba
            // 
            this.tbPrueba.Location = new System.Drawing.Point(492, 289);
            this.tbPrueba.Name = "tbPrueba";
            this.tbPrueba.Size = new System.Drawing.Size(100, 20);
            this.tbPrueba.TabIndex = 0;
            this.tbPrueba.Text = "prueba";
            // 
            // FM_Modelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.tbPrueba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FM_Modelo";
            this.Text = "FM_Modelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrueba;
    }
}