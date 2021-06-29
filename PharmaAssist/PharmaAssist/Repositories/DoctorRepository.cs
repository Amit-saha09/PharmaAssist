using PharmaAssist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmaAssist.Repositories
{
    public class DoctorRepository:Repository<Doctor>
    {
        public Doctor Getuserinfo(int id)
        {
            Doctor p = new Doctor();
            p = this.contex.Doctors.Where(x => x.LoginId == id).FirstOrDefault();
            return p;
        }
    }
}