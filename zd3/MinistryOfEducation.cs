using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3
{
    public class MinistryOfEducation
    {
        public int collegeCount { get; internal set; }// количество колледжей
        public List<double> averageGrades;//средняя оценка 
        public string region { get; internal set; }//регион
        public int yearEstablished;// год основания
        public string name; //имя колледжа
        public MinistryOfEducation(string name, int collegeCount, List<double> grades, string region, int yearEstablished)
        {
            this.name = name;
            this.collegeCount = collegeCount;
            this.averageGrades = grades;
            this.region = region;
            this.yearEstablished = yearEstablished;       
        }       

        // Метод для расчета качества колледжей
        public virtual double CalculateQuality()
        {
            if (collegeCount == 0) return 0;
            return averageGrades.Sum() / collegeCount;
        }

        // Перегрузка метода CalculateQuality с параметром
        public virtual double CalculateQuality(int year)
        {
            if (year < yearEstablished) return 0; // Если год меньше года основания
            return CalculateQuality(); // Возвращаем общее качество, если год подходит
        }

        // Метод для добавления колледжа с средней оценкой
        public void AddCollege(double averageGrade)
        {
            collegeCount++;
            averageGrades.Add(averageGrade);
        }

        // Перегрузка метода AddCollege с именем колледжа
        public void AddCollege(double averageGrade, string collegeName)
        {
            if (string.IsNullOrWhiteSpace(collegeName))
            {
                throw new ArgumentException("Имя колледжа не может быть пустым.");
            }

            collegeCount++;
            averageGrades.Add(averageGrade);
           
        }

        // Перегрузка метода AddCollege с именем колледжа и количеством студентов
        public void AddCollege(double averageGrade, string collegeName, int studentCount)
        {
            if (string.IsNullOrWhiteSpace(collegeName))
            {
                throw new ArgumentException("Имя колледжа не может быть пустым.");
            }
            if (studentCount < 0)
            {
                throw new ArgumentException("Количество студентов не может быть отрицательным.");
            }

            collegeCount++;
            averageGrades.Add(averageGrade);
      
        }

        // Метод для удаления колледжа по индексу
        public virtual bool RemoveCollege(int index)
        {
            if (index >= 0 && index < averageGrades.Count)
            {
                averageGrades.RemoveAt(index);
                collegeCount--;
                return true;
            }
            return false;
        }


    }
}
