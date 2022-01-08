using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using Biblioteca_MobileApp.Models;

namespace Biblioteca_MobileApp.Data
{
    public class BookDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public BookDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Book>().Wait();
            _database.CreateTableAsync<BookCategory>().Wait();
            _database.CreateTableAsync<BorrowedBook>().Wait();
            _database.CreateTableAsync<Category>().Wait();
            _database.CreateTableAsync<Person>().Wait();
            _database.CreateTableAsync<Publisher>().Wait();

        }
        public Task<List<Book>> GetBookAsync()
        {
            return _database.Table<Book>().ToListAsync();
        }
        public Task<Book> GetBookAsync(int id)
        {
            return _database.Table<Book>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveBookAsync(Book slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteBookAsync(Book slist)
        {
            return _database.DeleteAsync(slist);
        }
        public Task<List<BookCategory>> GetBookCategoryAsync()
        {
            return _database.Table<BookCategory>().ToListAsync();
        }
        public Task<BookCategory> GetBookCategoryAsync(int id)
        {
            return _database.Table<BookCategory>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveBookCategoryAsync(BookCategory slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteBookCategoryAsync(BookCategory slist)
        {
            return _database.DeleteAsync(slist);
        }

        public Task<List<BorrowedBook>> GetBorrowedBookAsync()
        {
            return _database.Table<BorrowedBook>().ToListAsync();
        }
        public Task<BorrowedBook> GetBorrowedBookAsync(int id)
        {
            return _database.Table<BorrowedBook>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveBorrowedBookAsync(BorrowedBook slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteBorrowedBookAsync(BorrowedBook slist)
        {
            return _database.DeleteAsync(slist);
        }
        public Task<List<Category>> GetCategoryAsync()
        {
            return _database.Table<Category>().ToListAsync();
        }
        public Task<Category> GetCategoryAsync(int id)
        {
            return _database.Table<Category>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveCategoryAsync(Category slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteCategoryAsync(Category slist)
        {
            return _database.DeleteAsync(slist);
        }
        public Task<List<Person>> GetPersonAsync()
        {
            return _database.Table<Person>().ToListAsync();
        }
        public Task<Person> GetPersonAsync(int id)
        {
            return _database.Table<Person>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SavePersonAsync(Person slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeletePersonAsync(Person slist)
        {
            return _database.DeleteAsync(slist);
        }
        public Task<List<Publisher>> GetPublisherAsync()
        {
            return _database.Table<Publisher>().ToListAsync();
        }
        public Task<Publisher> GetPublisherAsync(int id)
        {
            return _database.Table<Publisher>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SavePublisherAsync(Publisher slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeletePublisherAsync(Publisher slist)
        {
            return _database.DeleteAsync(slist);
        }
    }
}
