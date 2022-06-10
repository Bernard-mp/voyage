namespace hike
{
    partial class contactus
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.send = new Guna.UI2.WinForms.Guna2GradientButton();
            this.mailid = new Guna.UI2.WinForms.Guna2TextBox();
            this.message = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::hike.Properties.Resources.contact_us;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1180, 689);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // send
            // 
            this.send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.send.AutoRoundedCorners = true;
            this.send.BorderRadius = 15;
            this.send.CheckedState.Parent = this.send;
            this.send.CustomImages.Parent = this.send;
            this.send.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(197)))), ((int)(((byte)(241)))));
            this.send.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(79)))), ((int)(((byte)(171)))));
            this.send.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.HoverState.Parent = this.send;
            this.send.Location = new System.Drawing.Point(164, 553);
            this.send.Name = "send";
            this.send.ShadowDecoration.Parent = this.send;
            this.send.Size = new System.Drawing.Size(180, 32);
            this.send.TabIndex = 2;
            this.send.Text = "Send";
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // mailid
            // 
            this.mailid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mailid.BorderThickness = 2;
            this.mailid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mailid.DefaultText = "";
            this.mailid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mailid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mailid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mailid.DisabledState.Parent = this.mailid;
            this.mailid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mailid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mailid.FocusedState.Parent = this.mailid;
            this.mailid.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mailid.HoverState.Parent = this.mailid;
            this.mailid.Location = new System.Drawing.Point(16, 244);
            this.mailid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mailid.Name = "mailid";
            this.mailid.PasswordChar = '\0';
            this.mailid.PlaceholderText = "email";
            this.mailid.SelectedText = "";
            this.mailid.ShadowDecoration.Parent = this.mailid;
            this.mailid.Size = new System.Drawing.Size(493, 37);
            this.mailid.TabIndex = 3;
            this.mailid.TextChanged += new System.EventHandler(this.mailid_TextChanged);
            // 
            // message
            // 
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.message.BorderThickness = 2;
            this.message.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.message.DefaultText = "";
            this.message.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.message.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.message.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.message.DisabledState.Parent = this.message;
            this.message.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.message.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.message.FocusedState.Parent = this.message;
            this.message.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.message.HoverState.Parent = this.message;
            this.message.Location = new System.Drawing.Point(16, 293);
            this.message.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.PasswordChar = '\0';
            this.message.PlaceholderText = "Your Message";
            this.message.SelectedText = "";
            this.message.ShadowDecoration.Parent = this.message;
            this.message.Size = new System.Drawing.Size(493, 231);
            this.message.TabIndex = 3;
            this.message.TextChanged += new System.EventHandler(this.message_TextChanged);
            // 
            // contactus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.message);
            this.Controls.Add(this.mailid);
            this.Controls.Add(this.send);
            this.Controls.Add(this.pictureBox1);
            this.Name = "contactus";
            this.Size = new System.Drawing.Size(1148, 689);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton send;
        private Guna.UI2.WinForms.Guna2TextBox mailid;
        private Guna.UI2.WinForms.Guna2TextBox message;
    }
}
