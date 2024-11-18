using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfPr20_Var1
{
    public partial class Form2 : Form
    {
        Form1 f1;
        private object printDocument1;

       

        public Form2(Form1 f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            textBox1.AppendText("Название рыбы: " + f1.textBox1.Text + Environment.NewLine);
            textBox1.AppendText("Цена: " + f1.maskedTextBox1.Text + Environment.NewLine);
            textBox1.AppendText("Кол-во рыбы: " + f1.numericUpDown1.Text + Environment.NewLine);
            textBox1.AppendText("Выловлена в: " + f1.comboBox1.Text + Environment.NewLine);
            textBox1.AppendText("Состояние: " + f1.comboBox2.Text + Environment.NewLine);
            textBox1.AppendText("Выловлена: " + f1.dateTimePicker1.Text + Environment.NewLine);
            textBox1.AppendText("Срок годности (дни): " + f1.numericUpDown2.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText("Контактная информация: " + Environment.NewLine);
            textBox1.AppendText("Телефон: " + f1.textBox2.Text + Environment.NewLine);
            textBox1.AppendText("Почта: " + f1.textBox3.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText("Адрес: " + Environment.NewLine);
            textBox1.AppendText("Дом: " + f1.textBox4.Text + Environment.NewLine);
            textBox1.AppendText("Улица: " + f1.textBox5.Text + Environment.NewLine);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.BackColor = colorDialog1.Color;
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Font = fontDialog1.Font;
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //создаем новый файл для записи
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create,
                FileAccess.Write);
                //создаем поток записи
                StreamWriter sw = new StreamWriter(fs);
                //записываем данные
                sw.WriteLine(textBox1.Text);
                //закрываем стримы
                sw.Close();
                fs.Close();
            }
        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //создаем новый файл для чтения
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open,
                FileAccess.Read);
                //создаем поток чтения
                StreamReader sr = new StreamReader(fs);
                textBox1.Text = sr.ReadToEnd();
                //закрываем стримы
                sr.Close();
                fs.Close();
            }
        }

        private void toolStripTextBox5_Click(object sender, EventArgs e)

        {

            // обработчик события печати
            printDocument2.PrintPage += PrintPageHandler;
                printPreviewDialog1.Document = (PrintDocument)printDocument1;
                // если в диалоге было нажато ОК
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    printPreviewDialog1.Document.Print(); // печатаем
            
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, Font, Brushes.Black, 20, 20);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageSetupDialog = new PageSetupDialog();

            // Установка параметров страницы печати
            pageSetupDialog.PageSettings = new PageSettings();

            // Отображение диалогового окна настройки страницы
            DialogResult result = pageSetupDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Console.WriteLine("Paper Size: " + pageSetupDialog.PageSettings.PaperSize.ToString());
                Console.WriteLine("Margins: " + pageSetupDialog.PageSettings.Margins.ToString());
            }


        }

        private void выборПринтераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                PrintDialog printDialog = new PrintDialog();

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    PrinterSettings printerSettings = printDialog.PrinterSettings;
                    MessageBox.Show($"Выбранный принтер: {printerSettings.PrinterName}");
                }
            }
        }
    }
}



   

    


