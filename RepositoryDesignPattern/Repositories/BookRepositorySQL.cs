using RepositoryDesignPattern.Entities;
using RepositoryDesignPattern.Interfaces;
using RepositoryDesignPattern.Repositories.Interfaces;
using System.Collections.Generic;

namespace RepositoryDesignPattern.Repositories
{
    public class BookRepositorySQL : IBookRepository
    {
        public List<Book> Get()
        {
            return new List<Book> { new Book { Name = "Book from SQL" } };
        }

        public Book Get(int ID)
        {
            return new Book { Name = "Book from SQL Memory" };
        }
        public void Create(IBook book)
        {
            throw new System.NotImplementedException();
        }

        

        public void Update(int id, IBook book)
        {
            throw new System.NotImplementedException();
        }
    }
}
