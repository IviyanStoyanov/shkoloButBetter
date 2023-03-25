using Business;
using Data;
using Data.Model;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

/// <summary>
/// Пространство с имена наречено Tests.
/// </summary>
namespace Tests
{
    /// <summary>
    /// Публичен клас с NUnit тестове за пространството StudentsBusiness.
    /// </summary>
    public class StudentsBusiness
    {
<<<<<<< Updated upstream
<<<<<<< Updated upstream

=======
=======
>>>>>>> Stashed changes
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
        public void AddStdenttTesting()
        {

        }

        /// <summary>
        /// Тест проверяващ дали методът UpdateMark от StudentsBusiness работи.
        /// </summary>
        [Test]
        public void UpdateMarkTesting()
        {
      
            
        }

        /// <summary>
        /// Тест проверяващ дали методът DeleteStudent от StudentsBusiness работи.
        /// </summary>
        [Test]
        public void DeleteStudentTesting()
        {

        }
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }
}
