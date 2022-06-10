namespace hike
{
    partial class alltrips
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.package = new hike.package();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userregDataSet1 = new hike.userregDataSet1();
            this.packageTableAdapter = new hike.userregDataSet1TableAdapters.PackageTableAdapter();
            this.packageTableAdapter1 = new hike.packageTableAdapters.PackageTableAdapter();
            this.ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.Source = new Guna.UI2.WinForms.Guna2TextBox();
            this.Destination = new Guna.UI2.WinForms.Guna2TextBox();
            this.ddate = new Guna.UI2.WinForms.Guna2TextBox();
            this.days = new Guna.UI2.WinForms.Guna2TextBox();
            this.Seatsaval = new Guna.UI2.WinForms.Guna2TextBox();
            this.bookingid = new Guna.UI2.WinForms.Guna2TextBox();
            this.name = new Guna.UI2.WinForms.Guna2TextBox();
            this.numberofpeople = new Guna.UI2.WinForms.Guna2TextBox();
            this.phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.total = new Guna.UI2.WinForms.Guna2TextBox();
            this.confirm = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.amt = new System.Windows.Forms.Label();
            this.nonamt = new Guna.UI2.WinForms.Guna2TextBox();
            this.sss = new Guna.UI2.WinForms.Guna2TextBox();
            this.Searchbox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.package)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userregDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView1.ColumnHeadersHeight = 29;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.daysDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.seatsDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.packageBindingSource1;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(26, 63);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.ShowEditingIcon = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1091, 186);
            this.guna2DataGridView1.TabIndex = 2;
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
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 29;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // daysDataGridViewTextBoxColumn
            // 
            this.daysDataGridViewTextBoxColumn.DataPropertyName = "Days";
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.daysDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.daysDataGridViewTextBoxColumn.HeaderText = "Days";
            this.daysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.daysDataGridViewTextBoxColumn.Name = "daysDataGridViewTextBoxColumn";
            this.daysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle10.Format = "d";
            dataGridViewCellStyle10.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle11.Format = "C0";
            dataGridViewCellStyle11.NullValue = null;
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seatsDataGridViewTextBoxColumn
            // 
            this.seatsDataGridViewTextBoxColumn.DataPropertyName = "Seats";
            this.seatsDataGridViewTextBoxColumn.HeaderText = "Seats";
            this.seatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seatsDataGridViewTextBoxColumn.Name = "seatsDataGridViewTextBoxColumn";
            this.seatsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packageBindingSource1
            // 
            this.packageBindingSource1.DataMember = "Package";
            this.packageBindingSource1.DataSource = this.package;
            // 
            // package
            // 
            this.package.DataSetName = "package";
            this.package.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataMember = "Package";
            this.packageBindingSource.DataSource = this.userregDataSet1;
            // 
            // userregDataSet1
            // 
            this.userregDataSet1.DataSetName = "userregDataSet1";
            this.userregDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packageTableAdapter
            // 
            this.packageTableAdapter.ClearBeforeFill = true;
            // 
            // packageTableAdapter1
            // 
            this.packageTableAdapter1.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ID.AutoRoundedCorners = true;
            this.ID.BorderRadius = 21;
            this.ID.BorderThickness = 2;
            this.ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID.DefaultText = "";
            this.ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ID.DisabledState.Parent = this.ID;
            this.ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ID.FocusedState.Parent = this.ID;
            this.ID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ID.HoverState.Parent = this.ID;
            this.ID.Location = new System.Drawing.Point(166, 295);
            this.ID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ID.Name = "ID";
            this.ID.PasswordChar = '\0';
            this.ID.PlaceholderText = " ";
            this.ID.ReadOnly = true;
            this.ID.SelectedText = "";
            this.ID.ShadowDecoration.Parent = this.ID;
            this.ID.Size = new System.Drawing.Size(358, 44);
            this.ID.TabIndex = 4;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // Source
            // 
            this.Source.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Source.AutoRoundedCorners = true;
            this.Source.BorderRadius = 21;
            this.Source.BorderThickness = 2;
            this.Source.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Source.DefaultText = "";
            this.Source.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Source.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Source.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Source.DisabledState.Parent = this.Source;
            this.Source.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Source.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Source.FocusedState.Parent = this.Source;
            this.Source.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Source.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Source.HoverState.Parent = this.Source;
            this.Source.Location = new System.Drawing.Point(166, 355);
            this.Source.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Source.Name = "Source";
            this.Source.PasswordChar = '\0';
            this.Source.PlaceholderText = " ";
            this.Source.ReadOnly = true;
            this.Source.SelectedText = "";
            this.Source.ShadowDecoration.Parent = this.Source;
            this.Source.Size = new System.Drawing.Size(358, 44);
            this.Source.TabIndex = 4;
            this.Source.TextChanged += new System.EventHandler(this.Source_TextChanged);
            // 
            // Destination
            // 
            this.Destination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Destination.AutoRoundedCorners = true;
            this.Destination.BorderRadius = 21;
            this.Destination.BorderThickness = 2;
            this.Destination.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Destination.DefaultText = "";
            this.Destination.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Destination.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Destination.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Destination.DisabledState.Parent = this.Destination;
            this.Destination.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Destination.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Destination.FocusedState.Parent = this.Destination;
            this.Destination.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Destination.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Destination.HoverState.Parent = this.Destination;
            this.Destination.Location = new System.Drawing.Point(166, 425);
            this.Destination.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Destination.Name = "Destination";
            this.Destination.PasswordChar = '\0';
            this.Destination.PlaceholderText = " ";
            this.Destination.ReadOnly = true;
            this.Destination.SelectedText = "";
            this.Destination.ShadowDecoration.Parent = this.Destination;
            this.Destination.Size = new System.Drawing.Size(358, 44);
            this.Destination.TabIndex = 4;
            // 
            // ddate
            // 
            this.ddate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ddate.AutoRoundedCorners = true;
            this.ddate.BorderRadius = 21;
            this.ddate.BorderThickness = 2;
            this.ddate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ddate.DefaultText = "";
            this.ddate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ddate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ddate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ddate.DisabledState.Parent = this.ddate;
            this.ddate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ddate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ddate.FocusedState.Parent = this.ddate;
            this.ddate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ddate.HoverState.Parent = this.ddate;
            this.ddate.Location = new System.Drawing.Point(166, 494);
            this.ddate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ddate.Name = "ddate";
            this.ddate.PasswordChar = '\0';
            this.ddate.PlaceholderText = " ";
            this.ddate.ReadOnly = true;
            this.ddate.SelectedText = "";
            this.ddate.ShadowDecoration.Parent = this.ddate;
            this.ddate.Size = new System.Drawing.Size(358, 45);
            this.ddate.TabIndex = 4;
            this.ddate.TextChanged += new System.EventHandler(this.ddate_TextChanged);
            // 
            // days
            // 
            this.days.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.days.AutoRoundedCorners = true;
            this.days.BorderRadius = 21;
            this.days.BorderThickness = 2;
            this.days.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.days.DefaultText = "";
            this.days.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.days.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.days.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.days.DisabledState.Parent = this.days;
            this.days.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.days.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.days.FocusedState.Parent = this.days;
            this.days.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.days.HoverState.Parent = this.days;
            this.days.Location = new System.Drawing.Point(166, 560);
            this.days.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.days.Name = "days";
            this.days.PasswordChar = '\0';
            this.days.PlaceholderText = " ";
            this.days.ReadOnly = true;
            this.days.SelectedText = "";
            this.days.ShadowDecoration.Parent = this.days;
            this.days.Size = new System.Drawing.Size(358, 44);
            this.days.TabIndex = 4;
            // 
            // Seatsaval
            // 
            this.Seatsaval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Seatsaval.AutoRoundedCorners = true;
            this.Seatsaval.BorderRadius = 21;
            this.Seatsaval.BorderThickness = 2;
            this.Seatsaval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Seatsaval.DefaultText = "";
            this.Seatsaval.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Seatsaval.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Seatsaval.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Seatsaval.DisabledState.Parent = this.Seatsaval;
            this.Seatsaval.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Seatsaval.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Seatsaval.FocusedState.Parent = this.Seatsaval;
            this.Seatsaval.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seatsaval.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Seatsaval.HoverState.Parent = this.Seatsaval;
            this.Seatsaval.Location = new System.Drawing.Point(166, 626);
            this.Seatsaval.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Seatsaval.Name = "Seatsaval";
            this.Seatsaval.PasswordChar = '\0';
            this.Seatsaval.PlaceholderText = " ";
            this.Seatsaval.ReadOnly = true;
            this.Seatsaval.SelectedText = "";
            this.Seatsaval.ShadowDecoration.Parent = this.Seatsaval;
            this.Seatsaval.Size = new System.Drawing.Size(358, 44);
            this.Seatsaval.TabIndex = 4;
            this.Seatsaval.TextChanged += new System.EventHandler(this.Seatsaval_TextChanged);
            // 
            // bookingid
            // 
            this.bookingid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bookingid.AutoRoundedCorners = true;
            this.bookingid.BorderRadius = 21;
            this.bookingid.BorderThickness = 2;
            this.bookingid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookingid.DefaultText = "";
            this.bookingid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bookingid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bookingid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookingid.DisabledState.Parent = this.bookingid;
            this.bookingid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookingid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookingid.FocusedState.Parent = this.bookingid;
            this.bookingid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookingid.HoverState.Parent = this.bookingid;
            this.bookingid.Location = new System.Drawing.Point(535, 319);
            this.bookingid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bookingid.Name = "bookingid";
            this.bookingid.PasswordChar = '\0';
            this.bookingid.PlaceholderText = "Booking id";
            this.bookingid.ReadOnly = true;
            this.bookingid.SelectedText = "";
            this.bookingid.ShadowDecoration.Parent = this.bookingid;
            this.bookingid.Size = new System.Drawing.Size(326, 44);
            this.bookingid.TabIndex = 4;
            this.bookingid.TextChanged += new System.EventHandler(this.bookingid_TextChanged);
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.name.AutoRoundedCorners = true;
            this.name.BorderRadius = 21;
            this.name.BorderThickness = 2;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.DefaultText = "";
            this.name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.DisabledState.Parent = this.name;
            this.name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.FocusedState.Parent = this.name;
            this.name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.HoverState.Parent = this.name;
            this.name.Location = new System.Drawing.Point(534, 461);
            this.name.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.PlaceholderText = "Name";
            this.name.SelectedText = "";
            this.name.ShadowDecoration.Parent = this.name;
            this.name.Size = new System.Drawing.Size(326, 44);
            this.name.TabIndex = 4;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // numberofpeople
            // 
            this.numberofpeople.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numberofpeople.AutoRoundedCorners = true;
            this.numberofpeople.BorderRadius = 21;
            this.numberofpeople.BorderThickness = 2;
            this.numberofpeople.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numberofpeople.DefaultText = "";
            this.numberofpeople.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numberofpeople.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numberofpeople.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numberofpeople.DisabledState.Parent = this.numberofpeople;
            this.numberofpeople.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numberofpeople.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numberofpeople.FocusedState.Parent = this.numberofpeople;
            this.numberofpeople.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberofpeople.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numberofpeople.HoverState.Parent = this.numberofpeople;
            this.numberofpeople.Location = new System.Drawing.Point(535, 388);
            this.numberofpeople.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.numberofpeople.Name = "numberofpeople";
            this.numberofpeople.PasswordChar = '\0';
            this.numberofpeople.PlaceholderText = "people";
            this.numberofpeople.SelectedText = "";
            this.numberofpeople.ShadowDecoration.Parent = this.numberofpeople;
            this.numberofpeople.Size = new System.Drawing.Size(326, 44);
            this.numberofpeople.TabIndex = 4;
            this.numberofpeople.TextChanged += new System.EventHandler(this.numberofpeople_TextChanged);
            // 
            // phone
            // 
            this.phone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.phone.AutoRoundedCorners = true;
            this.phone.BorderRadius = 21;
            this.phone.BorderThickness = 2;
            this.phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone.DefaultText = "";
            this.phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone.DisabledState.Parent = this.phone;
            this.phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone.FocusedState.Parent = this.phone;
            this.phone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone.HoverState.Parent = this.phone;
            this.phone.Location = new System.Drawing.Point(535, 525);
            this.phone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.phone.Name = "phone";
            this.phone.PasswordChar = '\0';
            this.phone.PlaceholderText = "mail address";
            this.phone.SelectedText = "";
            this.phone.ShadowDecoration.Parent = this.phone;
            this.phone.Size = new System.Drawing.Size(325, 44);
            this.phone.TabIndex = 4;
            // 
            // total
            // 
            this.total.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.total.AutoRoundedCorners = true;
            this.total.BorderRadius = 21;
            this.total.BorderThickness = 2;
            this.total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.total.DefaultText = "";
            this.total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.total.DisabledState.Parent = this.total;
            this.total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.total.FocusedState.Parent = this.total;
            this.total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.total.HoverState.Parent = this.total;
            this.total.Location = new System.Drawing.Point(534, 591);
            this.total.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.total.Name = "total";
            this.total.PasswordChar = '\0';
            this.total.PlaceholderText = "total amt";
            this.total.ReadOnly = true;
            this.total.SelectedText = "";
            this.total.ShadowDecoration.Parent = this.total;
            this.total.Size = new System.Drawing.Size(325, 44);
            this.total.TabIndex = 4;
            // 
            // confirm
            // 
            this.confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm.AutoRoundedCorners = true;
            this.confirm.BorderRadius = 21;
            this.confirm.CheckedState.Parent = this.confirm;
            this.confirm.CustomImages.Parent = this.confirm;
            this.confirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.confirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirm.ForeColor = System.Drawing.Color.White;
            this.confirm.HoverState.Parent = this.confirm;
            this.confirm.Location = new System.Drawing.Point(903, 460);
            this.confirm.Name = "confirm";
            this.confirm.ShadowDecoration.Parent = this.confirm;
            this.confirm.Size = new System.Drawing.Size(190, 45);
            this.confirm.TabIndex = 5;
            this.confirm.Text = "Confirm Booking";
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(205)))), ((int)(((byte)(231)))));
            this.label1.Location = new System.Drawing.Point(31, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Source Place";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(205)))), ((int)(((byte)(231)))));
            this.label2.Location = new System.Drawing.Point(31, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Package ID";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(205)))), ((int)(((byte)(231)))));
            this.label3.Location = new System.Drawing.Point(31, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Destination";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(205)))), ((int)(((byte)(231)))));
            this.label4.Location = new System.Drawing.Point(55, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(205)))), ((int)(((byte)(231)))));
            this.label5.Location = new System.Drawing.Point(34, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "No\'s of Days";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(205)))), ((int)(((byte)(231)))));
            this.label6.Location = new System.Drawing.Point(13, 626);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Seats Availabel";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // amt
            // 
            this.amt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.amt.AutoSize = true;
            this.amt.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(205)))), ((int)(((byte)(231)))));
            this.amt.Location = new System.Drawing.Point(549, 640);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(160, 20);
            this.amt.TabIndex = 6;
            this.amt.Text = "Amount per seat";
            this.amt.Click += new System.EventHandler(this.label1_Click);
            // 
            // nonamt
            // 
            this.nonamt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nonamt.AutoRoundedCorners = true;
            this.nonamt.BorderRadius = 21;
            this.nonamt.BorderThickness = 2;
            this.nonamt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nonamt.DefaultText = "";
            this.nonamt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nonamt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nonamt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nonamt.DisabledState.Parent = this.nonamt;
            this.nonamt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nonamt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nonamt.FocusedState.Parent = this.nonamt;
            this.nonamt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonamt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nonamt.HoverState.Parent = this.nonamt;
            this.nonamt.Location = new System.Drawing.Point(768, 640);
            this.nonamt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.nonamt.Name = "nonamt";
            this.nonamt.PasswordChar = '\0';
            this.nonamt.PlaceholderText = "total amt";
            this.nonamt.ReadOnly = true;
            this.nonamt.SelectedText = "";
            this.nonamt.ShadowDecoration.Parent = this.nonamt;
            this.nonamt.Size = new System.Drawing.Size(325, 44);
            this.nonamt.TabIndex = 4;
            this.nonamt.Visible = false;
            // 
            // sss
            // 
            this.sss.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sss.AutoRoundedCorners = true;
            this.sss.BorderRadius = 21;
            this.sss.BorderThickness = 2;
            this.sss.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sss.DefaultText = "";
            this.sss.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sss.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sss.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sss.DisabledState.Parent = this.sss;
            this.sss.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sss.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sss.FocusedState.Parent = this.sss;
            this.sss.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sss.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sss.HoverState.Parent = this.sss;
            this.sss.Location = new System.Drawing.Point(871, 586);
            this.sss.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.sss.Name = "sss";
            this.sss.PasswordChar = '\0';
            this.sss.PlaceholderText = "Name";
            this.sss.SelectedText = "";
            this.sss.ShadowDecoration.Parent = this.sss;
            this.sss.Size = new System.Drawing.Size(186, 44);
            this.sss.TabIndex = 4;
            this.sss.Visible = false;
            this.sss.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // Searchbox
            // 
            this.Searchbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Searchbox.Animated = true;
            this.Searchbox.AutoRoundedCorners = true;
            this.Searchbox.BorderRadius = 21;
            this.Searchbox.BorderThickness = 2;
            this.Searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchbox.DefaultText = "";
            this.Searchbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Searchbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Searchbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchbox.DisabledState.Parent = this.Searchbox;
            this.Searchbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchbox.FocusedState.Parent = this.Searchbox;
            this.Searchbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchbox.HoverState.Parent = this.Searchbox;
            this.Searchbox.IconLeft = global::hike.Properties.Resources.search_64px;
            this.Searchbox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.Searchbox.Location = new System.Drawing.Point(264, 12);
            this.Searchbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.PasswordChar = '\0';
            this.Searchbox.PlaceholderText = "Search for Destination";
            this.Searchbox.SelectedText = "";
            this.Searchbox.ShadowDecoration.Parent = this.Searchbox;
            this.Searchbox.Size = new System.Drawing.Size(618, 44);
            this.Searchbox.TabIndex = 3;
            this.Searchbox.TextChanged += new System.EventHandler(this.Searchbox_TextChanged);
            // 
            // alltrips
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.Seatsaval);
            this.Controls.Add(this.ddate);
            this.Controls.Add(this.days);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.Source);
            this.Controls.Add(this.nonamt);
            this.Controls.Add(this.total);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.numberofpeople);
            this.Controls.Add(this.sss);
            this.Controls.Add(this.name);
            this.Controls.Add(this.bookingid);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Searchbox);
            this.Controls.Add(this.guna2DataGridView1);
            this.Name = "alltrips";
            this.Size = new System.Drawing.Size(1148, 689);
            this.Load += new System.EventHandler(this.alltrips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.package)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userregDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource packageBindingSource;
        private userregDataSet1 userregDataSet1;
        private userregDataSet1TableAdapters.PackageTableAdapter packageTableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox Searchbox;
        public Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.BindingSource packageBindingSource1;
        private package package;
        private packageTableAdapters.PackageTableAdapter packageTableAdapter1;
        private Guna.UI2.WinForms.Guna2TextBox ID;
        private Guna.UI2.WinForms.Guna2TextBox Source;
        private Guna.UI2.WinForms.Guna2TextBox Destination;
        private Guna.UI2.WinForms.Guna2TextBox days;
        private Guna.UI2.WinForms.Guna2TextBox Seatsaval;
        private Guna.UI2.WinForms.Guna2TextBox bookingid;
        private Guna.UI2.WinForms.Guna2TextBox name;
        private Guna.UI2.WinForms.Guna2TextBox numberofpeople;
        private Guna.UI2.WinForms.Guna2TextBox phone;
        private Guna.UI2.WinForms.Guna2TextBox total;
        private Guna.UI2.WinForms.Guna2Button confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label amt;
        private Guna.UI2.WinForms.Guna2TextBox ddate;
        private Guna.UI2.WinForms.Guna2TextBox nonamt;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatsDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2TextBox sss;
    }
}
