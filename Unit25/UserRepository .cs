using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit25
{
    public class UserRepository
    {
        //выбор пользователя из БД по его идентификатору
        public void SelectUserId()
        {
            using (AppContext db = new AppContext())
            {
                db.Users.Select(u => u.Id).FirstOrDefault();
            }
        }

        //выбор всех пользователей
        public void SelectAllUsers()
        {
            using (AppContext db = new AppContext())
            {
                db.Users.ToList();
            }
        }

        //добавление пользователя в БД 
        public void AddUser()
        {
            using (AppContext db = new AppContext())
            {
                var user = new User { Name = "Ulya", Role = "Admin", Email = "mail3@mail.ru" };
                db.Users.Add(user);
            }
        }

        // удаление из БД
        public void DeleteUser()
        {
            using (AppContext db = new AppContext())
            {
                var user = new User { Name = "Ulya", Role = "Admin", Email = "mail3@mail.ru" };
                db.Users.Remove(user);
            }
        }

        //обновление имени пользователя
        public void UserUpdate()
        {
            using (AppContext db = new AppContext())
            {
                var firstUser = db.Users.FirstOrDefault();
                firstUser.Name = "Ulya";
            }
        }
    }
}
