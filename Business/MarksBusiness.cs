using Data;
using Data.Model;

/// <summary>
/// Пространство с имена наречено Business.
/// </summary>
namespace Business
{
    /// <summary>
    /// Клас MarksBusiness.
    /// </summary>
    public class MarksBusiness
    {
        private Context context { get; set; }

        /// <summary>
        /// Взима всички оценки от базата данни.
        /// </summary>
        public List<Mark> GetAllMarks()
        {
            using (context = new Context())
            {
                return context.Marks.ToList();
            }
        }

        /// <summary>
        /// Взема оценка от базата данни по номер на ученика.
        /// </summary>
        public Mark GetMark(int id)
        {
            using (context = new Context())
            {
                return context.Marks.Find(id);
            }
        }

        /// <summary>
        /// Вкарва оценка в базата данни.
        /// </summary>
        public void AddMark(Mark mark)
        {
            using (context = new Context())
            {
                context.Marks.Add(mark);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Променя оценка от базата данни по номер на ученика.
        /// </summary>
        public void UpdateMark(Mark mark)
        {
            using (context = new Context())
            {
                var item = context.Marks.Find(mark.Id);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(mark);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Изтрива оценка от базата данни по номер на ученика.
        /// </summary>
        public void DeleteMark(int id)
        {
            using (context = new Context())
            {
                var mark = context.Marks.Find(id);
                if (mark != null)
                {
                    context.Marks.Remove(mark);
                    context.SaveChanges();
                }
            }
        }
    }
    

}