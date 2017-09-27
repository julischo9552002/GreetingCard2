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
            this.labelcancer = new System.Windows.Forms.Label();
            this.cancerpicturebox = new System.Windows.Forms.PictureBox();
            this.labelowner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cancerpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelcancer
            // 
            this.labelcancer.BackColor = System.Drawing.Color.Transparent;
            this.labelcancer.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcancer.ForeColor = System.Drawing.Color.Black;
            this.labelcancer.Location = new System.Drawing.Point(173, 31);
            this.labelcancer.Name = "labelcancer";
            this.labelcancer.Size = new System.Drawing.Size(547, 145);
            this.labelcancer.TabIndex = 0;
            this.labelcancer.Text = "Cancer";
            this.labelcancer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelcancer.Click += new System.EventHandler(this.pictureboxcancer_Click);
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
            this.cancerpicturebox.Click += new System.EventHandler(this.pictureboxcancer_Click);
            // 
            // labelowner
            // 
            this.labelowner.BackColor = System.Drawing.Color.Transparent;
            this.labelowner.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelowner.Location = new System.Drawing.Point(23, 603);
            this.labelowner.Name = "labelowner";
            this.labelowner.Size = new System.Drawing.Size(148, 99);
            this.labelowner.TabIndex = 2;
            this.labelowner.Text = "J. Scholz  Sep 27th, 2017";
            this.labelowner.Click += new System.EventHandler(this.pictureboxcancer_Click);
            // 
            // Form1
            // 
            this.BackgroundImage = global::GreetingCard2.Properties.Resources.coolstarsatthesky;
            this.ClientSize = new System.Drawing.Size(914, 720);
            this.Controls.Add(this.labelowner);
            this.Controls.Add(this.cancerpicturebox);
            this.Controls.Add(this.labelcancer);
            this.Name = "Form1";
            this.Click += new System.EventHandler(this.pictureboxcancer_Click);
            ((System.ComponentModel.ISupportInitialize)(this.cancerpicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cancerlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ownerlabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label labelcancer;
        private System.Windows.Forms.PictureBox cancerpicturebox;
        private System.Windows.Forms.Label labelowner;
    }
}

