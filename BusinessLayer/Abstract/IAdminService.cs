﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        void adminInsert(Admin admin);
        void adminDelete(Admin admin);
        void adminUpdate(Admin admin);
        List<Admin> adminList();
        Admin adminGetById(int id);
    }
}
