using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAbstractions.Models
{
    public abstract class AbstractParent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public abstract void Log(string message);
    }
}
