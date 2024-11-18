namespace zd3
{
    partial class Form1
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
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.txtCollegeCount = new System.Windows.Forms.TextBox();
            this.txtAverageGrade = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtStudentCount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCalculateQuality = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.колледжToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удлитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кличествоКолледжейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCollegeName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSetCollegeCount = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCalculateSingleQuality = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lINQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 20;
            this.listBoxData.Location = new System.Drawing.Point(546, 59);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(737, 444);
            this.listBoxData.TabIndex = 0;
            // 
            // txtCollegeCount
            // 
            this.txtCollegeCount.Location = new System.Drawing.Point(1374, 1079);
            this.txtCollegeCount.Name = "txtCollegeCount";
            this.txtCollegeCount.Size = new System.Drawing.Size(203, 26);
            this.txtCollegeCount.TabIndex = 1;
            this.txtCollegeCount.Visible = false;
            // 
            // txtAverageGrade
            // 
            this.txtAverageGrade.Location = new System.Drawing.Point(291, 123);
            this.txtAverageGrade.Name = "txtAverageGrade";
            this.txtAverageGrade.Size = new System.Drawing.Size(203, 26);
            this.txtAverageGrade.TabIndex = 2;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(1102, 994);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(203, 26);
            this.txtRegion.TabIndex = 3;
            this.txtRegion.Visible = false;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(1317, 1035);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(203, 26);
            this.txtYear.TabIndex = 4;
            this.txtYear.Visible = false;
            // 
            // txtStudentCount
            // 
            this.txtStudentCount.Location = new System.Drawing.Point(291, 268);
            this.txtStudentCount.Name = "txtStudentCount";
            this.txtStudentCount.Size = new System.Drawing.Size(203, 26);
            this.txtStudentCount.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Salmon;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(169, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 65);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Salmon;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Transparent;
            this.btnRemove.Location = new System.Drawing.Point(105, 105);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(180, 65);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "удалить";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCalculateQuality
            // 
            this.btnCalculateQuality.BackColor = System.Drawing.Color.Salmon;
            this.btnCalculateQuality.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculateQuality.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateQuality.ForeColor = System.Drawing.Color.Transparent;
            this.btnCalculateQuality.Location = new System.Drawing.Point(118, 108);
            this.btnCalculateQuality.Name = "btnCalculateQuality";
            this.btnCalculateQuality.Size = new System.Drawing.Size(180, 65);
            this.btnCalculateQuality.TabIndex = 9;
            this.btnCalculateQuality.Text = "рассчитать качество";
            this.btnCalculateQuality.UseVisualStyleBackColor = false;
            this.btnCalculateQuality.Click += new System.EventHandler(this.btnCalculateQuality_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1097, 1076);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Количество колледжей";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Средний балл";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Регион";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Год основания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Количество студентов";
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.Salmon;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.Transparent;
            this.btnShowAll.Location = new System.Drawing.Point(1137, 1158);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(180, 65);
            this.btnShowAll.TabIndex = 16;
            this.btnShowAll.Text = "запросы";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Visible = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Salmon;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.колледжToolStripMenuItem,
            this.выходИзПрограммыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1573, 33);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // колледжToolStripMenuItem
            // 
            this.колледжToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удлитьToolStripMenuItem,
            this.кToolStripMenuItem,
            this.кличествоКолледжейToolStripMenuItem,
            this.lINQToolStripMenuItem});
            this.колледжToolStripMenuItem.Name = "колледжToolStripMenuItem";
            this.колледжToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.колледжToolStripMenuItem.Text = "Колледж";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.добавитьToolStripMenuItem.Text = "добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удлитьToolStripMenuItem
            // 
            this.удлитьToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.удлитьToolStripMenuItem.Name = "удлитьToolStripMenuItem";
            this.удлитьToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.удлитьToolStripMenuItem.Text = "удлить";
            this.удлитьToolStripMenuItem.Click += new System.EventHandler(this.удлитьToolStripMenuItem_Click);
            // 
            // кToolStripMenuItem
            // 
            this.кToolStripMenuItem.BackColor = System.Drawing.Color.OrangeRed;
            this.кToolStripMenuItem.Name = "кToolStripMenuItem";
            this.кToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.кToolStripMenuItem.Text = "расчет качества";
            this.кToolStripMenuItem.Click += new System.EventHandler(this.кToolStripMenuItem_Click);
            // 
            // кличествоКолледжейToolStripMenuItem
            // 
            this.кличествоКолледжейToolStripMenuItem.Name = "кличествоКолледжейToolStripMenuItem";
            this.кличествоКолледжейToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.кличествоКолледжейToolStripMenuItem.Text = "количество колледжей";
            this.кличествоКолледжейToolStripMenuItem.Visible = false;
            // 
            // выходИзПрограммыToolStripMenuItem
            // 
            this.выходИзПрограммыToolStripMenuItem.Name = "выходИзПрограммыToolStripMenuItem";
            this.выходИзПрограммыToolStripMenuItem.Size = new System.Drawing.Size(206, 29);
            this.выходИзПрограммыToolStripMenuItem.Text = "Выход из программы";
            this.выходИзПрограммыToolStripMenuItem.Click += new System.EventHandler(this.выходИзПрограммыToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Название колледжа";
            // 
            // txtCollegeName
            // 
            this.txtCollegeName.Location = new System.Drawing.Point(291, 80);
            this.txtCollegeName.Name = "txtCollegeName";
            this.txtCollegeName.Size = new System.Drawing.Size(203, 26);
            this.txtCollegeName.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.comboBoxRegion);
            this.panel1.Controls.Add(this.numericUpDownYear);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtStudentCount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAverageGrade);
            this.panel1.Controls.Add(this.txtCollegeName);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 430);
            this.panel1.TabIndex = 20;
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Items.AddRange(new object[] {
            "Свердловская область",
            "Московская область",
            "Челябинская область"});
            this.comboBoxRegion.Location = new System.Drawing.Point(291, 174);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(203, 28);
            this.comboBoxRegion.TabIndex = 22;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(291, 220);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1890,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(203, 26);
            this.numericUpDownYear.TabIndex = 21;
            this.numericUpDownYear.Value = new decimal(new int[] {
            1890,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(357, 39);
            this.label7.TabIndex = 20;
            this.label7.Text = "Добавление колледжа";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Location = new System.Drawing.Point(461, 521);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 182);
            this.panel2.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(67, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(256, 44);
            this.label9.TabIndex = 21;
            this.label9.Text = "(выберите колледж который \r\nхотите удалить)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(319, 39);
            this.label8.TabIndex = 21;
            this.label8.Text = "Удаление колледжа";
            // 
            // btnSetCollegeCount
            // 
            this.btnSetCollegeCount.BackColor = System.Drawing.Color.Salmon;
            this.btnSetCollegeCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetCollegeCount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetCollegeCount.ForeColor = System.Drawing.Color.Transparent;
            this.btnSetCollegeCount.Location = new System.Drawing.Point(1345, 1126);
            this.btnSetCollegeCount.Name = "btnSetCollegeCount";
            this.btnSetCollegeCount.Size = new System.Drawing.Size(180, 65);
            this.btnSetCollegeCount.TabIndex = 22;
            this.btnSetCollegeCount.Text = "ввести";
            this.btnSetCollegeCount.UseVisualStyleBackColor = false;
            this.btnSetCollegeCount.Visible = false;
            this.btnSetCollegeCount.Click += new System.EventHandler(this.btnSetCollegeCount_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Bisque;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnCalculateSingleQuality);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnCalculateQuality);
            this.panel3.Location = new System.Drawing.Point(12, 521);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(428, 333);
            this.panel3.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(68, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(286, 22);
            this.label12.TabIndex = 23;
            this.label12.Text = "(качество для одного колледжа)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(123, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "(общее качество)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculateSingleQuality
            // 
            this.btnCalculateSingleQuality.BackColor = System.Drawing.Color.Salmon;
            this.btnCalculateSingleQuality.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculateSingleQuality.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateSingleQuality.ForeColor = System.Drawing.Color.Transparent;
            this.btnCalculateSingleQuality.Location = new System.Drawing.Point(118, 229);
            this.btnCalculateSingleQuality.Name = "btnCalculateSingleQuality";
            this.btnCalculateSingleQuality.Size = new System.Drawing.Size(180, 65);
            this.btnCalculateSingleQuality.TabIndex = 22;
            this.btnCalculateSingleQuality.Text = "рассчитать качество";
            this.btnCalculateSingleQuality.UseVisualStyleBackColor = false;
            this.btnCalculateSingleQuality.Click += new System.EventHandler(this.btnCalculateSingleQuality_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(65, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(300, 39);
            this.label10.TabIndex = 21;
            this.label10.Text = "Рассчет качества Q";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(105, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 65);
            this.button1.TabIndex = 24;
            this.button1.Text = "вывести";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(1374, 955);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 65);
            this.button2.TabIndex = 25;
            this.button2.Text = "1000";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PeachPuff;
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(461, 718);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 213);
            this.panel4.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(98, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 39);
            this.label13.TabIndex = 22;
            this.label13.Text = "Запрос LINQ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(67, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(240, 44);
            this.label14.TabIndex = 22;
            this.label14.Text = "(запрос выводит колледжи\r\n с качеством 5)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lINQToolStripMenuItem
            // 
            this.lINQToolStripMenuItem.Name = "lINQToolStripMenuItem";
            this.lINQToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.lINQToolStripMenuItem.Text = "LINQ";
            this.lINQToolStripMenuItem.Click += new System.EventHandler(this.lINQToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1573, 1222);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSetCollegeCount);
            this.Controls.Add(this.txtCollegeCount);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.TextBox txtCollegeCount;
        private System.Windows.Forms.TextBox txtAverageGrade;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtStudentCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCalculateQuality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem колледжToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удлитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзПрограммыToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCollegeName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem кToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem кличествоКолледжейToolStripMenuItem;
        private System.Windows.Forms.Button btnSetCollegeCount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCalculateSingleQuality;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem lINQToolStripMenuItem;
        private System.Windows.Forms.Label label14;
    }
}

