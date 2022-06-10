namespace hike
{
    partial class change_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_password));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.fgtupdate = new Guna.UI2.WinForms.Guna2Button();
            this.fgtpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.fgtconfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.usertxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::hike.Properties.Resources._2778424;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-3, -9);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(1247, 753);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // fgtupdate
            // 
            this.fgtupdate.AutoRoundedCorners = true;
            this.fgtupdate.BorderRadius = 16;
            this.fgtupdate.CheckedState.Parent = this.fgtupdate;
            this.fgtupdate.CustomImages.Parent = this.fgtupdate;
            this.fgtupdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(255)))));
            this.fgtupdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fgtupdate.ForeColor = System.Drawing.Color.White;
            this.fgtupdate.HoverState.Parent = this.fgtupdate;
            this.fgtupdate.Location = new System.Drawing.Point(375, 404);
            this.fgtupdate.Name = "fgtupdate";
            this.fgtupdate.ShadowDecoration.Parent = this.fgtupdate;
            this.fgtupdate.Size = new System.Drawing.Size(147, 34);
            this.fgtupdate.TabIndex = 12;
            this.fgtupdate.Text = "update";
            this.fgtupdate.Click += new System.EventHandler(this.fgtupdate_Click);
            // 
            // fgtpass
            // 
            this.fgtpass.AutoRoundedCorners = true;
            this.fgtpass.BackColor = System.Drawing.Color.White;
            this.fgtpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(181)))), ((int)(((byte)(114)))));
            this.fgtpass.BorderRadius = 19;
            this.fgtpass.BorderThickness = 2;
            this.fgtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fgtpass.DefaultText = "";
            this.fgtpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fgtpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fgtpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fgtpass.DisabledState.Parent = this.fgtpass;
            this.fgtpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fgtpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fgtpass.FocusedState.Parent = this.fgtpass;
            this.fgtpass.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgtpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fgtpass.HoverState.Parent = this.fgtpass;
            this.fgtpass.Location = new System.Drawing.Point(361, 269);
            this.fgtpass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.fgtpass.Name = "fgtpass";
            this.fgtpass.PasswordChar = '\0';
            this.fgtpass.PlaceholderText = "enter Password";
            this.fgtpass.SelectedText = "";
            this.fgtpass.ShadowDecoration.Parent = this.fgtpass;
            this.fgtpass.Size = new System.Drawing.Size(450, 40);
            this.fgtpass.TabIndex = 10;
            this.fgtpass.UseSystemPasswordChar = true;
            this.fgtpass.TextChanged += new System.EventHandler(this.fgtpass_TextChanged);
            // 
            // fgtconfirm
            // 
            this.fgtconfirm.AutoRoundedCorners = true;
            this.fgtconfirm.BackColor = System.Drawing.Color.White;
            this.fgtconfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(181)))), ((int)(((byte)(114)))));
            this.fgtconfirm.BorderRadius = 19;
            this.fgtconfirm.BorderThickness = 2;
            this.fgtconfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fgtconfirm.DefaultText = "";
            this.fgtconfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fgtconfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fgtconfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fgtconfirm.DisabledState.Parent = this.fgtconfirm;
            this.fgtconfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fgtconfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fgtconfirm.FocusedState.Parent = this.fgtconfirm;
            this.fgtconfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgtconfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fgtconfirm.HoverState.Parent = this.fgtconfirm;
            this.fgtconfirm.Location = new System.Drawing.Point(361, 355);
            this.fgtconfirm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.fgtconfirm.Name = "fgtconfirm";
            this.fgtconfirm.PasswordChar = '\0';
            this.fgtconfirm.PlaceholderText = "confirm password";
            this.fgtconfirm.SelectedText = "";
            this.fgtconfirm.ShadowDecoration.Parent = this.fgtconfirm;
            this.fgtconfirm.Size = new System.Drawing.Size(450, 40);
            this.fgtconfirm.TabIndex = 11;
            this.fgtconfirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reset Password";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1192, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 7;
            // 
            // usertxt
            // 
            this.usertxt.AutoRoundedCorners = true;
            this.usertxt.BackColor = System.Drawing.Color.White;
            this.usertxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(181)))), ((int)(((byte)(114)))));
            this.usertxt.BorderRadius = 19;
            this.usertxt.BorderThickness = 2;
            this.usertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usertxt.DefaultText = "";
            this.usertxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usertxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usertxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usertxt.DisabledState.Parent = this.usertxt;
            this.usertxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usertxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usertxt.FocusedState.Parent = this.usertxt;
            this.usertxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.ForeColor = System.Drawing.Color.Black;
            this.usertxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usertxt.HoverState.Parent = this.usertxt;
            this.usertxt.Location = new System.Drawing.Point(361, 178);
            this.usertxt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.usertxt.Name = "usertxt";
            this.usertxt.PasswordChar = '\0';
            this.usertxt.PlaceholderText = "enter Password";
            this.usertxt.ReadOnly = true;
            this.usertxt.SelectedText = "";
            this.usertxt.ShadowDecoration.Parent = this.usertxt;
            this.usertxt.Size = new System.Drawing.Size(450, 40);
            this.usertxt.TabIndex = 10;
            this.usertxt.TextChanged += new System.EventHandler(this.fgtpass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "confirm password";
            // 
            // change_password
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1241, 753);
            this.Controls.Add(this.fgtupdate);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.fgtpass);
            this.Controls.Add(this.fgtconfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "change_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "change_password";
            this.Load += new System.EventHandler(this.change_password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button fgtupdate;
        private Guna.UI2.WinForms.Guna2TextBox fgtpass;
        private Guna.UI2.WinForms.Guna2TextBox fgtconfirm;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox usertxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}