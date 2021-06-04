
namespace EslestirmeOyunu
{
    partial class YeniOyunForm
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
            this.gboSeviye = new System.Windows.Forms.GroupBox();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbZor = new System.Windows.Forms.RadioButton();
            this.rbKolay = new System.Windows.Forms.RadioButton();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gboSeviye.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboSeviye
            // 
            this.gboSeviye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboSeviye.Controls.Add(this.rbOrta);
            this.gboSeviye.Controls.Add(this.rbZor);
            this.gboSeviye.Controls.Add(this.rbKolay);
            this.gboSeviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboSeviye.Location = new System.Drawing.Point(90, 33);
            this.gboSeviye.Margin = new System.Windows.Forms.Padding(4);
            this.gboSeviye.Name = "gboSeviye";
            this.gboSeviye.Padding = new System.Windows.Forms.Padding(4);
            this.gboSeviye.Size = new System.Drawing.Size(332, 318);
            this.gboSeviye.TabIndex = 0;
            this.gboSeviye.TabStop = false;
            this.gboSeviye.Text = "SEVİYE";
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(58, 151);
            this.rbOrta.Margin = new System.Windows.Forms.Padding(4);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(162, 36);
            this.rbOrta.TabIndex = 2;
            this.rbOrta.Text = "Orta (6x6)";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbZor
            // 
            this.rbZor.AutoSize = true;
            this.rbZor.Location = new System.Drawing.Point(58, 218);
            this.rbZor.Margin = new System.Windows.Forms.Padding(4);
            this.rbZor.Name = "rbZor";
            this.rbZor.Size = new System.Drawing.Size(149, 36);
            this.rbZor.TabIndex = 1;
            this.rbZor.Text = "Zor (8x8)";
            this.rbZor.UseVisualStyleBackColor = true;
            // 
            // rbKolay
            // 
            this.rbKolay.AutoSize = true;
            this.rbKolay.Checked = true;
            this.rbKolay.Location = new System.Drawing.Point(58, 84);
            this.rbKolay.Margin = new System.Windows.Forms.Padding(4);
            this.rbKolay.Name = "rbKolay";
            this.rbKolay.Size = new System.Drawing.Size(179, 36);
            this.rbKolay.TabIndex = 0;
            this.rbKolay.TabStop = true;
            this.rbKolay.Text = "Kolay (4x4)";
            this.rbKolay.UseVisualStyleBackColor = true;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(90, 358);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(332, 56);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "OYUNU BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(90, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "OYUNDAN ÇIK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YeniOyunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.gboSeviye);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YeniOyunForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eşleştirme Oyunu";
            this.gboSeviye.ResumeLayout(false);
            this.gboSeviye.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboSeviye;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbZor;
        private System.Windows.Forms.RadioButton rbKolay;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button button1;
    }
}