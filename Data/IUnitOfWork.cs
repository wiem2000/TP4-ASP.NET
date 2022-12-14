namespace tp4asp.Data
{
    public interface IUnitOfWork:IDisposable
    {
        IStudentRepository Students { get; }
        bool Complete();
    }
}
