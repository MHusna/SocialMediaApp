﻿using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        void userInsert(User user);        
        void userDelete(User user);
        void userUpdate(User user);
        List<User> userList();
        User userGetById(int id);
        User userGetByName(string name);           
    }
}
