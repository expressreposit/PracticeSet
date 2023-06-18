﻿using RepositoryDesignPattern.Entities;
using RepositoryDesignPattern.Interfaces;
using RepositoryDesignPattern.Repositories.Interfaces;
using System.Collections.Generic;

namespace RepositoryDesignPattern.Repositories
{
    public class BookRepositoryInMemory : IBookRepository
    {
        public List<Book> Get()
        {
            return new List<Book> { new Book { Name = "Book from In Memory" } };
        }

        public Book Get(int ID)
        {
            return new Book { Name = "Book from SQL In Memory" };
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
