namespace BLL.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        public IProductRepository ProductRepository { get; }

        public ICategoryProductRepository CategoryProductRepository { get; }

        Task CommitAsync();

        Task DisposeAsync();
    }
}
