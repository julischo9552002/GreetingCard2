namespace GreetingCard2
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
            this.label = new System.Windows.Forms.Label();
            this.cancerpicturebox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cancerpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(173, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(547, 145);
            this.label.TabIndex = 0;
            this.label.Text = "Cancer";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancerpicturebox
            // 
            this.cancerpicturebox.BackColor = System.Drawing.Color.Transparent;
            this.cancerpicturebox.BackgroundImage = global::GreetingCard2.Properties.Resources.transparent;
            this.cancerpicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancerpicturebox.Location = new System.Drawing.Point(114, 239);
            this.cancerpicturebox.Name = "cancerpicturebox";
            this.cancerpicturebox.Size = new System.Drawing.Size(685, 439);
            this.cancerpicturebox.TabIndex = 1;
            this.cancerpicturebox.TabStop = false;
            this.cancerpicturebox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 99);
            this.label1.TabIndex = 2;
            this.label1.Text = "J. Scholz  Sep 21st, 2017";
            // 
            // Form1
            // 
            this.BackgroundImage = global::GreetingCard2.Properties.Resources.coolstarsatthesky;
            this.ClientSize = new System.Drawing.Size(914, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancerpicturebox);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cancerpicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cancerlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ownerlabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox cancerpicturebox;
        private System.Windows.Forms.Label label1;
    }
}

