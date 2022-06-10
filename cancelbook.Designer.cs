namespace hike
{
    partial class cancelbook
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cancelsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bookingidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peoplesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userregDataSet5 = new hike.userregDataSet5();
            this.bookingsTableAdapter = new hike.userregDataSet5TableAdapters.BookingsTableAdapter();
            this.Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.cancelid = new Guna.UI2.WinForms.Guna2TextBox();
            this.package = new System.Windows.Forms.TextBox();
            this.cancelseats = new System.Windows.Forms.TextBox();
            this.dtabaseseat = new System.Windows.Forms.TextBox();
            this.finalseats = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userregDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelsearch
            // 
            this.cancelsearch.Animated = true;
            this.cancelsearch.AutoRoundedCorners = true;
            this.cancelsearch.BorderRadius = 21;
            this.cancelsearch.BorderThickness = 2;
            this.cancelsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cancelsearch.DefaultText = "";
            this.cancelsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cancelsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cancelsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cancelsearch.DisabledState.Parent = this.cancelsearch;
            this.cancelsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cancelsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cancelsearch.FocusedState.Parent = this.cancelsearch;
            this.cancelsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cancelsearch.HoverState.Parent = this.cancelsearch;
            this.cancelsearch.IconLeft = global::hike.Properties.Resources.search_64px;
            this.cancelsearch.IconLeftSize = new System.Drawing.Size(30, 30);
            this.cancelsearch.Location = new System.Drawing.Point(30, 43);
            this.cancelsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelsearch.Name = "cancelsearch";
            this.cancelsearch.PasswordChar = '\0';
            this.cancelsearch.PlaceholderText = "Search for Booking ID";
            this.cancelsearch.SelectedText = "";
            this.cancelsearch.ShadowDecoration.Parent = this.cancelsearch;
            this.cancelsearch.Size = new System.Drawing.Size(543, 44);
            this.cancelsearch.TabIndex = 4;
            this.cancelsearch.TextChanged += new System.EventHandler(this.cancelsearch_TextChanged);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 27;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingidDataGridViewTextBoxColumn,
            this.packageidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.peoplesDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.tamtDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.daysDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.bookingsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(19, 114);
            this.guna2DataGridView1.MultiSelect = false;
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.ShowEditingIcon = false;
            this.guna2DataGridView1.ShowRowErrors = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1110, 148);
            this.guna2DataGridView1.TabIndex = 5;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 27;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.Visible = false;
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // bookingidDataGridViewTextBoxColumn
            // 
            this.bookingidDataGridViewTextBoxColumn.DataPropertyName = "bookingid";
            this.bookingidDataGridViewTextBoxColumn.HeaderText = "bookingid";
            this.bookingidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingidDataGridViewTextBoxColumn.Name = "bookingidDataGridViewTextBoxColumn";
            this.bookingidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packageidDataGridViewTextBoxColumn
            // 
            this.packageidDataGridViewTextBoxColumn.DataPropertyName = "packageid";
            this.packageidDataGridViewTextBoxColumn.HeaderText = "packageid";
            this.packageidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.packageidDataGridViewTextBoxColumn.Name = "packageidDataGridViewTextBoxColumn";
            this.packageidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peoplesDataGridViewTextBoxColumn
            // 
            this.peoplesDataGridViewTextBoxColumn.DataPropertyName = "peoples";
            this.peoplesDataGridViewTextBoxColumn.HeaderText = "No\'s of peoples";
            this.peoplesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peoplesDataGridViewTextBoxColumn.Name = "peoplesDataGridViewTextBoxColumn";
            this.peoplesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tamtDataGridViewTextBoxColumn
            // 
            this.tamtDataGridViewTextBoxColumn.DataPropertyName = "Tamt";
            this.tamtDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.tamtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tamtDataGridViewTextBoxColumn.Name = "tamtDataGridViewTextBoxColumn";
            this.tamtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // daysDataGridViewTextBoxColumn
            // 
            this.daysDataGridViewTextBoxColumn.DataPropertyName = "days";
            this.daysDataGridViewTextBoxColumn.HeaderText = "Days";
            this.daysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.daysDataGridViewTextBoxColumn.Name = "daysDataGridViewTextBoxColumn";
            this.daysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.userregDataSet5;
            // 
            // userregDataSet5
            // 
            this.userregDataSet5.DataSetName = "userregDataSet5";
            this.userregDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingsTableAdapter
            // 
            this.bookingsTableAdapter.ClearBeforeFill = true;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.AutoRoundedCorners = true;
            this.Cancel.BorderRadius = 21;
            this.Cancel.CheckedState.Parent = this.Cancel;
            this.Cancel.CustomImages.Parent = this.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.HoverState.Parent = this.Cancel;
            this.Cancel.Location = new System.Drawing.Point(919, 43);
            this.Cancel.Name = "Cancel";
            this.Cancel.ShadowDecoration.Parent = this.Cancel;
            this.Cancel.Size = new System.Drawing.Size(180, 45);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.Visible = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // cancelid
            // 
            this.cancelid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cancelid.DefaultText = "";
            this.cancelid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cancelid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cancelid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cancelid.DisabledState.Parent = this.cancelid;
            this.cancelid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cancelid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cancelid.FocusedState.Parent = this.cancelid;
            this.cancelid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cancelid.HoverState.Parent = this.cancelid;
            this.cancelid.Location = new System.Drawing.Point(447, 350);
            this.cancelid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelid.Name = "cancelid";
            this.cancelid.PasswordChar = '\0';
            this.cancelid.PlaceholderText = "";
            this.cancelid.SelectedText = "";
            this.cancelid.ShadowDecoration.Parent = this.cancelid;
            this.cancelid.Size = new System.Drawing.Size(267, 44);
            this.cancelid.TabIndex = 7;
            this.cancelid.Visible = false;
            // 
            // package
            // 
            this.package.Location = new System.Drawing.Point(156, 513);
            this.package.Name = "package";
            this.package.Size = new System.Drawing.Size(100, 22);
            this.package.TabIndex = 8;
            this.package.Visible = false;
            // 
            // cancelseats
            // 
            this.cancelseats.Location = new System.Drawing.Point(304, 513);
            this.cancelseats.Name = "cancelseats";
            this.cancelseats.Size = new System.Drawing.Size(100, 22);
            this.cancelseats.TabIndex = 8;
            this.cancelseats.Visible = false;
            // 
            // dtabaseseat
            // 
            this.dtabaseseat.Location = new System.Drawing.Point(456, 513);
            this.dtabaseseat.Name = "dtabaseseat";
            this.dtabaseseat.Size = new System.Drawing.Size(100, 22);
            this.dtabaseseat.TabIndex = 8;
            this.dtabaseseat.Visible = false;
            // 
            // finalseats
            // 
            this.finalseats.Location = new System.Drawing.Point(644, 513);
            this.finalseats.Name = "finalseats";
            this.finalseats.Size = new System.Drawing.Size(100, 22);
            this.finalseats.TabIndex = 9;
            this.finalseats.Visible = false;
            // 
            // cancelbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.finalseats);
            this.Controls.Add(this.dtabaseseat);
            this.Controls.Add(this.cancelseats);
            this.Controls.Add(this.package);
            this.Controls.Add(this.cancelid);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.cancelsearch);
            this.Name = "cancelbook";
            this.Size = new System.Drawing.Size(1148, 689);
            this.Load += new System.EventHandler(this.cancelbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userregDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox cancelsearch;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private userregDataSet5 userregDataSet5;
        private userregDataSet5TableAdapters.BookingsTableAdapter bookingsTableAdapter;
        private Guna.UI2.WinForms.Guna2Button Cancel;
        private Guna.UI2.WinForms.Guna2TextBox cancelid;
        private System.Windows.Forms.TextBox package;
        private System.Windows.Forms.TextBox cancelseats;
        private System.Windows.Forms.TextBox dtabaseseat;
        private System.Windows.Forms.TextBox finalseats;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peoplesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn;
    }
}
