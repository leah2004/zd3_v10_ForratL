using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd3
{
    public partial class Form1 : Form
    {
        private List<MinistryOfEducation> ministries = new List<MinistryOfEducation>();
        private Dictionary<int, MinistryOfEducation> ministryDictionary = new Dictionary<int, MinistryOfEducation>();
        private int ministryIdCounter = 0; // Счетчик для уникальных идентификаторов министерств
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCollegeName.Text) &&
                    !string.IsNullOrEmpty(txtAverageGrade.Text) &&
                    comboBoxRegion.SelectedItem != null && // Проверка на выбранный регион
                    numericUpDownYear.Value > 0 && // Проверка на положительное значение года
                    !string.IsNullOrEmpty(txtStudentCount.Text)) // Проверка на заполненность текстового поля для студентов
                {
                    string collegeName = txtCollegeName.Text;
                    double averageGrade = double.Parse(txtAverageGrade.Text);
                    string region = comboBoxRegion.SelectedItem.ToString(); // Получаем выбранный регион
                    int year = (int)numericUpDownYear.Value; // Получаем значение года
                    int studentCount = int.Parse(txtStudentCount.Text); // Получаем количество студентов из текстового поля

                    // Проверка на неотрицательное количество студентов
                    if (studentCount < 0)
                    {
                        MessageBox.Show("Количество студентов не может быть отрицательным.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Проверка на существование колледжа с таким же именем и регионом в ListBox (независимо от регистра)
                    foreach (var item in listBoxData.Items)
                    {
                        // Разделяем строку на части для получения имени колледжа и региона
                        string[] parts = item.ToString().Split(new[] { ", " }, StringSplitOptions.None);
                        if (parts.Length > 2)
                        {
                            string existingCollegeName = parts[0].Substring("Колледж: ".Length).Trim();
                            string existingRegion = parts[2].Substring("Регион: ".Length).Trim();

                            if (existingCollegeName.Equals(collegeName, StringComparison.OrdinalIgnoreCase) &&
                                existingRegion.Equals(region, StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show("В этом регионе уже есть такой колледж", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // Создаем новое министерство
                    var ministry = new EnhancedMinistry(region, 0, new List<double>(), region, year, studentCount);
                    ministries.Add(ministry);
                    ministryDictionary.Add(ministryIdCounter++, ministry); // Добавляем в словарь с уникальным идентификатором

                    var existingMinistry = ministries[0];
                    existingMinistry.AddCollege(averageGrade, collegeName, studentCount); // Добавляем колледж с именем, средней оценкой и количеством студентов
                    listBoxData.Items.Add($"Колледж: {collegeName}, Ср.балл: {averageGrade}, Регион: {region}, Год: {year}, Студентов: {studentCount}");

                    // Очищаем текстовые поля
                    txtCollegeName.Clear();
                    txtAverageGrade.Clear();
                    txtStudentCount.Clear();
                }
                else
                {
                    MessageBox.Show($"Заполните все поля корректно!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения для средней оценки или количества студентов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       /* private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxData.SelectedIndex != -1)
            {
                listBoxData.Items.RemoveAt(listBoxData.SelectedIndex);
            }
        }*/

       //кнопка для удаления колледжа из списка и коллекци
        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (listBoxData.SelectedIndex != -1)
            {
                // Получаем индекс выбранного колледжа
                int selectedIndex = listBoxData.SelectedIndex;

                // Удаляем колледж из ListBox
                listBoxData.Items.RemoveAt(selectedIndex);

                // Удаляем колледж из списка ministries
                if (ministries.Count > 0)
                {
                    var ministry = ministries[0];

                    // Проверяем, что индекс не выходит за пределы
                    if (selectedIndex < ministry.averageGrades.Count)
                    {
                        // Удаляем колледж из averageGrades
                        ministry.averageGrades.RemoveAt(selectedIndex);
                        ministry.collegeCount--; // Уменьшаем количество колледжей
                    }
                }

                // Удаляем министерство из словаря, если оно пустое
                if (ministries.Count > 0 && ministries[0].averageGrades.Count == 0)
                {
                    ministryDictionary.Remove(0); // Удаляем министерство с ID 0, если оно пустое
                    ministries.RemoveAt(0); // Удаляем министерство из списка
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите колледж для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //кнопка для посчета качества
        private void btnCalculateQuality_Click(object sender, EventArgs e)
        {
            if (ministries.Count > 0)
            {
                var ministry = ministries[0];
                double quality = ministry.CalculateQuality();
                MessageBox.Show($"Качество колледжей Q = {quality:F2}", "Качество колледжей", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Нет добавленных колледжей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            

        }
        // кнопка для выхода из программы
        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите выйти из программы", "Подтверждение", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void удлитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Location = new Point(12, 59);
            panel3.Visible = false;
            panel4.Visible = false;
        }
         
        private void btnSetCollegeCount_Click(object sender, EventArgs e)
        {
           /* try
            {
                int collegeCount = int.Parse(txtCollegeCount.Text);
          
                MessageBox.Show($"Количество колледжей установлено: {collegeCount}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void кToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel3.Location = new Point(12, 59);
            panel4.Visible = false;

        }

        private void btnCalculateSingleQuality_Click(object sender, EventArgs e)
        {
            if (listBoxData.SelectedIndex != -1)
            {
                // Получаем индекс выбранного колледжа
                int selectedIndex = listBoxData.SelectedIndex;

                // Проверяем, что министерство существует
                if (ministries.Count > 0)
                {
                    var ministry = ministries[0];

                    // Проверяем, что индекс не выходит за пределы
                    if (selectedIndex < ministry.averageGrades.Count)
                    {
                        double singleQuality = ministry.averageGrades[selectedIndex]; // Получаем среднюю оценку для выбранного колледжа
                        MessageBox.Show($"Качество колледжа: {singleQuality:F2}", "Качество колледжа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Выбранный колледж не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Нет добавленных колледжей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите колледж из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // кнопка для отображения колледжей с качеством 5
        private void button1_Click(object sender, EventArgs e)
        {
            if (ministries.Count > 0)
            {
                var enhancedMinistry = ministries[0] as EnhancedMinistry;
                enhancedMinistry?.ShowCollegesWithQuality5(); 
            }
            else
            {
                MessageBox.Show("Нет данных о колледжах.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void lINQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel4.Visible = true;
            panel4.Location = new Point(12, 59);
            panel3.Visible = false;
        }
    }
}
