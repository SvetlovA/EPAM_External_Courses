namespace Task1
{
    partial class DateBaseForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.работаСБазойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЧеловекаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьДанныеОЧеловекеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьДанныеОЧеловекеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.добавитьНаградуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьНаградуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьНаградуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlDataBase = new System.Windows.Forms.TabControl();
            this.tabPagePerson = new System.Windows.Forms.TabPage();
            this.dataGridViewPersons = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripPerson = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьЧеловекаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonsRewards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripPersonAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьЧеловекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageRewards = new System.Windows.Forms.TabPage();
            this.dataGridViewRewards = new System.Windows.Forms.DataGridView();
            this.contextMenuStripReward = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьНаградуToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьНаградуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьНаградуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripRewardAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьНаградуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Idreward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            this.tabControlDataBase.SuspendLayout();
            this.tabPagePerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersons)).BeginInit();
            this.contextMenuStripPerson.SuspendLayout();
            this.contextMenuStripPersonAdd.SuspendLayout();
            this.tabPageRewards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRewards)).BeginInit();
            this.contextMenuStripReward.SuspendLayout();
            this.contextMenuStripRewardAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСБазойToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(685, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // работаСБазойToolStripMenuItem
            // 
            this.работаСБазойToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЧеловекаToolStripMenuItem,
            this.изменитьДанныеОЧеловекеToolStripMenuItem,
            this.удалитьДанныеОЧеловекеToolStripMenuItem,
            this.toolStripSeparator1,
            this.добавитьНаградуToolStripMenuItem,
            this.редактироватьНаградуToolStripMenuItem,
            this.удалитьНаградуToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.работаСБазойToolStripMenuItem.Name = "работаСБазойToolStripMenuItem";
            this.работаСБазойToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.работаСБазойToolStripMenuItem.Text = "Работа с базой";
            // 
            // добавитьЧеловекаToolStripMenuItem
            // 
            this.добавитьЧеловекаToolStripMenuItem.Name = "добавитьЧеловекаToolStripMenuItem";
            this.добавитьЧеловекаToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.добавитьЧеловекаToolStripMenuItem.Text = "Добавить человека";
            this.добавитьЧеловекаToolStripMenuItem.Click += new System.EventHandler(this.добавитьЧеловекаToolStripMenuItem_Click);
            // 
            // изменитьДанныеОЧеловекеToolStripMenuItem
            // 
            this.изменитьДанныеОЧеловекеToolStripMenuItem.Enabled = false;
            this.изменитьДанныеОЧеловекеToolStripMenuItem.Name = "изменитьДанныеОЧеловекеToolStripMenuItem";
            this.изменитьДанныеОЧеловекеToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.изменитьДанныеОЧеловекеToolStripMenuItem.Text = "Изменить данные о человеке";
            this.изменитьДанныеОЧеловекеToolStripMenuItem.Click += new System.EventHandler(this.изменитьДанныеОЧеловекеToolStripMenuItem_Click);
            // 
            // удалитьДанныеОЧеловекеToolStripMenuItem
            // 
            this.удалитьДанныеОЧеловекеToolStripMenuItem.Enabled = false;
            this.удалитьДанныеОЧеловекеToolStripMenuItem.Name = "удалитьДанныеОЧеловекеToolStripMenuItem";
            this.удалитьДанныеОЧеловекеToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.удалитьДанныеОЧеловекеToolStripMenuItem.Text = "Удалить данные о человеке";
            this.удалитьДанныеОЧеловекеToolStripMenuItem.Click += new System.EventHandler(this.удалитьДанныеОЧеловекеToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // добавитьНаградуToolStripMenuItem
            // 
            this.добавитьНаградуToolStripMenuItem.Name = "добавитьНаградуToolStripMenuItem";
            this.добавитьНаградуToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.добавитьНаградуToolStripMenuItem.Text = "Добавить награду";
            this.добавитьНаградуToolStripMenuItem.Click += new System.EventHandler(this.добавитьНаградуToolStripMenuItem_Click);
            // 
            // редактироватьНаградуToolStripMenuItem
            // 
            this.редактироватьНаградуToolStripMenuItem.Enabled = false;
            this.редактироватьНаградуToolStripMenuItem.Name = "редактироватьНаградуToolStripMenuItem";
            this.редактироватьНаградуToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.редактироватьНаградуToolStripMenuItem.Text = "Редактировать награду";
            this.редактироватьНаградуToolStripMenuItem.Click += new System.EventHandler(this.редактироватьНаградуToolStripMenuItem_Click);
            // 
            // удалитьНаградуToolStripMenuItem
            // 
            this.удалитьНаградуToolStripMenuItem.Enabled = false;
            this.удалитьНаградуToolStripMenuItem.Name = "удалитьНаградуToolStripMenuItem";
            this.удалитьНаградуToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.удалитьНаградуToolStripMenuItem.Text = "Удалить награду";
            this.удалитьНаградуToolStripMenuItem.Click += new System.EventHandler(this.удалитьНаградуToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(233, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tabControlDataBase
            // 
            this.tabControlDataBase.Controls.Add(this.tabPagePerson);
            this.tabControlDataBase.Controls.Add(this.tabPageRewards);
            this.tabControlDataBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDataBase.Location = new System.Drawing.Point(0, 24);
            this.tabControlDataBase.Name = "tabControlDataBase";
            this.tabControlDataBase.SelectedIndex = 0;
            this.tabControlDataBase.Size = new System.Drawing.Size(685, 339);
            this.tabControlDataBase.TabIndex = 1;
            // 
            // tabPagePerson
            // 
            this.tabPagePerson.Controls.Add(this.dataGridViewPersons);
            this.tabPagePerson.Location = new System.Drawing.Point(4, 22);
            this.tabPagePerson.Name = "tabPagePerson";
            this.tabPagePerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePerson.Size = new System.Drawing.Size(677, 313);
            this.tabPagePerson.TabIndex = 0;
            this.tabPagePerson.Text = "Люди";
            this.tabPagePerson.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPersons
            // 
            this.dataGridViewPersons.AllowUserToAddRows = false;
            this.dataGridViewPersons.AllowUserToDeleteRows = false;
            this.dataGridViewPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.Birthday,
            this.Age,
            this.PersonsRewards});
            this.dataGridViewPersons.ContextMenuStrip = this.contextMenuStripPersonAdd;
            this.dataGridViewPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPersons.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPersons.Name = "dataGridViewPersons";
            this.dataGridViewPersons.ReadOnly = true;
            this.dataGridViewPersons.Size = new System.Drawing.Size(671, 307);
            this.dataGridViewPersons.TabIndex = 0;
            this.dataGridViewPersons.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPersons_ColumnHeaderMouseClick);
            this.dataGridViewPersons.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewPersons_DataBindingComplete);
            this.dataGridViewPersons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewPersons_MouseDown);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.ContextMenuStrip = this.contextMenuStripPerson;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Id.Width = 43;
            // 
            // contextMenuStripPerson
            // 
            this.contextMenuStripPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЧеловекаToolStripMenuItem1,
            this.редактироватьИнформациюToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStripPerson.Name = "contextMenuStripPerson";
            this.contextMenuStripPerson.Size = new System.Drawing.Size(234, 70);
            // 
            // добавитьЧеловекаToolStripMenuItem1
            // 
            this.добавитьЧеловекаToolStripMenuItem1.Name = "добавитьЧеловекаToolStripMenuItem1";
            this.добавитьЧеловекаToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
            this.добавитьЧеловекаToolStripMenuItem1.Text = "Добавить человека";
            this.добавитьЧеловекаToolStripMenuItem1.Click += new System.EventHandler(this.добавитьЧеловекаToolStripMenuItem1_Click);
            // 
            // редактироватьИнформациюToolStripMenuItem
            // 
            this.редактироватьИнформациюToolStripMenuItem.Name = "редактироватьИнформациюToolStripMenuItem";
            this.редактироватьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.редактироватьИнформациюToolStripMenuItem.Text = "Редактировать информацию";
            this.редактироватьИнформациюToolStripMenuItem.Click += new System.EventHandler(this.редактироватьИнформациюToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FirstName.ContextMenuStrip = this.contextMenuStripPerson;
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.FirstName.Width = 54;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LastName.ContextMenuStrip = this.contextMenuStripPerson;
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.LastName.Width = 81;
            // 
            // Birthday
            // 
            this.Birthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Birthday.ContextMenuStrip = this.contextMenuStripPerson;
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "Дата рождения";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Birthday.Width = 102;
            // 
            // Age
            // 
            this.Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Age.ContextMenuStrip = this.contextMenuStripPerson;
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Возраст";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Age.Width = 74;
            // 
            // PersonsRewards
            // 
            this.PersonsRewards.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PersonsRewards.ContextMenuStrip = this.contextMenuStripPerson;
            this.PersonsRewards.DataPropertyName = "Rewards";
            this.PersonsRewards.HeaderText = "Награды";
            this.PersonsRewards.Name = "PersonsRewards";
            this.PersonsRewards.ReadOnly = true;
            this.PersonsRewards.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.PersonsRewards.Width = 77;
            // 
            // contextMenuStripPersonAdd
            // 
            this.contextMenuStripPersonAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЧеловекToolStripMenuItem});
            this.contextMenuStripPersonAdd.Name = "contextMenuStripPersonAdd";
            this.contextMenuStripPersonAdd.Size = new System.Drawing.Size(181, 26);
            // 
            // добавитьЧеловекToolStripMenuItem
            // 
            this.добавитьЧеловекToolStripMenuItem.Name = "добавитьЧеловекToolStripMenuItem";
            this.добавитьЧеловекToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьЧеловекToolStripMenuItem.Text = "Добавить человека";
            this.добавитьЧеловекToolStripMenuItem.Click += new System.EventHandler(this.добавитьЧеловекToolStripMenuItem_Click);
            // 
            // tabPageRewards
            // 
            this.tabPageRewards.Controls.Add(this.dataGridViewRewards);
            this.tabPageRewards.Location = new System.Drawing.Point(4, 22);
            this.tabPageRewards.Name = "tabPageRewards";
            this.tabPageRewards.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRewards.Size = new System.Drawing.Size(677, 313);
            this.tabPageRewards.TabIndex = 1;
            this.tabPageRewards.Text = "Награды";
            this.tabPageRewards.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRewards
            // 
            this.dataGridViewRewards.AllowUserToAddRows = false;
            this.dataGridViewRewards.AllowUserToDeleteRows = false;
            this.dataGridViewRewards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRewards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idreward,
            this.Title,
            this.Description});
            this.dataGridViewRewards.ContextMenuStrip = this.contextMenuStripRewardAdd;
            this.dataGridViewRewards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRewards.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewRewards.Name = "dataGridViewRewards";
            this.dataGridViewRewards.ReadOnly = true;
            this.dataGridViewRewards.Size = new System.Drawing.Size(671, 307);
            this.dataGridViewRewards.TabIndex = 0;
            this.dataGridViewRewards.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRewards_ColumnHeaderMouseClick);
            this.dataGridViewRewards.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewRewards_DataBindingComplete);
            this.dataGridViewRewards.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewRewards_MouseDown);
            // 
            // contextMenuStripReward
            // 
            this.contextMenuStripReward.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНаградуToolStripMenuItem2,
            this.редактироватьНаградуToolStripMenuItem1,
            this.удалитьНаградуToolStripMenuItem1});
            this.contextMenuStripReward.Name = "contextMenuStripHonor";
            this.contextMenuStripReward.Size = new System.Drawing.Size(201, 70);
            // 
            // добавитьНаградуToolStripMenuItem2
            // 
            this.добавитьНаградуToolStripMenuItem2.Name = "добавитьНаградуToolStripMenuItem2";
            this.добавитьНаградуToolStripMenuItem2.Size = new System.Drawing.Size(200, 22);
            this.добавитьНаградуToolStripMenuItem2.Text = "Добавить награду";
            this.добавитьНаградуToolStripMenuItem2.Click += new System.EventHandler(this.добавитьНаградуToolStripMenuItem2_Click);
            // 
            // редактироватьНаградуToolStripMenuItem1
            // 
            this.редактироватьНаградуToolStripMenuItem1.Name = "редактироватьНаградуToolStripMenuItem1";
            this.редактироватьНаградуToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.редактироватьНаградуToolStripMenuItem1.Text = "Редактировать награду";
            this.редактироватьНаградуToolStripMenuItem1.Click += new System.EventHandler(this.редактироватьНаградуToolStripMenuItem1_Click);
            // 
            // удалитьНаградуToolStripMenuItem1
            // 
            this.удалитьНаградуToolStripMenuItem1.Name = "удалитьНаградуToolStripMenuItem1";
            this.удалитьНаградуToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.удалитьНаградуToolStripMenuItem1.Text = "Удалить награду";
            this.удалитьНаградуToolStripMenuItem1.Click += new System.EventHandler(this.удалитьНаградуToolStripMenuItem1_Click);
            // 
            // contextMenuStripRewardAdd
            // 
            this.contextMenuStripRewardAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНаградуToolStripMenuItem1});
            this.contextMenuStripRewardAdd.Name = "contextMenuStripHonorAdd";
            this.contextMenuStripRewardAdd.Size = new System.Drawing.Size(173, 26);
            // 
            // добавитьНаградуToolStripMenuItem1
            // 
            this.добавитьНаградуToolStripMenuItem1.Name = "добавитьНаградуToolStripMenuItem1";
            this.добавитьНаградуToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.добавитьНаградуToolStripMenuItem1.Text = "Добавить награду";
            this.добавитьНаградуToolStripMenuItem1.Click += new System.EventHandler(this.добавитьНаградуToolStripMenuItem1_Click);
            // 
            // Idreward
            // 
            this.Idreward.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Idreward.ContextMenuStrip = this.contextMenuStripReward;
            this.Idreward.DataPropertyName = "Id";
            this.Idreward.HeaderText = "ID";
            this.Idreward.Name = "Idreward";
            this.Idreward.ReadOnly = true;
            this.Idreward.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Idreward.Width = 43;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Title.ContextMenuStrip = this.contextMenuStripReward;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Название";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Title.Width = 82;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Description.ContextMenuStrip = this.contextMenuStripReward;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Description.Width = 82;
            // 
            // DateBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 363);
            this.Controls.Add(this.tabControlDataBase);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "DateBaseForm";
            this.Text = "База данных";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControlDataBase.ResumeLayout(false);
            this.tabPagePerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersons)).EndInit();
            this.contextMenuStripPerson.ResumeLayout(false);
            this.contextMenuStripPersonAdd.ResumeLayout(false);
            this.tabPageRewards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRewards)).EndInit();
            this.contextMenuStripReward.ResumeLayout(false);
            this.contextMenuStripRewardAdd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem работаСБазойToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlDataBase;
        private System.Windows.Forms.TabPage tabPagePerson;
        private System.Windows.Forms.TabPage tabPageRewards;
        private System.Windows.Forms.DataGridView dataGridViewPersons;
        private System.Windows.Forms.DataGridView dataGridViewRewards;
        private System.Windows.Forms.ToolStripMenuItem добавитьЧеловекаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьДанныеОЧеловекеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьДанныеОЧеловекеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНаградуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьНаградуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьНаградуToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPersonAdd;
        private System.Windows.Forms.ToolStripMenuItem добавитьЧеловекToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPerson;
        private System.Windows.Forms.ToolStripMenuItem добавитьЧеловекаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripReward;
        private System.Windows.Forms.ToolStripMenuItem добавитьНаградуToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem редактироватьНаградуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьНаградуToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRewardAdd;
        private System.Windows.Forms.ToolStripMenuItem добавитьНаградуToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonsRewards;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idreward;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}

