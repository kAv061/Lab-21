using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

namespace wfPr20_Var1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "рыбный_магазинDataSet.Vid_riby". При необходимости она может быть перемещена или удалена.
            this.vid_ribyTableAdapter.Fill(this.рыбный_магазинDataSet.Vid_riby);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "рыбный_магазинDataSet.Prodasha_riby". При необходимости она может быть перемещена или удалена.
            this.prodasha_ribyTableAdapter.Fill(this.рыбный_магазинDataSet.Prodasha_riby);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "рыбный_магазинDataSet.Postawchik". При необходимости она может быть перемещена или удалена.
            this.postawchikTableAdapter.Fill(this.рыбный_магазинDataSet.Postawchik);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            postawchikBindingSource.EndEdit();
            postawchikTableAdapter.Update(рыбный_магазинDataSet);
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            prodashaRibyBindingSource.EndEdit();
            prodasha_ribyTableAdapter.Update(рыбный_магазинDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            DataGridView dataGridView = null;

            if (dataGridView1.Visible)
            {
                dataGridView = dataGridView1;
            }
            else if (dataGridView2.Visible)
            {
                dataGridView = dataGridView2;
            }

            Bitmap bitmap = new Bitmap(dataGridView.Width, dataGridView.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(1, 1, dataGridView.Width, dataGridView.Height));

            e.Graphics.DrawImage(bitmap, e.PageBounds);
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Файлы Word (*.doc; *.docx)|*.doc?";
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    // Экспорт в Word
                    string fn = "C:\\Users\\Admin\\Desktop\\Карточка рыб.docx";
                    int r = dataGridView2.CurrentCell.RowIndex;
                    var id_prodaji = dataGridView2.Rows[r].Cells[1].FormattedValue.ToString();
                    var Cena_riby = dataGridView2.Rows[r].Cells[2].FormattedValue.ToString();
                    var Nazvanie_Magazina = dataGridView2.Rows[r].Cells[3].FormattedValue.ToString();
                    var Name = dataGridView2.Rows[r].Cells[4].FormattedValue.ToString();
                    Word.Application wordApp = new Word.Application();
                    wordApp.Visible = false;
                    Word.Document wordDocument = wordApp.Documents.Open(fn);
                    ReplaceWordStub("{id_prodaji}", id_prodaji, wordDocument);
                    ReplaceWordStub("{Cena_riby}", Cena_riby, wordDocument);
                    ReplaceWordStub("{Nazvanie_Magazina}", Nazvanie_Magazina, wordDocument);
                    ReplaceWordStub("{Name}", Name, wordDocument);
                    wordDocument.SaveAs2(sd.FileName);
                    wordApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Файлы Excel (*.xls; *.xlsx)|*.xls?";

            if (sd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Add();
                    Excel.Worksheet worksheet = workbook.ActiveSheet;

                    // Добавление заголовков столбцов
                    for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }

                    // Добавление данных таблицы
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value?.ToString() ?? "";
                        }
                    }

                    // Автоматическая подгонка ширины столбцов
                    Excel.Range usedRange = worksheet.UsedRange;
                    usedRange.Columns.AutoFit();

                    excelApp.AlertBeforeOverwriting = false;
                    excelApp.DisplayAlerts = false;
                    workbook.SaveAs(sd.FileName);
                    excelApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}

