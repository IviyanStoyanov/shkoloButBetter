using Data;
using Data.Model;

/// <summary>
/// Пространство с имена наречено Business.
/// </summary>
namespace Business
{
    /// <summary>
    /// Клас StudentsBusiness.
    /// </summary>
    public class StudentsBusiness
    {
        private Context context { get; set; }

        /// <summary>
        /// Взема всички ученици от базата данни.
        /// </summary>
        public List<Student> GetAllStudent()
        {
            using (context = new Context())
            {
                return context.Students.ToList();
            }
        }

        /// <summary>
        /// Намира ученик по номер.
        /// </summary>
        public Student GetMarkStudent(int id)
        {
            using (context = new Context())
            {
                return context.Students.Find(id);
            }
        }

        /// <summary>
        ///  Добавя ученик в базата данни.
        /// </summary>
        public void AddStdent(Student student)
        {
            using (context = new Context())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Променя информацията за ученик в базата данни по номер.
        /// </summary>
        public void UpdateMark(Student student)
        {
            using (context = new Context())
            {
                var item = context.Students.Find(student.Id);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(student);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Изтрива ученик от базата данни по номер.
        /// </summary>
        public void DeleteStudent(int id)
        {
            using (context = new Context())
            {
                var student = context.Students.Find(id);
                if (student != null)
                {
                    context.Students.Remove(student);
                    context.SaveChanges();
                }
            }
        }

    }

}