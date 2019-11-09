namespace WFAIntro2
{
    partial class Form1
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
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnRenk = new System.Windows.Forms.Button();
            this.txtAlan = new System.Windows.Forms.TextBox();
            this.lblYazi = new System.Windows.Forms.Label();
            this.btnYokEt = new System.Windows.Forms.Button();
            this.btnForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(32, 23);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(120, 31);
            this.btnDegistir.TabIndex = 0;
            this.btnDegistir.Text = "Degistir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnRenk
            // 
            this.btnRenk.Location = new System.Drawing.Point(36, 85);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(137, 35);
            this.btnRenk.TabIndex = 1;
            this.btnRenk.Text = "Renk Degistir";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // txtAlan
            // 
            this.txtAlan.Location = new System.Drawing.Point(264, 28);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(150, 30);
            this.txtAlan.TabIndex = 2;
            this.txtAlan.TextChanged += new System.EventHandler(this.txtAlan_TextChanged);
            // 
            // lblYazi
            // 
            this.lblYazi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYazi.Location = new System.Drawing.Point(259, 102);
            this.lblYazi.Name = "lblYazi";
            this.lblYazi.Size = new System.Drawing.Size(159, 28);
            this.lblYazi.TabIndex = 3;
            // 
            // btnYokEt
            // 
            this.btnYokEt.Location = new System.Drawing.Point(32, 153);
            this.btnYokEt.Name = "btnYokEt";
            this.btnYokEt.Size = new System.Drawing.Size(111, 28);
            this.btnYokEt.TabIndex = 4;
            this.btnYokEt.Text = "Yok Et";
            this.btnYokEt.UseVisualStyleBackColor = true;
            this.btnYokEt.Click += new System.EventHandler(this.btnYokEt_Click);
            // 
            // btnForm
            // 
            this.btnForm.Location = new System.Drawing.Point(289, 167);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(84, 23);
            this.btnForm.TabIndex = 5;
            this.btnForm.Text = "Title";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 230);
            this.Controls.Add(this.btnForm);
            this.Controls.Add(this.btnYokEt);
            this.Controls.Add(this.lblYazi);
            this.Controls.Add(this.txtAlan);
            this.Controls.Add(this.btnRenk);
            this.Controls.Add(this.btnDegistir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.TextBox txtAlan;
        private System.Windows.Forms.Label lblYazi;
        private System.Windows.Forms.Button btnYokEt;
        private System.Windows.Forms.Button btnForm;
    }
}

