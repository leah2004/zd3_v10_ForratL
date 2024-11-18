using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd3
{
    public class EnhancedMinistry: MinistryOfEducation
    {
        public int studentCount; // P 

        public EnhancedMinistry(string name, int collegeCount, List<double> grades, string region,
       int yearEstablished, int studentCount)
       : base(name, collegeCount, grades, region, yearEstablished)
        {
            this.studentCount = studentCount;
        }

        //подсчет качества
        public override double CalculateQuality()
        {
            double baseQ = base.CalculateQuality();
            return studentCount > 1000 ? baseQ * 0.85 : baseQ * 1.2;
        }

        // Метод для отображения колледжей с качеством 5
        public void ShowCollegesWithQuality5()
        {
            var collegesWithQuality5 = averageGrades
                .Select((grade, index) => new { Grade = grade, Index = index })
                .Where(x => x.Grade == 5)
                .Select(x => $"Номер колледжа в списке: {x.Index + 1} - Средняя оценка: {x.Grade}");

            string message = collegesWithQuality5.Any()
                ? "Колледжи с качеством 5:\n" + string.Join("\n", collegesWithQuality5)
                : "Нет колледжей с качеством 5.";

            MessageBox.Show(message, "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    
    }
}
