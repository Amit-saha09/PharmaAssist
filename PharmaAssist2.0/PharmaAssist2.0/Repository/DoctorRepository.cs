﻿using PharmaAssist2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmaAssist2._0.Repository
{
    public class DoctorRepository : Repository<Doctor>
    {
        public Doctor Getuserinfo(int id)
        {
            Doctor p = new Doctor();
            p = this.contex.Doctors.Where(x => x.LoginId == id).FirstOrDefault();
            return p;
        }
    }
}