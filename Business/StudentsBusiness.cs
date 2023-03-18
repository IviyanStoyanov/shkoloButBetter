using Data;
using Data.Model;

namespace Business
{
    public class StudentsBusiness
    {
        private Context context { get; set; }

        /// <summary>
        /// Get all students from the database
        /// </summary>
        public List<Student> GetAllStudent()
        {
            using (context = new Context())
            {
                return context.Students.ToList();
            }
        }

        /// <summary>
        /// Get single student from the database by Id
        /// </summary>
        public Student GetMarkStudent(int id)
        {
            using (context = new Context())
            {
                return context.Students.Find(id);
            }
        }

        /// <summary>
        /// Add a student to the database
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
        /// Update a single student in the database by Id.
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
        /// Deleate a student from the database by Id
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