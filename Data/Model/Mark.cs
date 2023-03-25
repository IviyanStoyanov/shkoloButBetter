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
    /// Клас Mark, с атрибути Id, Stud, Grade, Subject, Teacher, Date.
    /// </summary>
    public class Mark
    {
        /// <summary>
        /// Задване на номер на ученика.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Задаване на име на ученика.
        /// </summary>
        [DisplayName("Ученик")]
        public string Stud { get; set; }

        /// <summary>
        /// Задаване на оценки на ученика.
        /// </summary>
        [DisplayName("Оценка")]
        public int Grade { get; set; }

        /// <summary>
        ///  Задаване на учебен предмет.
        /// </summary>
        [DisplayName("Предмет")]
        public string Subject { get; set; }

        /// <summary>
        /// Задаване на име на учител.
        /// </summary>
        [DisplayName("Учител")]
        public string Teacher { get; set; }

        /// <summary>
        /// Задаване на дата на въвеждане на информацията.
        /// </summary>
        [DisplayName("Дата")]
        public DateTime Date { get; set; }
    }
}
