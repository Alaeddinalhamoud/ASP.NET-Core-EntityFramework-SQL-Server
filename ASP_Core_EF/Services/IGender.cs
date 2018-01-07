using ASP_Core_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Core_EF.Services
{
   public interface IGender
    {
        IEnumerable<Gender> GetGenders { get; }
        Gender GetGender(int? Id);
        void Add(Gender _Gender);
        void Remove(int? Id);

    }
}
