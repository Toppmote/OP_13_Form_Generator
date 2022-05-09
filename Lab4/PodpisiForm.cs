using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class PodpisiForm : Form
    {
        public PodpisiForm()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("Директор, Иванов Иван Иванович");
            comboBox1.Items.Add("Управляющий, Петров Пётр Петрович");
            comboBox1.Items.Add("Менеджер, Сидорова Татьяна Олеговна");
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.Items.Add("Управляющий, Петров Пётр Петрович");
            comboBox2.Items.Add("Менеджер, Сидорова Татьяна Олеговна");
            comboBox2.Items.Add("Старший работник, Тыквин Степан Станиславович");
            comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox4.Items.Add("Симонов Иван Иванович");
            comboBox4.Items.Add("Еремин Даниил Викторович");
            comboBox4.Items.Add("Аносова Татьяна Игоревна");
        }

        public string getRuk()
        {
            return comboBox1.Text;
        }

        public string getSost()
        {
            return comboBox2.Text;
        }

        public string getBuh()
        {
            return comboBox4.Text;
        }

    }
}
