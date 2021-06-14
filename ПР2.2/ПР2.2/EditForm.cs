using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_2
{
    public partial class EditForm : Form
    {
        /// <summary>
        /// true - если запись модифицируется, false - если создаётся новая
        /// </summary>
        bool edit;
        /// <summary>
        /// id модифицируемого элемента
        /// </summary>
        int id;
        /// <summary>
        /// конструктор формы, для создания новой записи
        /// </summary>

        public EditForm()
        {
            InitializeComponent();
            roomsTableAdapter.Fill(hostelDataSet.Rooms);
            privelegesTableAdapter.Fill(hostelDataSet.Priveleges);
            edit = false;
        }

        /// <summary>
        /// конструктор формы, для модификации уже существующей записи
        /// </summary>
        /// <param name="SNP">Значение поля ФИО</param>
        /// <param name="BirthDate">Значение поля Дата рождения</param>
        /// <param name="Gender">Значение поля пол</param>
        /// <param name="Address">Значение поля адресс</param>
        /// <param name="Group">Значение поля академическа группа</param>
        /// <param name="Discount">Значение поля тип льготы</param>
        /// <param name="Doc">Значение поля документ</param>
        /// <param name="room">Значение поля комната</param>
        /// <param name="id">Первичный ключ поля</param>

        public EditForm(String SNP, DateTime BirthDate, String Gender, String Address, String Group,
                        int Discount, String Doc, int room, int id)
        : this()
        {
            roomsTableAdapter.Fill(hostelDataSet.Rooms);
            privelegesTableAdapter.Fill(hostelDataSet.Priveleges);
            edit = true;
            this.id = id;
            this.textBox_SNP.Text = SNP;
            this.dateTimePicker_Birth.Value = BirthDate;
            if (Gender.ToUpper() == "М")
            {
                comboBox_Gender.SelectedIndex = 0;
            }
            else if (Gender.ToUpper() == "Ж")
            {
                comboBox_Gender.SelectedIndex = 1;
            }
            this.textBox_Address.Text = Address;
            this.textBox_Group.Text = Group;
            this.comboBox_Discount.SelectedValue = Discount;
            this.textBox_Document.Text = Doc;
            this.comboBox_Room.SelectedValue = room;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            string Gender = "";
            if (comboBox_Gender.SelectedIndex == 0)
            {
                Gender = "М";

            }
            else if (comboBox_Gender.SelectedIndex == 1)
            {
                Gender = "Ж";
            }
            if (edit)
            {
                studentsTableAdapter.UpdateQuery(textBox_SNP.Text, dateTimePicker_Birth.Value, Gender,
                textBox_Address.Text, textBox_Group.Text,
                Convert.ToInt32(comboBox_Discount.SelectedValue), textBox_Document.Text,
                Convert.ToInt32(comboBox_Room.SelectedValue), id);
            }
            else
            {
                studentsTableAdapter.InsertQuery(textBox_SNP.Text, dateTimePicker_Birth.Value, Gender,
                textBox_Address.Text, textBox_Group.Text,
                Convert.ToInt32(comboBox_Discount.SelectedValue), textBox_Document.Text,
                Convert.ToInt32(comboBox_Room.SelectedValue), DateTime.Now);
            }
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
