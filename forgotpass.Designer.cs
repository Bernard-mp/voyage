namespace hike
{
    partial class forgotpass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotpass));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fgtmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.fgtusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.fgtsend = new Guna.UI2.WinForms.Guna2Button();
            this.otpvalid = new System.Windows.Forms.Panel();
            this.otpverify = new Guna.UI2.WinForms.Guna2Button();
            this.otpreader = new Guna.UI2.WinForms.Guna2TextBox();
            this.otpsent = new System.Windows.Forms.Label();
            this.usermess = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.otpvalid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1137, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(46, 29);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reset Password";
            // 
            // fgtmail
            // 
            this.fgtmail.AutoRoundedCorners = true;
            this.fgtmail.BackColor = System.Drawing.Color.White;
            this.fgtmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(181)))), ((int)(((byte)(114)))));
            this.fgtmail.BorderRadius = 19;
            this.fgtmail.BorderThickness = 2;
            this.fgtmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fgtmail.DefaultText = "";
            this.fgtmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fgtmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fgtmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fgtmail.DisabledState.Parent = this.fgtmail;
            this.fgtmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fgtmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fgtmail.FocusedState.Parent = this.fgtmail;
            this.fgtmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgtmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fgtmail.HoverState.Parent = this.fgtmail;
            this.fgtmail.Location = new System.Drawing.Point(346, 211);
            this.fgtmail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.fgtmail.Name = "fgtmail";
            this.fgtmail.PasswordChar = '\0';
            this.fgtmail.PlaceholderText = "email";
            this.fgtmail.SelectedText = "";
            this.fgtmail.ShadowDecoration.Parent = this.fgtmail;
            this.fgtmail.Size = new System.Drawing.Size(427, 40);
            this.fgtmail.TabIndex = 3;
            this.fgtmail.TextChanged += new System.EventHandler(this.fgtmail_TextChanged);
            // 
            // fgtusername
            // 
            this.fgtusername.AutoRoundedCorners = true;
            this.fgtusername.BackColor = System.Drawing.Color.White;
            this.fgtusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(181)))), ((int)(((byte)(114)))));
            this.fgtusername.BorderRadius = 19;
            this.fgtusername.BorderThickness = 2;
            this.fgtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fgtusername.DefaultText = "";
            this.fgtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fgtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fgtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fgtusername.DisabledState.Parent = this.fgtusername;
            this.fgtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fgtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fgtusername.FocusedState.Parent = this.fgtusername;
            this.fgtusername.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fgtusername.HoverState.Parent = this.fgtusername;
            this.fgtusername.Location = new System.Drawing.Point(346, 139);
            this.fgtusername.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.fgtusername.Name = "fgtusername";
            this.fgtusername.PasswordChar = '\0';
            this.fgtusername.PlaceholderText = "username";
            this.fgtusername.SelectedText = "";
            this.fgtusername.ShadowDecoration.Parent = this.fgtusername;
            this.fgtusername.Size = new System.Drawing.Size(427, 40);
            this.fgtusername.TabIndex = 3;
            this.fgtusername.TextChanged += new System.EventHandler(this.fgtusername_TextChanged);
            // 
            // fgtsend
            // 
            this.fgtsend.AutoRoundedCorners = true;
            this.fgtsend.BackColor = System.Drawing.Color.White;
            this.fgtsend.BorderRadius = 16;
            this.fgtsend.CheckedState.Parent = this.fgtsend;
            this.fgtsend.CustomImages.Parent = this.fgtsend;
            this.fgtsend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(255)))));
            this.fgtsend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fgtsend.ForeColor = System.Drawing.Color.White;
            this.fgtsend.HoverState.Parent = this.fgtsend;
            this.fgtsend.Location = new System.Drawing.Point(368, 260);
            this.fgtsend.Name = "fgtsend";
            this.fgtsend.ShadowDecoration.Parent = this.fgtsend;
            this.fgtsend.Size = new System.Drawing.Size(124, 34);
            this.fgtsend.TabIndex = 4;
            this.fgtsend.Text = "send otp";
            this.fgtsend.Click += new System.EventHandler(this.fgtsend_Click);
            // 
            // otpvalid
            // 
            this.otpvalid.BackColor = System.Drawing.Color.White;
            this.otpvalid.Controls.Add(this.otpverify);
            this.otpvalid.Controls.Add(this.otpreader);
            this.otpvalid.Controls.Add(this.otpsent);
            this.otpvalid.Location = new System.Drawing.Point(418, 331);
            this.otpvalid.Name = "otpvalid";
            this.otpvalid.Size = new System.Drawing.Size(379, 230);
            this.otpvalid.TabIndex = 5;
            // 
            // otpverify
            // 
            this.otpverify.AutoRoundedCorners = true;
            this.otpverify.BorderRadius = 16;
            this.otpverify.CheckedState.Parent = this.otpverify;
            this.otpverify.CustomImages.Parent = this.otpverify;
            this.otpverify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(255)))));
            this.otpverify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.otpverify.ForeColor = System.Drawing.Color.White;
            this.otpverify.HoverState.Parent = this.otpverify;
            this.otpverify.Location = new System.Drawing.Point(85, 91);
            this.otpverify.Name = "otpverify";
            this.otpverify.ShadowDecoration.Parent = this.otpverify;
            this.otpverify.Size = new System.Drawing.Size(180, 34);
            this.otpverify.TabIndex = 4;
            this.otpverify.Text = "verify OTP";
            this.otpverify.Click += new System.EventHandler(this.otpverify_Click);
            // 
            // otpreader
            // 
            this.otpreader.AutoRoundedCorners = true;
            this.otpreader.BackColor = System.Drawing.Color.White;
            this.otpreader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(181)))), ((int)(((byte)(114)))));
            this.otpreader.BorderRadius = 19;
            this.otpreader.BorderThickness = 2;
            this.otpreader.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.otpreader.DefaultText = "";
            this.otpreader.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.otpreader.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.otpreader.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.otpreader.DisabledState.Parent = this.otpreader;
            this.otpreader.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.otpreader.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.otpreader.FocusedState.Parent = this.otpreader;
            this.otpreader.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpreader.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.otpreader.HoverState.Parent = this.otpreader;
            this.otpreader.Location = new System.Drawing.Point(30, 42);
            this.otpreader.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.otpreader.Name = "otpreader";
            this.otpreader.PasswordChar = '\0';
            this.otpreader.PlaceholderText = "enter OTP";
            this.otpreader.SelectedText = "";
            this.otpreader.ShadowDecoration.Parent = this.otpreader;
            this.otpreader.Size = new System.Drawing.Size(325, 40);
            this.otpreader.TabIndex = 3;
            this.otpreader.TextChanged += new System.EventHandler(this.otpreader_TextChanged);
            // 
            // otpsent
            // 
            this.otpsent.AutoSize = true;
            this.otpsent.BackColor = System.Drawing.Color.White;
            this.otpsent.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpsent.Location = new System.Drawing.Point(113, 15);
            this.otpsent.Name = "otpsent";
            this.otpsent.Size = new System.Drawing.Size(62, 21);
            this.otpsent.TabIndex = 0;
            this.otpsent.Text = "label2";
            // 
            // usermess
            // 
            this.usermess.AutoSize = true;
            this.usermess.BackColor = System.Drawing.Color.White;
            this.usermess.ForeColor = System.Drawing.Color.Maroon;
            this.usermess.Location = new System.Drawing.Point(389, 188);
            this.usermess.Name = "usermess";
            this.usermess.Size = new System.Drawing.Size(0, 17);
            this.usermess.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hike.Properties.Resources._2778424;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1185, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // forgotpass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1184, 753);
            this.Controls.Add(this.usermess);
            this.Controls.Add(this.fgtsend);
            this.Controls.Add(this.fgtusername);
            this.Controls.Add(this.fgtmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.otpvalid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "forgotpass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forgotpass";
            this.Load += new System.EventHandler(this.forgotpass_Load);
            this.otpvalid.ResumeLayout(false);
            this.otpvalid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox fgtmail;
        private Guna.UI2.WinForms.Guna2TextBox fgtusername;
        private System.Windows.Forms.Panel otpvalid;
        private Guna.UI2.WinForms.Guna2TextBox otpreader;
        private Guna.UI2.WinForms.Guna2Button fgtsend;
        private Guna.UI2.WinForms.Guna2Button otpverify;
        private System.Windows.Forms.Label otpsent;
        private System.Windows.Forms.Label usermess;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}