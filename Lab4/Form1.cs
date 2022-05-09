using Excel = Microsoft.Office.Interop.Excel;

namespace Lab4
{
    public partial class Form1 : Form
    {
        PodpisiForm podpisi = new PodpisiForm();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void openPodpisi_Click(object sender, EventArgs e)
        {
            podpisi.ShowDialog();
        }

        private void Pechat_Click(object sender, EventArgs e)
        {
            Excel.Application myApp = new Excel.Application();
            Excel.Workbook book = myApp.Workbooks.Add("D:\\Form\\Salt_And_Spice.XLS");
            Excel.Worksheet page = (Excel.Worksheet)book.ActiveSheet;
            page.Cells[6, "A"] = Organization.Text;
            page.Cells[8, "A"] = Podrazd.Text;
            page.Cells[6, "AQ"] = OKPO.Text;
            string[] dateArr = DateSost.Text.Split(" ");
            string dayAndMonth = getDayAndMonth(DateSost.Text);
            dayAndMonth += "." + dateArr[2];
            page.Cells[16, "W"] = dayAndMonth;
            page.Cells[17, "AM"] = dateArr[0];
            page.Cells[17, "AO"] = dateArr[1];
            page.Cells[17, "AW"] = dateArr[2];
            page.Cells[7, "AQ"] = OrganizCode.Text;
            page.Cells[9, "AQ"] = DeyatOKPD.Text;
            page.Cells[10, "AQ"] = OperationType.Text;
            page.Cells[16, "Q"] = DocNum.Text;
            page.Cells[16, "AC"] = getDayAndMonth(fromPeriod.Text);
            page.Cells[16, "AG"] = getDayAndMonth(toPeriod.Text);
            int startRow = 25;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[1, i].Value == null)
                    page.Cells[startRow + i, "E"] = "";
                else
                {
                    page.Cells[startRow + i, "E"] = (dataGridView1[1, i].Value.ToString());
                    page.Cells[startRow + i, "A"] = ((i + 1).ToString());
                }
                if (dataGridView1[2, i].Value == null)
                    page.Cells[startRow + i, "S"] = "";
                else
                    page.Cells[startRow + i, "S"] = (dataGridView1[2, i].Value.ToString());
                if (dataGridView1[3, i].Value == null)
                    page.Cells[startRow + i, "W"] = "";
                else
                    page.Cells[startRow + i, "W"] = (dataGridView1[3, i].Value.ToString());
                if (dataGridView1[4, i].Value == null)
                    page.Cells[startRow + i, "AD"] = "";
                else
                    page.Cells[startRow + i, "AD"] = (dataGridView1[4, i].Value.ToString());

                if (dataGridView1[5, i].Value == null)
                    page.Cells[startRow + i, "AK"] = "";
                else
                    page.Cells[startRow + i, "AK"] = (dataGridView1[5, i].Value.ToString());
                if (dataGridView1[6, i].Value == null)
                    page.Cells[startRow + i, "AS"] = "";
                else
                    page.Cells[startRow + i, "AS"] = (dataGridView1[6, i].Value.ToString());
            }

            page.Cells[32, "W"] = textBox1.Text;
            page.Cells[32, "AD"] = textBox2.Text;
            page.Cells[32, "AK"] = textBox3.Text;
            page.Cells[32, "AS"] = textBox4.Text;
            page.Cells[40, "C"] = textBox17.Text;
            page.Cells[40, "T"] = textBox18.Text;
            page.Cells[43, "C"] = textBox19.Text;
            page.Cells[43, "T"] = textBox21.Text;
            page.Cells[40, "AE"] = textBox8.Text;
            page.Cells[40, "AL"] = textBox7.Text;
            page.Cells[42, "AE"] = textBox10.Text;
            page.Cells[42, "AL"] = textBox9.Text;
            page.Cells[45, "AE"] = textBox11.Text;
            page.Cells[45, "AL"] = textBox12.Text;
            page.Cells[46, "AL"] = textBox13.Text;
            double summa = 0;
            if (textBox15.Text != String.Empty)
            {
                summa = Convert.ToDouble(textBox15.Text);
            }
            page.Cells[47, "AL"] = summa.ToString();
            string[] ruk = podpisi.getRuk().Split(",");
            page.Cells[13, "AR"] = ruk[0];
            page.Cells[15, "AS"] = ruk[1];
            string[] sostavitel = podpisi.getSost().Split(",");
            page.Cells[49, "P"] = sostavitel[0];
            page.Cells[49, "AH"] = sostavitel[1];
            page.Cells[51, "P"] = podpisi.getBuh();
            book.Close();
        }

        private string getDayAndMonth(string date)
        {
            string[] months = { "€нвар€", "феврал€", "марта", "апрел€", "ма€", "июн€", "июл€", "августа", "сент€бр€", "окт€бр€", "нобр€", "декабр€" };
            string[] dateArr = date.Split(" ");
            string res = dateArr[0];
            for (int i = 0; i < months.Length; i++)
                if (months[i].ToLower() == dateArr[1].ToLower())
                {
                    if (i < 9)
                        res += ".0" + (i + 1).ToString();
                    else
                        res += "." + (i + 1).ToString();
                }
            return res;
        }

        private void computeTotal(object sender, DataGridViewCellEventArgs e)
        {
            int ostatokStart = 0;
            int postupiloNachalo = 0;
            int ostatokEnd = 0;
            int izrashodovano = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1[0, i].Value = ((i + 1).ToString());
                if (dataGridView1[3, i].Value != null)
                    ostatokStart += Int32.Parse(dataGridView1[3, i].Value.ToString());
                if (dataGridView1[4, i].Value != null)
                    postupiloNachalo += Int32.Parse(dataGridView1[4, i].Value.ToString());
                if (dataGridView1[5, i].Value != null)
                    ostatokEnd += Int32.Parse(dataGridView1[5, i].Value.ToString());
                if (dataGridView1[6, i].Value != null)
                    izrashodovano += Int32.Parse(dataGridView1[6, i].Value.ToString());
            }
            textBox1.Text = String.Format("{0}", ostatokStart);
            textBox2.Text = String.Format("{0}", postupiloNachalo);
            textBox3.Text = String.Format("{0}", ostatokEnd);
            textBox4.Text = String.Format("{0}", izrashodovano);
            textBox4.Text = String.Format("{0}", izrashodovano);
            textBox13.Text = String.Format("{0}", izrashodovano);
            double totalSum = 0;
            if (textBox12.Text != String.Empty)
                totalSum = Double.Parse(textBox13.Text);
            textBox15.Text = String.Format("{0}", totalSum - izrashodovano);
        }

        private void computeCount(object sender, EventArgs e)
        {
            double price1 = 0, price2 = 0;
            if (textBox17.Text != String.Empty)
                price1 = Double.Parse(textBox17.Text);
            if (textBox18.Text != String.Empty)
                price1 += Double.Parse(textBox18.Text) / 100;
            if (textBox19.Text != String.Empty)
                price2 = Double.Parse(textBox19.Text);
            if (textBox21.Text != String.Empty)
                price2 += Double.Parse(textBox21.Text) / 100;
            int count1 = 0, count2 = 0;
            if (textBox8.Text != String.Empty)
                count1 = Int32.Parse(textBox8.Text);
            if (textBox10.Text != String.Empty)
                count2 = Int32.Parse(textBox10.Text);
            double nedorashod = 0;
            if (textBox8.Text != String.Empty)
                nedorashod = Double.Parse(textBox13.Text);
            double total1 = price1 * count1;
            double total2 = price2 * count2;
            double totalSum = total1 + total2;
            textBox7.Text = String.Format("{0}", total1);
            textBox11.Text = String.Format("{0}", count1 + count2);
            textBox9.Text = String.Format("{0}", total2);
            textBox12.Text = String.Format("{0}", totalSum);
            textBox15.Text = String.Format("{0}", totalSum - nedorashod);
        }
    }
}