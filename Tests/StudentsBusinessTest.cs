﻿using Business;
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
            var newStudent = JsonConvert.SerializeObject(context.Students.OrderBy(x => x.Id));

            var searchStudent = JsonConvert.SerializeObject(studentsBusiness.GetAllStudent().OrderBy(x => x.Id));

            CollectionAssert.AreEqual(newStudent, searchStudent);
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
        public void AddStudentTesting()
        {
            var stud = new Student()
            {
                Name = "Диан Петров",
                Email = "dianpetrov@gmail.com",
                Grade = 11,
                BirthDate = DateTime.Now
            };

            studentsBusiness.AddStdent(stud);
            var actualStudent = context.Students.OrderByDescending(x => x.Id).First();

            Assert.AreNotEqual(stud, actualStudent, "AddStudent doesn't work.");
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
            var stud = new Student 
            {
                Name = "Диан Петров",
                Email = "dianpetrov@gmail.com", 
                Grade = 11, 
                BirthDate = DateTime.Now 
            };
            context.Students.Add(stud);
            context.SaveChanges();

            studentsBusiness.DeleteStudent(stud.Id);
            context.Dispose();
            context = new Context();
            var actualStud = context.Students.Find(stud.Id);

            Assert.IsNull(actualStud);
            context.SaveChanges();
        }
    }
}
