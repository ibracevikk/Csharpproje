
namespace hastaneoto
{
    partial class Sekreter_Giriş
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
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.btngirisyap = new System.Windows.Forms.Button();
            this.lnküyeol = new System.Windows.Forms.LinkLabel();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(193, 81);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(100, 22);
            this.msktc.TabIndex = 1;
            this.msktc.Text = "11111111111";
            // 
            // btngirisyap
            // 
            this.btngirisyap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btngirisyap.Location = new System.Drawing.Point(218, 137);
            this.btngirisyap.Name = "btngirisyap";
            this.btngirisyap.Size = new System.Drawing.Size(75, 24);
            this.btngirisyap.TabIndex = 13;
            this.btngirisyap.Text = "Giriş Yap";
            this.btngirisyap.UseVisualStyleBackColor = true;
            this.btngirisyap.Click += new System.EventHandler(this.btngirisyap_Click);
            // 
            // lnküyeol
            // 
            this.lnküyeol.AutoSize = true;
            this.lnküyeol.Location = new System.Drawing.Point(215, 164);
            this.lnküyeol.Name = "lnküyeol";
            this.lnküyeol.Size = new System.Drawing.Size(51, 17);
            this.lnküyeol.TabIndex = 12;
            this.lnküyeol.TabStop = true;
            this.lnküyeol.Text = "Üye Ol";
            // 
            // txtsifre
            // 
            this.txtsifre.AcceptsTab = true;
            this.txtsifre.Location = new System.Drawing.Point(193, 109);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(100, 22);
            this.txtsifre.TabIndex = 2;
            this.txtsifre.Text = "1234";
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "TC NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sekreter Giriş Paneli";
            // 
            // Sekreter_Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(500, 241);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.btngirisyap);
            this.Controls.Add(this.lnküyeol);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sekreter_Giriş";
            this.Text = "Sekreter_Giriş";
            this.Load += new System.EventHandler(this.Sekreter_Giriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Button btngirisyap;
        private System.Windows.Forms.LinkLabel lnküyeol;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}