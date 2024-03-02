using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ShtokerVN.Sprint7.V2.Lib;


namespace Tyuiu.ShtokerVN.Sprint7.V2
{
    public partial class FormMain_SHVN : Form
    {
        public FormMain_SHVN()
        {
            InitializeComponent();
            DataTable dataTable = new DataTable();
        }

        private void buttonDone_SHVN_Click(object sender, EventArgs e)
        {

            string num = textBoxNumShop_SHVN.Text;
            string fio = textBoxFIO_SHVN.Text;
            string address = textBoxAdress_SHVN.Text;
            string phone = textBoxNumberPhone_SHVN.Text;
            string cash = textBoxCash_SHVN.Text;


            if (string.IsNullOrEmpty(num) || string.IsNullOrEmpty(fio) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(cash))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridViewRes_SHVN.Rows.Add(num, fio, address, phone, cash);

            ClearTextBoxes();
            UpdateChart();
        }

        private void buttonOpenFile_SHVN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.Title = "Open CSV File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadCsvToDataGridView(openFileDialog.FileName);
            }
        }

        private void buttonSaveAs_SHVN_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.Title = "Save CSV File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveToCsv(dataGridViewRes_SHVN, saveFileDialog.FileName);
            }
        }

        private void buttonSearch_SHVN_Click(object sender, EventArgs e)
        {
            ClearCellFormatting();

            string searchText = textBoxSearch_SHVN.Text.ToLower();


            foreach (DataGridViewRow row in dataGridViewRes_SHVN.Rows)
            {

                foreach (DataGridViewCell cell in row.Cells)
                {

                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {

                        cell.Style.BackColor = Color.Yellow;
                    }
                }
            }
        }

        private void buttonInfo_SHVN_Click(object sender, EventArgs e)
        {
            FormAbout_SHVN about = new FormAbout_SHVN();
            about.ShowDialog();
        }

        private void UpdateChart()
        {
            // Получаем данные из колонны "Выручка" в виде массива
            var revenueData = dataGridViewRes_SHVN.Rows
                .Cast<DataGridViewRow>()
                .Select(row => Convert.ToDouble(row.Cells["Выручка"].Value))
                .ToArray();

            // Очищаем существующие точки на графике
            chartRes_SHVN.Series["Series1"].Points.Clear();

            // Добавляем новые точки на график
            for (int i = 0; i < revenueData.Length; i++)
            {
                chartRes_SHVN.Series["Series1"].Points.AddY(revenueData[i]);
            }
        }

        private void ClearTextBoxes()
        {
            textBoxNumShop_SHVN.Clear();
            textBoxFIO_SHVN.Clear();
            textBoxAdress_SHVN.Clear();
            textBoxNumberPhone_SHVN.Clear();
            textBoxCash_SHVN.Clear();
        }

        private void SaveToCsv(DataGridView dataGridView, string filePath)
        {
            try
            {
                int columnsCount = dataGridView.Columns.Count;

                // Используем Encoding.GetEncoding("windows-1251") для указания кодировки
                using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.GetEncoding("windows-1251")))
                {
                    // Записываем заголовки столбцов
                    for (int i = 0; i < columnsCount; i++)
                    {
                        sw.Write(dataGridView.Columns[i].HeaderText);
                        if (i < columnsCount - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();

                    // Записываем данные
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        for (int i = 0; i < columnsCount; i++)
                        {
                            sw.Write(row.Cells[i].Value);
                            if (i < columnsCount - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();
                    }
                }
                MessageBox.Show("Таблица успешно сохранена в файл CSV.", "Сохранение завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCsvToDataGridView(string filePath)
        {
            try
            {
                dataGridViewRes_SHVN.Rows.Clear();
                dataGridViewRes_SHVN.Columns.Clear();
                DataTable dataTable = new DataTable();

                // Используем Encoding.GetEncoding("windows-1251") для указания кодировки
                using (StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("windows-1251")))
                {
                    // Читаем заголовки столбцов
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    // Читаем данные
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dataRow[i] = rows[i];
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }

                dataGridViewRes_SHVN.DataSource = dataTable;

                MessageBox.Show("Данные успешно загружены из файла CSV.", "Загрузка завершена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void ClearCellFormatting()
        {
            foreach (DataGridViewRow row in dataGridViewRes_SHVN.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = dataGridViewRes_SHVN.DefaultCellStyle.BackColor;
                }
            }
        }
    }
}
