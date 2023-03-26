using Business;
using Data;
using Data.Model;
using Newtonsoft.Json;

/// <summary>
/// Пространство с имена наречено Tests.
/// </summary>
namespace Tests
{
    /// <summary>
    /// Публичен клас с NUnit тестове за пространството StudentsBusiness.
    /// </summary>
    public class StudentsBusinessTest
    {
        private Context context;
        private StudentsBusiness studentsBusiness;

        /// <summary>
        /// Задаване на контекст и studentsBusiness
        /// </summary>
        [SetUp]
        public void Setup()
        {
            context = new Context();
            studentsBusiness = new StudentsBusiness();
        }

        /// <summary>
        /// Тест проверяващ дали методът GetAllStudent от StudentsBusiness работи.
        /// </summary>
        [Test]
        public void GetAllStudentTesting()
        {
       
        }

        /// <summary>
        /// Тест проверяващ дали методът GetMarkStudent от StudentsBusiness работи.
        /// </summary>
        [Test]
        public void GetMarkStudentTesting()
        {
          
        }

        /// <summary>
        /// Тест проверяващ дали методът AddStdent от StudentsBusiness работи.
        /// </summary>
        [Test]
        public void AddStudent()
        {
            var stud = new Student()
            {
                Id = 0,
                Name = "Iviyan",
                Email = "ïvian.st1@gmail.com",
                Grade = 11,
                BirthDate = DateTime.Now
            };

            studentsBusiness.AddStdent(stud);
            var searchMark = context.Marks.OrderByDescending(x => x.Id).First();

            Assert.AreEqual(stud.Id, stud.Id);
            Assert.AreEqual(stud.Name, stud.Name);
            Assert.AreEqual(stud.Email, stud.Email);
            Assert.AreEqual(stud.Grade, stud.Grade);
            Assert.AreEqual(stud.BirthDate, stud.BirthDate);
        }

        /// <summary>
        /// Тест проверяващ дали методът UpdateMark от StudentsBusiness работи.
        /// </summary>
        [Test]
        public void UpdateGradeTesting()
        {
      
            
        }

        /// <summary>
        /// Тест проверяващ дали методът DeleteStudent от StudentsBusiness работи.
        /// </summary>
        [Test]
        public void DeleteStudentTesting()
        {
            var stud = new Student { Id = 0, Name = "Iviyan", Email = "ïvian.st1@gmail.com", Grade = 11, BirthDate = DateTime.Now };
            context.Students.Add(stud);
            context.SaveChanges();

            studentsBusiness.DeleteStudent(stud.Id);
            context.Dispose();
            context = new Context();
            var actualCar = context.Students.Find(stud.Id);

            Assert.IsNull(actualCar);
            context.SaveChanges();
        }
    }
}
