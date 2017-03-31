namespace Lab_7
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
            this.animalName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.animalType = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.habitatContinent = new System.Windows.Forms.ComboBox();
            this.animalIsRedBookNo = new System.Windows.Forms.RadioButton();
            this.animalDateOfReceipt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.animalIsRedBookYes = new System.Windows.Forms.RadioButton();
            this.animalAge = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonToRestore = new System.Windows.Forms.Button();
            this.habitatLatitude = new System.Windows.Forms.TextBox();
            this.habitatLaongitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CuratorMiddleName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CuratorLastName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CuratorFirstName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CuratorCountry = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalAge)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.description.Location = new System.Drawing.Point(9, 19);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(727, 137);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 169);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.habitatLaongitude);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.habitatLatitude);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.habitatContinent);
            this.groupBox2.Location = new System.Drawing.Point(251, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 169);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Habitat";
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
            this.habitatContinent.Location = new System.Drawing.Point(84, 14);
            this.habitatContinent.Name = "habitatContinent";
            this.habitatContinent.Size = new System.Drawing.Size(137, 21);
            this.habitatContinent.TabIndex = 4;
            // 
            // animalIsRedBookNo
            // 
            this.animalIsRedBookNo.AutoSize = true;
            this.animalIsRedBookNo.Location = new System.Drawing.Point(167, 116);
            this.animalIsRedBookNo.Name = "animalIsRedBookNo";
            this.animalIsRedBookNo.Size = new System.Drawing.Size(39, 17);
            this.animalIsRedBookNo.TabIndex = 9;
            this.animalIsRedBookNo.TabStop = true;
            this.animalIsRedBookNo.Text = "No";
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
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(774, 297);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonToRestore
            // 
            this.buttonToRestore.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToRestore.Location = new System.Drawing.Point(774, 326);
            this.buttonToRestore.Name = "buttonToRestore";
            this.buttonToRestore.Size = new System.Drawing.Size(121, 23);
            this.buttonToRestore.TabIndex = 9;
            this.buttonToRestore.Text = "To restore";
            this.buttonToRestore.UseVisualStyleBackColor = true;
            // 
            // habitatLatitude
            // 
            this.habitatLatitude.Location = new System.Drawing.Point(84, 41);
            this.habitatLatitude.Name = "habitatLatitude";
            this.habitatLatitude.Size = new System.Drawing.Size(137, 20);
            this.habitatLatitude.TabIndex = 11;
            // 
            // habitatLaongitude
            // 
            this.habitatLaongitude.Location = new System.Drawing.Point(84, 67);
            this.habitatLaongitude.Name = "habitatLaongitude";
            this.habitatLaongitude.Size = new System.Drawing.Size(137, 20);
            this.habitatLaongitude.TabIndex = 13;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CuratorCountry);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.CuratorFirstName);
            this.groupBox3.Controls.Add(this.CuratorMiddleName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.CuratorLastName);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(495, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 169);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Curator";
            // 
            // CuratorMiddleName
            // 
            this.CuratorMiddleName.Location = new System.Drawing.Point(101, 66);
            this.CuratorMiddleName.Name = "CuratorMiddleName";
            this.CuratorMiddleName.Size = new System.Drawing.Size(137, 20);
            this.CuratorMiddleName.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Middle name";
            // 
            // CuratorLastName
            // 
            this.CuratorLastName.Location = new System.Drawing.Point(101, 40);
            this.CuratorLastName.Name = "CuratorLastName";
            this.CuratorLastName.Size = new System.Drawing.Size(137, 20);
            this.CuratorLastName.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "First name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Last name";
            // 
            // CuratorFirstName
            // 
            this.CuratorFirstName.Location = new System.Drawing.Point(101, 14);
            this.CuratorFirstName.Name = "CuratorFirstName";
            this.CuratorFirstName.Size = new System.Drawing.Size(137, 20);
            this.CuratorFirstName.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Country";
            // 
            // CuratorCountry
            // 
            this.CuratorCountry.FormattingEnabled = true;
            this.CuratorCountry.Location = new System.Drawing.Point(101, 92);
            this.CuratorCountry.Name = "CuratorCountry";
            this.CuratorCountry.Size = new System.Drawing.Size(137, 21);
            this.CuratorCountry.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.description);
            this.groupBox4.Location = new System.Drawing.Point(16, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(742, 162);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Description";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 361);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonToRestore);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Зоопарк";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalAge)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox animalName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox animalType;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown animalAge;
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
        private System.Windows.Forms.TextBox habitatLaongitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox habitatLatitude;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox CuratorMiddleName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CuratorLastName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CuratorFirstName;
        private System.Windows.Forms.ComboBox CuratorCountry;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

