using Business;
using Data;
using Data.Model;
using NUnit.Framework;
using System.Diagnostics;
/// <summary>
/// Пространство с имена наречено Tests.
/// </summary>
namespace Tests
{
    /// <summary>
    /// Публичен клас с NUnit тестове за пространството MarksBusiness.
    /// </summary>
    public class MarksBusinessTests
    {
        private Context context;
        private MarksBusiness marksBusiness;

        /// <summary>
        /// Задаване на контекст и studentBusiness
        /// </summary>
        [SetUp]
        public void Setup()
        {
            context = new Context();
            marksBusiness = new MarksBusiness();
        }

        /// <summary>
        /// Тест проверяващ дали методът GetAllMarks от MarksBusiness работи.
        /// </summary>
        [Test]
        public void GetAllMarksTesting()
        {

        }

        /// <summary>
        /// Тест проверяващ дали методът GetMark от MarksBusiness работи.
        /// </summary>
        [Test]
        public void GetMarkTesting()
        {
            var newMark = new Mark { Stud = "Katerina Slavova", Grade = 11, Subject = "Math", Teacher = "Tanq Zlateva", Date = DateTime.Now };

            context.Add(newMark);
            var searchMark = context.Marks.OrderByDescending(x => x.Id).First();

        }

        /// <summary>
        /// Тест проверяващ дали методът AddMark от MarksBusiness работи.
        /// </summary>


        /// <summary>
        /// Тест проверяващ дали методът UpdateMark от MarksBusiness работи.
        /// </summary>

       
            [Test]
            public void UpdateStudent()
            {

                var stud = new Mark { Grade = 6, Id = 0, Subject = "IT", Stud = "Iviyan", Date = DateTime.Now, Teacher = "T.Ivanova", };
                context.Marks.Add(stud);
                context.SaveChanges();
                var changeOutput = context.Marks.OrderBy(c => c.Id).First();
                var expectedOutput = new Mark { Id = 0, Stud = "Iviyan", Grade = 6, Subject = "IT", Teacher = "T.Ivanova", Date = DateTime.Now };

                marksBusiness.UpdateMark(expectedOutput);
                context.Dispose();
                context = new Context();
                var output = context.Marks.Find(stud.Id);



                Assert.AreEqual(expectedOutput, output);
                
            }

        /// <summary>
        /// Тест проверяващ дали методът DeleteMark от MarksBusiness работи.
        /// </summary>

            [Test]
        public void DeleteStudent()
        {
            var stud = new Mark { Id = 0, Stud = "Iviyan", Grade = 6, Subject = "IT", Teacher = "T.Ivanova", Date = DateTime.Now };
            context.Marks.Add(stud);
            context.SaveChanges();

            marksBusiness.DeleteMark(stud.Id);
            context.Dispose();
            context = new Context();
            var actualCar = context.Students.Find(stud.Id);

            Assert.IsNull(actualCar);
            context.SaveChanges();
        }
    }
}