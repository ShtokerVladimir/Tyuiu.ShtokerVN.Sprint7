
namespace Tyuiu.ShtokerVN.Sprint7.V2
{
    partial class FormAbout_SHVN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_SHVN));
            this.textBoxAbout_SHVN = new System.Windows.Forms.TextBox();
            this.pictureBoxAutor_SHVN = new System.Windows.Forms.PictureBox();
            this.buttonOK_SHVN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutor_SHVN)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAbout_SHVN
            // 
            this.textBoxAbout_SHVN.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAbout_SHVN.Location = new System.Drawing.Point(178, 12);
            this.textBoxAbout_SHVN.Multiline = true;
            this.textBoxAbout_SHVN.Name = "textBoxAbout_SHVN";
            this.textBoxAbout_SHVN.Size = new System.Drawing.Size(372, 179);
            this.textBoxAbout_SHVN.TabIndex = 0;
            this.textBoxAbout_SHVN.Text = "Разработчик: Штокер В.Н.\r\nгруппа: ИИПБ-23-1\r\n\r\nПрограмма разработана в рамках изу" +
    "чения C#\r\n\r\nТюменски индустриальный университет (с) 2023\r\nВысшая школа цифровых " +
    "технологий (с) 2023\r\n\r\n\r\n";
            // 
            // pictureBoxAutor_SHVN
            // 
            this.pictureBoxAutor_SHVN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAutor_SHVN.Image")));
            this.pictureBoxAutor_SHVN.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAutor_SHVN.Name = "pictureBoxAutor_SHVN";
            this.pictureBoxAutor_SHVN.Size = new System.Drawing.Size(160, 179);
            this.pictureBoxAutor_SHVN.TabIndex = 1;
            this.pictureBoxAutor_SHVN.TabStop = false;
            // 
            // buttonOK_SHVN
            // 
            this.buttonOK_SHVN.Location = new System.Drawing.Point(475, 208);
            this.buttonOK_SHVN.Name = "buttonOK_SHVN";
            this.buttonOK_SHVN.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_SHVN.TabIndex = 2;
            this.buttonOK_SHVN.Text = "OK";
            this.buttonOK_SHVN.UseVisualStyleBackColor = true;
            this.buttonOK_SHVN.Click += new System.EventHandler(this.buttonOK_SHVN_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 243);
            this.Controls.Add(this.buttonOK_SHVN);
            this.Controls.Add(this.pictureBoxAutor_SHVN);
            this.Controls.Add(this.textBoxAbout_SHVN);
            this.Name = "FormAbout";
            this.Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutor_SHVN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAbout_SHVN;
        private System.Windows.Forms.PictureBox pictureBoxAutor_SHVN;
        private System.Windows.Forms.Button buttonOK_SHVN;
    }
}