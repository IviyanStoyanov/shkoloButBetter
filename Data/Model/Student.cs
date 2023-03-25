using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Пространство с имена наречено Data.Model.
/// </summary>
namespace Data.Model
{
    /// <summary>
    /// Клас Student, с атрибути Id, Name, Email, Grade, BirthDate
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Задване на номер на ученика.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Задаване на име на ученика.
        /// </summary>
        [DisplayName("Име на ученика")]
        public string Name { get; set; }

        /// <summary>
        /// Задаване на имейл на ученика.
        /// </summary>
        [DisplayName("Имейл")]
        public string Email { get; set; }

        /// <summary>
        /// Задаване на оценки на ученика.
        /// </summary>
        [DisplayName("Клас")]
        public int Grade { get; set; }


        /// <summary>
        /// Задаване на рожден ден на ученика.
        /// </summary>
        [DisplayName("Дата на раждане")]
        public DateTime BirthDate { get; set; }
    }
}
