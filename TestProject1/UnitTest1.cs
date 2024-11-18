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
            ministry = new MinistryOfEducation("������������ �����������", 0, new List<double>(), "������", 2000);
            enhancedMinistry = new EnhancedMinistry("���������� ������������", 0, new List<double>(), "������", 2000, 1500);
        }

       
        [Test]
        public void CalculateQuality_NoColleges_ReturnsZero()
        {
            // ���������, ��� ����� CalculateQuality ���������� 0, ���� ��� ���������
            double quality = ministry.CalculateQuality();
            Assert.AreEqual(0, quality);
        }

        [Test]
        public void AddCollege_IncreasesCollegeCount()
        {
            // ���������, ��� ���������� ��������� ������������� �� 1 ��� ���������� ��������
            ministry.AddCollege(4.5);
            Assert.AreEqual(1, ministry.collegeCount);
        }

        [Test]
        public void AddCollege_WithName_IncreasesCollegeCount()
        {
            // ���������, ��� ���������� ��������� ������������� �� 1 ��� ���������� �������� � ������
            ministry.AddCollege(4.5, "������� 1");
            Assert.AreEqual(1, ministry.collegeCount);
        }

        [Test]
        public void RemoveCollege_ValidIndex_DecreasesCollegeCount()
        {
            // ���������, ��� ���������� ��������� ����������� �� 1 ��� �������� �������� �� ��������� �������
            ministry.AddCollege(4.5, "������� 1");
            ministry.RemoveCollege(0);
            Assert.AreEqual(0, ministry.collegeCount);
        }

        [Test]
        public void RemoveCollege_InvalidIndex_ReturnsFalse()
        {
            // ���������, ��� ����� RemoveCollege ���������� false ��� ������� ������� ������� �� ����������� �������
            bool result = ministry.RemoveCollege(0);
            Assert.IsFalse(result);
        }
       
      
        [Test]
        public void AddCollege_WithEmptyName_ThrowsArgumentException()
        {
            // ���������, ��� ���������� �������� � ������ ������ �������� ����������
            Assert.Throws<ArgumentException>(() => ministry.AddCollege(4.0, ""));
        }

        [Test]
        public void RemoveCollege_ValidIndex_ReturnsTrue()
        {
            // ���������, ��� ����� ���������� true ��� �������� �������� �������� �� ��������� �������
            ministry.AddCollege(4.5, "������� 1");
            bool result = ministry.RemoveCollege(0);
            Assert.IsTrue(result);
        }

        [Test]
        public void RemoveCollege_EmptyList_ReturnsFalse()
        {
            // ���������, ��� ����� ���������� false, ���� ������ ��������� ���� � ������� �������� �� �������
            bool result = ministry.RemoveCollege(0);
            Assert.IsFalse(result);
        }

        [Test]
        public void CalculateQuality_AfterAddingColleges_ReturnsCorrectAverage()
        {
            // ���������, ��� �������� �������������� ��������� ����� ���������� ���������
            ministry.AddCollege(4.0, "������� 1");
            ministry.AddCollege(5.0, "������� 2");
            double quality = ministry.CalculateQuality();
            Assert.AreEqual(4.5, quality, 0.01); // (4.0 + 5.0) / 2
        }

    }
}