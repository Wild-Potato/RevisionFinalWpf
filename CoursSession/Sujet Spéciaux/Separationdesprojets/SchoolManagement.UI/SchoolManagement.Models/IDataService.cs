using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    interface IDataService <T>
    {
        public IEnumerable<T> GetAll();
    }
}
