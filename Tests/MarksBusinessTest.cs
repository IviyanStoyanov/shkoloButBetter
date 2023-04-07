using Business;
using Data;
using Data.Model;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Newtonsoft.Json;

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
            var newMarks = JsonConvert.SerializeObject(context.Marks.OrderBy(x => x.Id));

            var searchMarks = JsonConvert.SerializeObject(marksBusiness.GetAllMarks().OrderBy(x => x.Id));

            CollectionAssert.AreEqual(newMarks, searchMarks);
        }

        /// <summary>
        /// Тест проверяващ дали методът GetMark от MarksBusiness работи.
        /// </summary>
        [Test]
        public void GetMarkTesting()
        {
            var newMark = new Mark
            {
                Stud = "Диан Петров",
                Grade = 6,
                Subject = "Информатика",
                Teacher = "Таня Иванова",
                Date = DateTime.Now
            };
            context.Marks.Add(newMark);
            context.SaveChanges();
           
            var searchMark = marksBusiness.GetMark(newMark.Id);

            Assert.AreNotEqual(newMark,searchMark,"GetMark doesn't return the searched mark.");

        }

        /// <summary>
        /// Тест проверяващ дали методът AddMark от MarksBusiness работи.
        /// </summary>
        [Test]
        public void AddMarkTesting()
        {
            var newMark = new Mark
            {
                Stud = "Диан Петров",
                Grade = 6,
                Subject = "Информатика",
                Teacher = "Таня Иванова",
                Date = DateTime.Now
            };

            marksBusiness.AddMark(newMark);
            var searchMark = context.Marks.OrderByDescending(x => x.Id).First();

            Assert.AreNotEqual(newMark, searchMark, "AddMark doesn't work.");
        }

        /// <summary>
        /// Тест проверяващ дали методът UpdateMark от MarksBusiness работи.
        /// </summary>
        [Test]
        public void UpdateMark()
        {
            var stud = new Mark 
            {
                Stud = "Диан Петров",
                Grade = 6,
                Subject = "Информатика",
                Teacher = "Таня Иванова",
                Date = DateTime.Now
            };
            context.Marks.Add(stud);
            context.SaveChanges();
            var changeOutput = context.Marks.OrderBy(c => c.Id).First();
            var expectedOutput = new Mark 
            {
                Stud = "Диан Петров",
                Grade = 5,
                Subject = "Информатика",
                Teacher = "Таня Иванова",
                Date = DateTime.Now
            };

            marksBusiness.UpdateMark(expectedOutput);
            context.Dispose();
            context = new Context();
            var output = context.Marks.Find(stud.Id);

            Assert.AreNotEqual(expectedOutput, output, "UpdateMark doesn't change the mark.");
        }

        /// <summary>
        /// Тест проверяващ дали методът DeleteMark от MarksBusiness работи.
        /// </summary>

        [Test]
        public void DeleteMark()
        {
            var stud = new Mark 
            { 
                Stud = "Диан Петров", 
                Grade = 6, Subject = "Информатика",
                Teacher = "Таня Иванова",
                Date = DateTime.Now
            };
            context.Marks.Add(stud);
            context.SaveChanges();

            marksBusiness.DeleteMark(stud.Id);
            context.Dispose();
            context = new Context();
            var actualStud = context.Students.Find(stud.Id);

            Assert.IsNull(actualStud);
            context.SaveChanges();
        }

    }
}