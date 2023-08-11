namespace EmpAcc
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinButton = new System.Windows.Forms.Button();
            this.MaxButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MenuTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.EmpAccTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EmpDataGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.divisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empAccDBDataSet = new EmpAcc.EmpAccDBDataSet();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEmpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DivTab = new System.Windows.Forms.TabPage();
            this.DivDataGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.StatTab = new System.Windows.Forms.TabPage();
            this.EmpChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.employeesTableAdapter = new EmpAcc.EmpAccDBDataSetTableAdapters.EmployeesTableAdapter();
            this.divisionTableAdapter = new EmpAcc.EmpAccDBDataSetTableAdapters.DivisionTableAdapter();
            this.ChartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartViewTableAdapter = new EmpAcc.EmpAccDBDataSetTableAdapters.ChartViewTableAdapter();
            this.tableAdapterManager = new EmpAcc.EmpAccDBDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.EmpAccTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empAccDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.DivTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DivDataGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.StatTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.MinButton);
            this.panel1.Controls.Add(this.MaxButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanelDrag);
            // 
            // MinButton
            // 
            this.MinButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinButton.Image = global::EmpAcc.Properties.Resources.min;
            this.MinButton.Location = new System.Drawing.Point(843, 0);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(28, 30);
            this.MinButton.TabIndex = 2;
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // MaxButton
            // 
            this.MaxButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxButton.Image = global::EmpAcc.Properties.Resources.max;
            this.MaxButton.Location = new System.Drawing.Point(871, 0);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(28, 30);
            this.MaxButton.TabIndex = 1;
            this.MaxButton.UseVisualStyleBackColor = true;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.Image = global::EmpAcc.Properties.Resources.exit;
            this.ExitButton.Location = new System.Drawing.Point(899, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(28, 30);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.LightCyan;
            this.MenuPanel.Controls.Add(this.flowLayoutPanel1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 30);
            this.MenuPanel.MaximumSize = new System.Drawing.Size(200, 0);
            this.MenuPanel.MinimumSize = new System.Drawing.Size(36, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 485);
            this.MenuPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.MenuButton);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.DeleteButton);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(200, 0);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(44, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 485);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // MenuButton
            // 
            this.MenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuButton.Image = global::EmpAcc.Properties.Resources.menu;
            this.MenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuButton.Location = new System.Drawing.Point(3, 3);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(194, 33);
            this.MenuButton.TabIndex = 0;
            this.MenuButton.Text = "Меню";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Image = global::EmpAcc.Properties.Resources.add;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteButton.Image = global::EmpAcc.Properties.Resources.delete;
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(3, 81);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(194, 33);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Image = global::EmpAcc.Properties.Resources.deleteEmp;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Уволить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MenuTimer
            // 
            this.MenuTimer.Interval = 20;
            this.MenuTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 27);
            this.panel2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(592, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(592, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // EmpAccTabControl
            // 
            this.EmpAccTabControl.Controls.Add(this.tabPage1);
            this.EmpAccTabControl.Controls.Add(this.DivTab);
            this.EmpAccTabControl.Controls.Add(this.StatTab);
            this.EmpAccTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmpAccTabControl.Location = new System.Drawing.Point(200, 30);
            this.EmpAccTabControl.Name = "EmpAccTabControl";
            this.EmpAccTabControl.SelectedIndex = 0;
            this.EmpAccTabControl.Size = new System.Drawing.Size(727, 485);
            this.EmpAccTabControl.TabIndex = 3;
            this.EmpAccTabControl.SelectedIndexChanged += new System.EventHandler(this.EmpTab_SelectedIndexChanged);
            this.EmpAccTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.ChartSelected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EmpDataGrid);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(719, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сотрудники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // EmpDataGrid
            // 
            this.EmpDataGrid.AllowUserToAddRows = false;
            this.EmpDataGrid.AllowUserToDeleteRows = false;
            this.EmpDataGrid.AllowUserToResizeColumns = false;
            this.EmpDataGrid.AllowUserToResizeRows = false;
            this.EmpDataGrid.AutoGenerateColumns = false;
            this.EmpDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.tabNumberDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.divisionIDDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.dateEmpDataGridViewTextBoxColumn,
            this.dateDisDataGridViewTextBoxColumn});
            this.EmpDataGrid.DataSource = this.employeesBindingSource;
            this.EmpDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmpDataGrid.Location = new System.Drawing.Point(3, 30);
            this.EmpDataGrid.Name = "EmpDataGrid";
            this.EmpDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EmpDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpDataGrid.Size = new System.Drawing.Size(713, 426);
            this.EmpDataGrid.TabIndex = 3;
            this.EmpDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDataGrid_EditEnd);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "№";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // tabNumberDataGridViewTextBoxColumn
            // 
            this.tabNumberDataGridViewTextBoxColumn.DataPropertyName = "TabNumber";
            this.tabNumberDataGridViewTextBoxColumn.HeaderText = "Табельный номер";
            this.tabNumberDataGridViewTextBoxColumn.Name = "tabNumberDataGridViewTextBoxColumn";
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            this.postDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            // 
            // divisionIDDataGridViewTextBoxColumn
            // 
            this.divisionIDDataGridViewTextBoxColumn.DataPropertyName = "DivisionID";
            this.divisionIDDataGridViewTextBoxColumn.DataSource = this.divisionBindingSource;
            this.divisionIDDataGridViewTextBoxColumn.DisplayMember = "Title";
            this.divisionIDDataGridViewTextBoxColumn.HeaderText = "№ Подразделения";
            this.divisionIDDataGridViewTextBoxColumn.Name = "divisionIDDataGridViewTextBoxColumn";
            this.divisionIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.divisionIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.divisionIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // divisionBindingSource
            // 
            this.divisionBindingSource.DataMember = "Division";
            this.divisionBindingSource.DataSource = this.empAccDBDataSet;
            // 
            // empAccDBDataSet
            // 
            this.empAccDBDataSet.DataSetName = "EmpAccDBDataSet";
            this.empAccDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // dateEmpDataGridViewTextBoxColumn
            // 
            this.dateEmpDataGridViewTextBoxColumn.DataPropertyName = "DateEmp";
            this.dateEmpDataGridViewTextBoxColumn.HeaderText = "Дата устройства";
            this.dateEmpDataGridViewTextBoxColumn.Name = "dateEmpDataGridViewTextBoxColumn";
            // 
            // dateDisDataGridViewTextBoxColumn
            // 
            this.dateDisDataGridViewTextBoxColumn.DataPropertyName = "DateDis";
            this.dateDisDataGridViewTextBoxColumn.HeaderText = "Дата увольнения";
            this.dateDisDataGridViewTextBoxColumn.Name = "dateDisDataGridViewTextBoxColumn";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.empAccDBDataSet;
            // 
            // DivTab
            // 
            this.DivTab.Controls.Add(this.DivDataGrid);
            this.DivTab.Controls.Add(this.panel3);
            this.DivTab.Location = new System.Drawing.Point(4, 22);
            this.DivTab.Name = "DivTab";
            this.DivTab.Padding = new System.Windows.Forms.Padding(3);
            this.DivTab.Size = new System.Drawing.Size(719, 459);
            this.DivTab.TabIndex = 1;
            this.DivTab.Text = "Подразделения";
            this.DivTab.UseVisualStyleBackColor = true;
            // 
            // DivDataGrid
            // 
            this.DivDataGrid.AllowUserToAddRows = false;
            this.DivDataGrid.AllowUserToDeleteRows = false;
            this.DivDataGrid.AllowUserToResizeColumns = false;
            this.DivDataGrid.AllowUserToResizeRows = false;
            this.DivDataGrid.AutoGenerateColumns = false;
            this.DivDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DivDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DivDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn,
            this.parentDataGridViewTextBoxColumn});
            this.DivDataGrid.DataSource = this.divisionBindingSource;
            this.DivDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivDataGrid.Location = new System.Drawing.Point(3, 30);
            this.DivDataGrid.Name = "DivDataGrid";
            this.DivDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DivDataGrid.Size = new System.Drawing.Size(713, 426);
            this.DivDataGrid.TabIndex = 5;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "№";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // parentDataGridViewTextBoxColumn
            // 
            this.parentDataGridViewTextBoxColumn.DataPropertyName = "Parent";
            this.parentDataGridViewTextBoxColumn.DataSource = this.divisionBindingSource;
            this.parentDataGridViewTextBoxColumn.DisplayMember = "Title";
            this.parentDataGridViewTextBoxColumn.HeaderText = "Головной отдел";
            this.parentDataGridViewTextBoxColumn.Name = "parentDataGridViewTextBoxColumn";
            this.parentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.parentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.parentDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(713, 27);
            this.panel3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(592, 20);
            this.textBox2.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(592, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // StatTab
            // 
            this.StatTab.Controls.Add(this.EmpChart);
            this.StatTab.Location = new System.Drawing.Point(4, 22);
            this.StatTab.Name = "StatTab";
            this.StatTab.Size = new System.Drawing.Size(719, 459);
            this.StatTab.TabIndex = 2;
            this.StatTab.Text = "Статистика";
            this.StatTab.UseVisualStyleBackColor = true;
            // 
            // EmpChart
            // 
            chartArea1.Name = "ChartArea1";
            this.EmpChart.ChartAreas.Add(chartArea1);
            this.EmpChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.EmpChart.Legends.Add(legend1);
            this.EmpChart.Location = new System.Drawing.Point(0, 0);
            this.EmpChart.Name = "EmpChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Dis";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Emp";
            this.EmpChart.Series.Add(series1);
            this.EmpChart.Series.Add(series2);
            this.EmpChart.Size = new System.Drawing.Size(719, 459);
            this.EmpChart.TabIndex = 1;
            this.EmpChart.Text = "chart1";
            title1.Name = "Title";
            title1.Text = "Сотрудники/Уволенные";
            this.EmpChart.Titles.Add(title1);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // divisionTableAdapter
            // 
            this.divisionTableAdapter.ClearBeforeFill = true;
            // 
            // ChartBindingSource
            // 
            this.ChartBindingSource.DataMember = "Employees";
            this.ChartBindingSource.DataSource = this.empAccDBDataSet;
            // 
            // chartViewBindingSource
            // 
            this.chartViewBindingSource.DataMember = "ChartView";
            this.chartViewBindingSource.DataSource = this.empAccDBDataSet;
            // 
            // chartViewTableAdapter
            // 
            this.chartViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DivisionTableAdapter = this.divisionTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.UpdateOrder = EmpAcc.EmpAccDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(927, 515);
            this.ControlBox = false;
            this.Controls.Add(this.EmpAccTabControl);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.EmpAccTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmpDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empAccDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.DivTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DivDataGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.StatTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmpChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer MenuTimer;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.Button MaxButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl EmpAccTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage DivTab;
        private System.Windows.Forms.TabPage StatTab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView EmpDataGrid;
        private System.Windows.Forms.DataGridView DivDataGrid;
        private EmpAccDBDataSet empAccDBDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmpAccDBDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource divisionBindingSource;
        private EmpAccDBDataSetTableAdapters.DivisionTableAdapter divisionTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart EmpChart;
        private System.Windows.Forms.BindingSource ChartBindingSource;
        private System.Windows.Forms.BindingSource chartViewBindingSource;
        private EmpAccDBDataSetTableAdapters.ChartViewTableAdapter chartViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn divisionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn parentDataGridViewTextBoxColumn;
        private EmpAccDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

