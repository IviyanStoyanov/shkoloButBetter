using Business;
using Data;
using Data.Model;
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
        /// Тест проверяващ дали методът AddMark от MarksBusiness работи.
        /// </summary>
       
    

        /// <summary>
        /// Тест проверяващ дали методът DeleteMark от MarksBusiness работи.
        /// </summary>
    
    }
}