using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private Student _student;
        private Teacher _teacher;
        private StrudentPay _studentPay;

        [SetUp]
        public void SetUp()
        {
            _student = new Student();
            _teacher = new Teacher();
            _studentPay = new StrudentPay();
        }

        [Test]
        public void countBirthYear_ReturnsExpectedValue()
        {
            var student = new Student();
            student.Age = 19;
            var result = student.countBirthYear(student.Age);
            Assert.AreEqual(2005, result, "The birth year calculation is incorrect.");
        }

        [Test]
        public void countBirthYearTeacher_InputIs1_ReturnInt()
        {
            var teacher = new Teacher();
            teacher.Age = 45;
            var result = _teacher.countBirthYear(teacher.Age);
            Assert.AreEqual(1979, result, "The birth year calculation is incorrect.");
        }

        [Test]
        public void workExperirnce_InputIs1_ReturnInt()
        {
            var teacher = new Teacher();
            teacher.experirnce = 2020;
            var result = _teacher.workExperirnce(teacher.experirnce);
            Assert.AreEqual(4, result, "This work experience is incorrect.");
        }

        [Test]
        public void whoPay_InputIs1_ReturnInt()
        {
            var studentPay = new StrudentPay();
            var result = studentPay.whoPay(1500000);
            Assert.AreEqual(3000000, result, "This work experience is incorrect.");
        }
    }
}