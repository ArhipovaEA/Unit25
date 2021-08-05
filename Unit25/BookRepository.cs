using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit25
{
    public class BookRepository
    {
        //выбор книги из БД по идентификатору
        public void SelectBookId()
        {
            using (AppContext db = new AppContext())
            {
                db.Books.Select(b => b.Id).FirstOrDefault();
            }
        }

        //выбор всех книг
        public void SelectAllBooks()
        {
            using (AppContext db = new AppContext())
            {
                db.Books.ToList();
            }
        }

        //добавление книги в БД 
        public void AddBook()
        {
            using (AppContext db = new AppContext())
            {
                var books = new Book { Name = "Новаят книга", Year = 2020, Avtor = "Автор", Genre = "Poem" };
                db.Books.Add(books);
                
            }
        }

        //удаление из БД
        public void DeleteBook()
        {
            using (AppContext db = new AppContext())
            {
                var books = new Book { Name = "Новаят книга", Year = 2020, Avtor = "Автор", Genre = "Poem" };
                db.Books.Remove(books);
            }
        }

        //обновление года книги
        public void BookUpdate()
        {
            using (AppContext db = new AppContext())
            {
                var firstBook = db.Books.FirstOrDefault();
                firstBook.Year = 2021;
            }
        }
    }
}
