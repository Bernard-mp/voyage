namespace hike
{
    partial class registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Regemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Regusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Regpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Regname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Regsignup = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Regsignin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = null;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(-5, -5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(1257, 783);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.label1.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(271, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign Up";
            // 
            // Regemail
            // 
            this.Regemail.Animated = true;
            this.Regemail.AutoRoundedCorners = true;
            this.Regemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.Regemail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.Regemail.BorderRadius = 24;
            this.Regemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Regemail.DefaultText = "";
            this.Regemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Regemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Regemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Regemail.DisabledState.Parent = this.Regemail;
            this.Regemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Regemail.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Regemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Regemail.FocusedState.Parent = this.Regemail;
            this.Regemail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Regemail.HoverState.Parent = this.Regemail;
            this.Regemail.Location = new System.Drawing.Point(59, 218);
            this.Regemail.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Regemail.Name = "Regemail";
            this.Regemail.PasswordChar = '\0';
            this.Regemail.PlaceholderText = "   enter email address";
            this.Regemail.SelectedText = "";
            this.Regemail.ShadowDecoration.Parent = this.Regemail;
            this.Regemail.Size = new System.Drawing.Size(472, 50);
            this.Regemail.TabIndex = 2;
            this.Regemail.TextChanged += new System.EventHandler(this.Regemail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // Regusername
            // 
            this.Regusername.Animated = true;
            this.Regusername.AutoRoundedCorners = true;
            this.Regusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.Regusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.Regusername.BorderRadius = 24;
            this.Regusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Regusername.DefaultText = "";
            this.Regusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Regusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Regusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Regusername.DisabledState.Parent = this.Regusername;
            this.Regusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Regusername.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Regusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Regusername.FocusedState.Parent = this.Regusername;
            this.Regusername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Regusername.HoverState.Parent = this.Regusername;
            this.Regusername.Location = new System.Drawing.Point(59, 327);
            this.Regusername.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Regusername.Name = "Regusername";
            this.Regusername.PasswordChar = '\0';
            this.Regusername.PlaceholderText = "   enter Username";
            this.Regusername.SelectedText = "";
            this.Regusername.ShadowDecoration.Parent = this.Regusername;
            this.Regusername.Size = new System.Drawing.Size(472, 50);
            this.Regusername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // Regpass
            // 
            this.Regpass.Animated = true;
            this.Regpass.AutoRoundedCorners = true;
            this.Regpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.Regpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.Regpass.BorderRadius = 24;
            this.Regpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Regpass.DefaultText = "";
            this.Regpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Regpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Regpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Regpass.DisabledState.Parent = this.Regpass;
            this.Regpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Regpass.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Regpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Regpass.FocusedState.Parent = this.Regpass;
            this.Regpass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Regpass.HoverState.Parent = this.Regpass;
            this.Regpass.Location = new System.Drawing.Point(59, 434);
            this.Regpass.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Regpass.Name = "Regpass";
            this.Regpass.PasswordChar = '\0';
            this.Regpass.PlaceholderText = "   enter Password";
            this.Regpass.SelectedText = "";
            this.Regpass.ShadowDecoration.Parent = this.Regpass;
            this.Regpass.Size = new System.Drawing.Size(472, 50);
            this.Regpass.TabIndex = 2;
            this.Regpass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // Regname
            // 
            this.Regname.Animated = true;
            this.Regname.AutoRoundedCorners = true;
            this.Regname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.Regname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.Regname.BorderRadius = 24;
            this.Regname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Regname.DefaultText = "";
            this.Regname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Regname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Regname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Regname.DisabledState.Parent = this.Regname;
            this.Regname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Regname.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Regname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Regname.FocusedState.Parent = this.Regname;
            this.Regname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Regname.HoverState.Parent = this.Regname;
            this.Regname.Location = new System.Drawing.Point(59, 122);
            this.Regname.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Regname.Name = "Regname";
            this.Regname.PasswordChar = '\0';
            this.Regname.PlaceholderText = "   enter your name";
            this.Regname.SelectedText = "";
            this.Regname.ShadowDecoration.Parent = this.Regname;
            this.Regname.Size = new System.Drawing.Size(472, 50);
            this.Regname.TabIndex = 2;
            this.Regname.TextChanged += new System.EventHandler(this.Regrpass_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // Regsignup
            // 
            this.Regsignup.AutoRoundedCorners = true;
            this.Regsignup.BorderRadius = 21;
            this.Regsignup.CheckedState.Parent = this.Regsignup;
            this.Regsignup.CustomImages.Parent = this.Regsignup;
            this.Regsignup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(194)))), ((int)(((byte)(147)))));
            this.Regsignup.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.Regsignup.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regsignup.ForeColor = System.Drawing.Color.White;
            this.Regsignup.HoverState.Parent = this.Regsignup;
            this.Regsignup.Location = new System.Drawing.Point(161, 510);
            this.Regsignup.Name = "Regsignup";
            this.Regsignup.ShadowDecoration.Parent = this.Regsignup;
            this.Regsignup.Size = new System.Drawing.Size(233, 45);
            this.Regsignup.TabIndex = 4;
            this.Regsignup.Text = "Sign Up";
            this.Regsignup.Click += new System.EventHandler(this.Regsignup_Click);
            // 
            // Regsignin
            // 
            this.Regsignin.AutoRoundedCorners = true;
            this.Regsignin.BorderRadius = 15;
            this.Regsignin.CheckedState.Parent = this.Regsignin;
            this.Regsignin.CustomImages.Parent = this.Regsignin;
            this.Regsignin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.Regsignin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(147)))), ((int)(((byte)(203)))));
            this.Regsignin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Regsignin.ForeColor = System.Drawing.Color.White;
            this.Regsignin.HoverState.Parent = this.Regsignin;
            this.Regsignin.Location = new System.Drawing.Point(315, 708);
            this.Regsignin.Name = "Regsignin";
            this.Regsignin.ShadowDecoration.Parent = this.Regsignin;
            this.Regsignin.Size = new System.Drawing.Size(104, 33);
            this.Regsignin.TabIndex = 5;
            this.Regsignin.Text = "Sign In";
            this.Regsignin.Click += new System.EventHandler(this.Regsignin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(131)))), ((int)(((byte)(194)))));
            this.label6.Location = new System.Drawing.Point(195, 671);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Have An Account Then Sign In";
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 753);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Regsignin);
            this.Controls.Add(this.Regsignup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Regname);
            this.Controls.Add(this.Regpass);
            this.Controls.Add(this.Regusername);
            this.Controls.Add(this.Regemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Regemail;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton Regsignup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox Regname;
        private Guna.UI2.WinForms.Guna2TextBox Regpass;
        private Guna.UI2.WinForms.Guna2TextBox Regusername;
        private Guna.UI2.WinForms.Guna2GradientButton Regsignin;
        private System.Windows.Forms.Label label6;
    }
}