using RepositoryDesignPattern.Entities;
using RepositoryDesignPattern.Interfaces;
using System.Collections.Generic;

namespace RepositoryDesignPattern.Repositories.Interfaces
{
    public interface IBookRepository
    {
        List<Book> Get();
        Book Get(int ID);
        void Update(int id, IBook book);
        void Create(IBook book);
    }
}
