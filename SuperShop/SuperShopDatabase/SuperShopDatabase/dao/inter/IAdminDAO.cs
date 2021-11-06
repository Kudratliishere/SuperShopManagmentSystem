﻿using SuperShopDatabase.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDatabase.dao.inter
{
    interface IAdminDAO
    {
        Admin GetAdminById (int id);
        Admin GetAdminByEmail (string email);
        Admin GetAdminByPhone (string phone);
        Admin AddAdmin (Admin admin);
        Admin UpdateAdmin (Admin admin);
        Admin RemoveAdmin (Admin admin);
    }
}
