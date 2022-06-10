namespace hike
{
    partial class aboutus
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.knowmore = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.knwcontent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // knowmore
            // 
            this.knowmore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.knowmore.AutoRoundedCorners = true;
            this.knowmore.BorderRadius = 21;
            this.knowmore.CheckedState.Parent = this.knowmore;
            this.knowmore.CustomImages.Parent = this.knowmore;
            this.knowmore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(164)))));
            this.knowmore.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.knowmore.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knowmore.ForeColor = System.Drawing.Color.White;
            this.knowmore.HoverState.Parent = this.knowmore;
            this.knowmore.Location = new System.Drawing.Point(188, 404);
            this.knowmore.Name = "knowmore";
            this.knowmore.ShadowDecoration.Parent = this.knowmore;
            this.knowmore.Size = new System.Drawing.Size(180, 45);
            this.knowmore.TabIndex = 1;
            this.knowmore.Text = "Know more";
            this.knowmore.Click += new System.EventHandler(this.knowmore_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox1.Image = global::hike.Properties.Resources.about_us;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, -3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(1148, 689);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // knwcontent
            // 
            this.knwcontent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.knwcontent.Location = new System.Drawing.Point(0, -3);
            this.knwcontent.Name = "knwcontent";
            this.knwcontent.Size = new System.Drawing.Size(1148, 692);
            this.knwcontent.TabIndex = 2;
            // 
            // aboutus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.knowmore);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.knwcontent);
            this.Name = "aboutus";
            this.Size = new System.Drawing.Size(1148, 689);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton knowmore;
        private System.Windows.Forms.Panel knwcontent;
    }
}
