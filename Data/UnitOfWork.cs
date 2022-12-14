namespace tp4asp.Data
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly UniversityContext context;
        public IStudentRepository Students { get; private set; }

        public UnitOfWork(UniversityContext c)
        {
            this.context = c;
            Students = new StudentRepository(c);
        }
        public bool Complete()
        {
            try
            {
                int result = context.SaveChanges();
                if (result > 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
