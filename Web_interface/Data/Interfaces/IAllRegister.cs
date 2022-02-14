using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_interface.Data.Models;

namespace Web_interface.Data.Interfaces
{
    public interface IAllRegister
    {
        void CreateRegister(Register register);

        IEnumerable<Register> RegisterList { get; }       
    }
}
