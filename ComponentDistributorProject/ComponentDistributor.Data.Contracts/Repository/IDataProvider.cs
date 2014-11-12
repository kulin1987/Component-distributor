namespace ComponentDistributor.Data.Contracts.Repository
{
    using System;
    using System.Linq;
    using ComponentDistributor.Data.Models;

    public interface IDataProvider
    {
        IRepository<ApplicationUser> Users { get; }

        //IRepository<Book> Books { get; }

        int SaveChanges();
    }
}
