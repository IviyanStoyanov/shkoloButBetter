namespace Business
{
    /// <summary>
    /// ProducBusiness
    /// </summary>
    public class Business
    {
        private Context context { get; set; }

        /// <summary>
        /// Get all marks from the database
        /// </summary>
        public List<Mark> GetAllMark()
        {
            using (context = new Context())
            {
                return context.Marks.ToList();
            }
        }

        /// <summary>
        /// Get single mark from the database by Id
        /// </summary>
        public Context Get(int id)
        {
            using (context = new Context())
            {
                return context.Mark.Find(id);
            }
        }

        /// <summary>
        /// Add a mark to the database
        /// </summary>
        public void Add(Mark mark)
        {
            using (context = new Context())
            {
                context.Mark.Add(product);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Update a single mark in the database by Id.
        /// </summary>
        public void Update(Mark mark)
        {
            using (context = new Context())
            {
                var item = context.Mark.Find(mark.Id);
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
        public void Delete(int id)
        {
            using (context = new Context())
            {
                var mark = context.Mark.Find(id);
                if (mark != null)
                {
                    context.Mark.Remove(mark);
                    context.SaveChanges();
                }
            }
        }
    }
}