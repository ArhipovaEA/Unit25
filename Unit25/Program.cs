using System;

namespace Unit25
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppContext())
            {
                // Использование EF
                var user1 = new User { Name = "Arthur", Role = "Admin", Email = "Mail1@mail.ru" };
                var user2 = new User { Name = "Klim", Role = "User", Email = "Mail2@mail.ru" };

                var book1 = new Book { Name = "Морской волк", Year = 2004 , Avtor = "Джек Лондон", Genre = "Poem" };
                var book2 = new Book { Name = "Собрание сочинений", Year = 2010, Avtor = "Иван Бунин", Genre = "Poem" };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();

                book1.User = user1;
                book2.User = user2;

                db.Books.AddRange(book1, book2);
               
                db.SaveChanges();
            }
        }
    }
}
