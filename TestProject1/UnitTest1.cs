using zd3;

namespace TestProject1
{
    public class Tests
    {
        private MinistryOfEducation ministry;
        private EnhancedMinistry enhancedMinistry;
        [SetUp]
        public void Setup()
        {
            ministry = new MinistryOfEducation("Министерство образования", 0, new List<double>(), "Регион", 2000);
            enhancedMinistry = new EnhancedMinistry("Улучшенное министерство", 0, new List<double>(), "Регион", 2000, 1500);
        }

       
        [Test]
        public void CalculateQuality_NoColleges_ReturnsZero()
        {
            // Проверяет, что метод CalculateQuality возвращает 0, если нет колледжей
            double quality = ministry.CalculateQuality();
            Assert.AreEqual(0, quality);
        }

        [Test]
        public void AddCollege_IncreasesCollegeCount()
        {
            // Проверяет, что количество колледжей увеличивается на 1 при добавлении колледжа
            ministry.AddCollege(4.5);
            Assert.AreEqual(1, ministry.collegeCount);
        }

        [Test]
        public void AddCollege_WithName_IncreasesCollegeCount()
        {
            // Проверяет, что количество колледжей увеличивается на 1 при добавлении колледжа с именем
            ministry.AddCollege(4.5, "Колледж 1");
            Assert.AreEqual(1, ministry.collegeCount);
        }

        [Test]
        public void RemoveCollege_ValidIndex_DecreasesCollegeCount()
        {
            // Проверяет, что количество колледжей уменьшается на 1 при удалении колледжа по валидному индексу
            ministry.AddCollege(4.5, "Колледж 1");
            ministry.RemoveCollege(0);
            Assert.AreEqual(0, ministry.collegeCount);
        }

        [Test]
        public void RemoveCollege_InvalidIndex_ReturnsFalse()
        {
            // Проверяет, что метод RemoveCollege возвращает false при попытке удалить колледж по невалидному индексу
            bool result = ministry.RemoveCollege(0);
            Assert.IsFalse(result);
        }
       
      
        [Test]
        public void AddCollege_WithEmptyName_ThrowsArgumentException()
        {
            // Проверяет, что добавление колледжа с пустым именем вызывает исключение
            Assert.Throws<ArgumentException>(() => ministry.AddCollege(4.0, ""));
        }

        [Test]
        public void RemoveCollege_ValidIndex_ReturnsTrue()
        {
            // Проверяет, что метод возвращает true при успешном удалении колледжа по валидному индексу
            ministry.AddCollege(4.5, "Колледж 1");
            bool result = ministry.RemoveCollege(0);
            Assert.IsTrue(result);
        }

        [Test]
        public void RemoveCollege_EmptyList_ReturnsFalse()
        {
            // Проверяет, что метод возвращает false, если список колледжей пуст и попытка удаления не удалась
            bool result = ministry.RemoveCollege(0);
            Assert.IsFalse(result);
        }

        [Test]
        public void CalculateQuality_AfterAddingColleges_ReturnsCorrectAverage()
        {
            // Проверяет, что качество рассчитывается правильно после добавления колледжей
            ministry.AddCollege(4.0, "Колледж 1");
            ministry.AddCollege(5.0, "Колледж 2");
            double quality = ministry.CalculateQuality();
            Assert.AreEqual(4.5, quality, 0.01); // (4.0 + 5.0) / 2
        }

    }
}