using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_interface.Data.Interfaces;
using Web_interface.Data.Models;

namespace Web_interface.Data.Repository
{
    public class RegisterRepository : IAllRegister
    {
        private readonly AppDbContent appDBContent;

        //private readonly Register Register;

        public RegisterRepository(AppDbContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public void CreateRegister(Register Register)
        {
            appDBContent.Register.Add(Register);
            appDBContent.SaveChanges();
        }

        public IEnumerable<Register> RegisterList => appDBContent.Register;
    }
}
