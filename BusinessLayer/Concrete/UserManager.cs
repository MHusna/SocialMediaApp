﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal userDal;
        public UserManager(IUserDal userDal)
        {
            this.userDal = userDal;
        }
        public void userDelete(User user)
        {
            userDal.delete(user);
        }

        public User userGetById(int id)
        {
            return userDal.get(x => x.UserId == id);
        }

        public User userGetByName(string name)
        {
            return userDal.get(x=>x.NickName == name);
        }

        public void userInsert(User user)
        {
            userDal.insert(user);
        }

        public List<User> userList()
        {
            return userDal.list();
        }

        public void userUpdate(User user)
        {
            userDal.update(user);
        }
    }
}
