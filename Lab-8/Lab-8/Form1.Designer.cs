namespace Lab_8
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.animalName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.animalType = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.animalIsRedBookNo = new System.Windows.Forms.RadioButton();
            this.animalDateOfReceipt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.animalIsRedBookYes = new System.Windows.Forms.RadioButton();
            this.animalAge = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.habitatLongitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.habitatLatitude = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.habitatContinent = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonToRestore = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onAgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onContinentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onDateOfReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalAge)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // animalName
            // 
            this.animalName.Location = new System.Drawing.Point(73, 14);
            this.animalName.Name = "animalName";
            this.animalName.Size = new System.Drawing.Size(137, 20);
            this.animalName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type";
            // 
            // animalType
            // 
            this.animalType.FormattingEnabled = true;
            this.animalType.Location = new System.Drawing.Point(73, 40);
            this.animalType.Name = "animalType";
            this.animalType.Size = new System.Drawing.Size(137, 21);
            this.animalType.TabIndex = 4;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(6, 19);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(467, 80);
            this.description.TabIndex = 5;
            this.description.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.animalIsRedBookNo);
            this.groupBox1.Controls.Add(this.animalDateOfReceipt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.animalIsRedBookYes);
            this.groupBox1.Controls.Add(this.animalAge);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.animalName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.animalType);
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 169);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal";
            // 
            // animalIsRedBookNo
            // 
            this.animalIsRedBookNo.AutoSize = true;
            this.animalIsRedBookNo.Location = new System.Drawing.Point(167, 116);
            this.animalIsRedBookNo.Name = "animalIsRedBookNo";
            this.animalIsRedBookNo.Size = new System.Drawing.Size(42, 17);
            this.animalIsRedBookNo.TabIndex = 9;
            this.animalIsRedBookNo.TabStop = true;
            this.animalIsRedBookNo.Text = "No ";
            this.animalIsRedBookNo.UseVisualStyleBackColor = true;
            // 
            // animalDateOfReceipt
            // 
            this.animalDateOfReceipt.Location = new System.Drawing.Point(120, 139);
            this.animalDateOfReceipt.Name = "animalDateOfReceipt";
            this.animalDateOfReceipt.Size = new System.Drawing.Size(90, 20);
            this.animalDateOfReceipt.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Date of receipt";
            // 
            // animalIsRedBookYes
            // 
            this.animalIsRedBookYes.AutoSize = true;
            this.animalIsRedBookYes.Location = new System.Drawing.Point(167, 93);
            this.animalIsRedBookYes.Name = "animalIsRedBookYes";
            this.animalIsRedBookYes.Size = new System.Drawing.Size(43, 17);
            this.animalIsRedBookYes.TabIndex = 8;
            this.animalIsRedBookYes.TabStop = true;
            this.animalIsRedBookYes.Text = "Yes";
            this.animalIsRedBookYes.UseVisualStyleBackColor = true;
            // 
            // animalAge
            // 
            this.animalAge.DecimalPlaces = 2;
            this.animalAge.Location = new System.Drawing.Point(73, 67);
            this.animalAge.Name = "animalAge";
            this.animalAge.Size = new System.Drawing.Size(137, 20);
            this.animalAge.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Record on Red Book";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.habitatLongitude);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.habitatLatitude);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.habitatContinent);
            this.groupBox2.Location = new System.Drawing.Point(240, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 169);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Habitat";
            // 
            // habitatLongitude
            // 
            this.habitatLongitude.Location = new System.Drawing.Point(84, 67);
            this.habitatLongitude.Name = "habitatLongitude";
            this.habitatLongitude.Size = new System.Drawing.Size(137, 20);
            this.habitatLongitude.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Longitude";
            // 
            // habitatLatitude
            // 
            this.habitatLatitude.Location = new System.Drawing.Point(84, 41);
            this.habitatLatitude.Name = "habitatLatitude";
            this.habitatLatitude.Size = new System.Drawing.Size(137, 20);
            this.habitatLatitude.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Continent";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Latitude";
            // 
            // habitatContinent
            // 
            this.habitatContinent.FormattingEnabled = true;
            this.habitatContinent.Location = new System.Drawing.Point(84, 13);
            this.habitatContinent.Name = "habitatContinent";
            this.habitatContinent.Size = new System.Drawing.Size(137, 21);
            this.habitatContinent.TabIndex = 4;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(371, 313);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Add and save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonToRestore
            // 
            this.buttonToRestore.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToRestore.Location = new System.Drawing.Point(250, 313);
            this.buttonToRestore.Name = "buttonToRestore";
            this.buttonToRestore.Size = new System.Drawing.Size(117, 23);
            this.buttonToRestore.TabIndex = 9;
            this.buttonToRestore.Text = "Load";
            this.buttonToRestore.UseVisualStyleBackColor = true;
            this.buttonToRestore.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.description);
            this.groupBox4.Location = new System.Drawing.Point(6, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(482, 105);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Description";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(494, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(856, 274);
            this.dataGridView1.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.aboutProgrammToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1355, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.onAgeToolStripMenuItem,
            this.onContinentToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.onToolStripMenuItem.Text = "On type";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.searchOnType_Click);
            // 
            // onAgeToolStripMenuItem
            // 
            this.onAgeToolStripMenuItem.Name = "onAgeToolStripMenuItem";
            this.onAgeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.onAgeToolStripMenuItem.Text = "On age";
            this.onAgeToolStripMenuItem.Click += new System.EventHandler(this.searchOnAge_Click);
            // 
            // onContinentToolStripMenuItem
            // 
            this.onContinentToolStripMenuItem.Name = "onContinentToolStripMenuItem";
            this.onContinentToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.onContinentToolStripMenuItem.Text = "On continent";
            this.onContinentToolStripMenuItem.Click += new System.EventHandler(this.searchOnContinent_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onDateOfReceiptToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // onDateOfReceiptToolStripMenuItem
            // 
            this.onDateOfReceiptToolStripMenuItem.Name = "onDateOfReceiptToolStripMenuItem";
            this.onDateOfReceiptToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.onDateOfReceiptToolStripMenuItem.Text = "On date of receipt";
            this.onDateOfReceiptToolStripMenuItem.Click += new System.EventHandler(this.SortOnDateOfReceipt_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.saveToolStripMenuItem.Text = "Save result";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.save_Click);
            // 
            // aboutProgrammToolStripMenuItem
            // 
            this.aboutProgrammToolStripMenuItem.Name = "aboutProgrammToolStripMenuItem";
            this.aboutProgrammToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.aboutProgrammToolStripMenuItem.Text = "About program";
            this.aboutProgrammToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramm_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "D:\\Study\\2 курс\\2 семестр\\NET\\Лабораторные\\Lab-8\\Lab-8\\bin\\Debug";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1233, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonToRestore);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Zoo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalAge)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox animalName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox animalType;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonToRestore;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker animalDateOfReceipt;
        private System.Windows.Forms.RadioButton animalIsRedBookNo;
        private System.Windows.Forms.RadioButton animalIsRedBookYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox habitatContinent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox habitatLongitude;
        private System.Windows.Forms.TextBox habitatLatitude;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onAgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onContinentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onDateOfReceiptToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown animalAge;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgrammToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

