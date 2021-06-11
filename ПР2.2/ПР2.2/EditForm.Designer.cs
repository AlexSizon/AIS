
namespace PR_2
{
    partial class EditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_SNP = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Birth = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.textBox_Group = new System.Windows.Forms.TextBox();
            this.comboBox_Discount = new System.Windows.Forms.ComboBox();
            this.privelegesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostelDataSet = new PR_2.HostelDataSet();
            this.textBox_Document = new System.Windows.Forms.TextBox();
            this.comboBox_Room = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.privelegesTableAdapter = new PR_2.HostelDataSetTableAdapters.PrivelegesTableAdapter();
            this.roomsTableAdapter = new PR_2.HostelDataSetTableAdapters.RoomsTableAdapter();
            this.studentsTableAdapter = new PR_2.HostelDataSetTableAdapters.StudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.privelegesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата народження";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Стать";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Група";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Тип пільг";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Номер документу";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Кімната";
            // 
            // textBox_SNP
            // 
            this.textBox_SNP.Location = new System.Drawing.Point(154, 20);
            this.textBox_SNP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_SNP.Name = "textBox_SNP";
            this.textBox_SNP.Size = new System.Drawing.Size(151, 20);
            this.textBox_SNP.TabIndex = 8;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(154, 110);
            this.textBox_Address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(151, 20);
            this.textBox_Address.TabIndex = 9;
            // 
            // dateTimePicker_Birth
            // 
            this.dateTimePicker_Birth.Location = new System.Drawing.Point(154, 50);
            this.dateTimePicker_Birth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker_Birth.Name = "dateTimePicker_Birth";
            this.dateTimePicker_Birth.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker_Birth.TabIndex = 10;
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Чоловік",
            "Жінка"});
            this.comboBox_Gender.Location = new System.Drawing.Point(154, 80);
            this.comboBox_Gender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(151, 21);
            this.comboBox_Gender.TabIndex = 11;
            // 
            // textBox_Group
            // 
            this.textBox_Group.Location = new System.Drawing.Point(154, 141);
            this.textBox_Group.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Group.Name = "textBox_Group";
            this.textBox_Group.Size = new System.Drawing.Size(151, 20);
            this.textBox_Group.TabIndex = 12;
            // 
            // comboBox_Discount
            // 
            this.comboBox_Discount.DataSource = this.privelegesBindingSource;
            this.comboBox_Discount.DisplayMember = "Privelege type";
            this.comboBox_Discount.FormattingEnabled = true;
            this.comboBox_Discount.Location = new System.Drawing.Point(154, 164);
            this.comboBox_Discount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Discount.Name = "comboBox_Discount";
            this.comboBox_Discount.Size = new System.Drawing.Size(151, 21);
            this.comboBox_Discount.TabIndex = 13;
            this.comboBox_Discount.ValueMember = "Privelege Code";
            // 
            // privelegesBindingSource
            // 
            this.privelegesBindingSource.DataMember = "Priveleges";
            this.privelegesBindingSource.DataSource = this.hostelDataSet;
            // 
            // hostelDataSet
            // 
            this.hostelDataSet.DataSetName = "HostelDataSet";
            this.hostelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_Document
            // 
            this.textBox_Document.Location = new System.Drawing.Point(154, 191);
            this.textBox_Document.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Document.Name = "textBox_Document";
            this.textBox_Document.Size = new System.Drawing.Size(151, 20);
            this.textBox_Document.TabIndex = 14;
            // 
            // comboBox_Room
            // 
            this.comboBox_Room.DataSource = this.roomsBindingSource;
            this.comboBox_Room.DisplayMember = "Room N";
            this.comboBox_Room.FormattingEnabled = true;
            this.comboBox_Room.Location = new System.Drawing.Point(154, 215);
            this.comboBox_Room.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Room.Name = "comboBox_Room";
            this.comboBox_Room.Size = new System.Drawing.Size(151, 21);
            this.comboBox_Room.TabIndex = 15;
            this.comboBox_Room.ValueMember = "Room N";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.hostelDataSet;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(44, 298);
            this.button_Ok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(72, 20);
            this.button_Ok.TabIndex = 16;
            this.button_Ok.Text = "OK";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(167, 298);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(73, 20);
            this.button_Cancel.TabIndex = 17;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // privelegesTableAdapter
            // 
            this.privelegesTableAdapter.ClearBeforeFill = true;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 339);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.comboBox_Room);
            this.Controls.Add(this.textBox_Document);
            this.Controls.Add(this.comboBox_Discount);
            this.Controls.Add(this.textBox_Group);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.dateTimePicker_Birth);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.textBox_SNP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privelegesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_SNP;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Birth;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.TextBox textBox_Group;
        private System.Windows.Forms.ComboBox comboBox_Discount;
        private System.Windows.Forms.TextBox textBox_Document;
        private System.Windows.Forms.ComboBox comboBox_Room;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Cancel;
        private HostelDataSet hostelDataSet;
        private System.Windows.Forms.BindingSource privelegesBindingSource;
        private HostelDataSetTableAdapters.PrivelegesTableAdapter privelegesTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private HostelDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private HostelDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
    }
}