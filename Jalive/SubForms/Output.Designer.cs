
namespace Jalive.SubForms
{
    partial class Output
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Output));
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.guna2Panel4.BorderRadius = 6;
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.richTextBox1);
            this.guna2Panel4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.guna2Panel4.Location = new System.Drawing.Point(29, 54);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(433, 176);
            this.guna2Panel4.TabIndex = 38;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.richTextBox1.Location = new System.Drawing.Point(9, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(414, 156);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(488, 287);
            this.Controls.Add(this.guna2Panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Output";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Output";
            this.guna2Panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}