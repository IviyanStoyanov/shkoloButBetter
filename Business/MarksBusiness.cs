using Data;
using Data.Model;

namespace Business
{
    /// <summary>
    /// ProducBusiness
    /// </summary>
    public class MarksBusiness
    {
        private Context context { get; set; }

        /// <summary>
        /// Get all marks from the database
        /// </summary>
        public List<Mark> GetAllMarks()
        {
            using (context = new Context())
            {
                return context.Marks.ToList();
            }
        }

        /// <summary>
        /// Get single mark from the database by Id
        /// </summary>
        public Mark GetMark(int id)
        {
            using (context = new Context())
            {
                return context.Marks.Find(id);
            }
        }

        /// <summary>
        /// Add a mark to the database
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
        /// Update a single mark in the database by Id.
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
        /// Deleate a mark from the database by Id
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