
namespace Sisarp
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
            this.btn_cv = new System.Windows.Forms.Button();
            this.btn_altcv = new System.Windows.Forms.Button();
            this.lbl_scris = new System.Windows.Forms.Label();
            this.btn_aparitie = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cv
            // 
            this.btn_cv.BackColor = System.Drawing.SystemColors.Info;
            this.btn_cv.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_cv.Location = new System.Drawing.Point(57, 92);
            this.btn_cv.Name = "btn_cv";
            this.btn_cv.Size = new System.Drawing.Size(165, 77);
            this.btn_cv.TabIndex = 0;
            this.btn_cv.Text = "\"Ceva\"";
            this.btn_cv.UseVisualStyleBackColor = false;
            this.btn_cv.Click += new System.EventHandler(this.btn_cv_Click);
            // 
            // btn_altcv
            // 
            this.btn_altcv.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_altcv.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_altcv.Location = new System.Drawing.Point(591, 91);
            this.btn_altcv.Name = "btn_altcv";
            this.btn_altcv.Size = new System.Drawing.Size(155, 77);
            this.btn_altcv.TabIndex = 1;
            this.btn_altcv.Text = "\"Altceva\"";
            this.btn_altcv.UseVisualStyleBackColor = true;
            this.btn_altcv.Click += new System.EventHandler(this.btn_altcv_Click);
            // 
            // lbl_scris
            // 
            this.lbl_scris.AutoSize = true;
            this.lbl_scris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scris.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_scris.Location = new System.Drawing.Point(375, 249);
            this.lbl_scris.Name = "lbl_scris";
            this.lbl_scris.Size = new System.Drawing.Size(0, 29);
            this.lbl_scris.TabIndex = 2;
            // 
            // btn_aparitie
            // 
            this.btn_aparitie.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_aparitie.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aparitie.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_aparitie.Location = new System.Drawing.Point(265, 91);
            this.btn_aparitie.Name = "btn_aparitie";
            this.btn_aparitie.Size = new System.Drawing.Size(271, 77);
            this.btn_aparitie.TabIndex = 3;
            this.btn_aparitie.Text = "Apar/Dispar";
            this.btn_aparitie.UseVisualStyleBackColor = false;
            this.btn_aparitie.Click += new System.EventHandler(this.btn_aparitie_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(57, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(689, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Afiseaza mesaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(57, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(689, 63);
            this.button2.TabIndex = 5;
            this.button2.Text = "Apasa pentru forma urmatoare!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_aparitie);
            this.Controls.Add(this.lbl_scris);
            this.Controls.Add(this.btn_altcv);
            this.Controls.Add(this.btn_cv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cv;
        private System.Windows.Forms.Button btn_altcv;
        private System.Windows.Forms.Label lbl_scris;
        private System.Windows.Forms.Button btn_aparitie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

