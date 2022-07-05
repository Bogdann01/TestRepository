namespace Indeplinire_Task_uri
{
    partial class Form5
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
            this.btn_tab2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_tab2
            // 
            this.btn_tab2.Location = new System.Drawing.Point(586, 418);
            this.btn_tab2.Name = "btn_tab2";
            this.btn_tab2.Size = new System.Drawing.Size(202, 29);
            this.btn_tab2.TabIndex = 4;
            this.btn_tab2.Text = "Treci la tab-ul urmator";
            this.btn_tab2.UseVisualStyleBackColor = true;
            this.btn_tab2.Click += new System.EventHandler(this.btn_tab2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_tab2);
            this.Name = "Form5";
            this.Text = "Imagini";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_tab2;
    }
}