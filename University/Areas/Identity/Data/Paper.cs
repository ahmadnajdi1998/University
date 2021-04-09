using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace University.Areas.Identity.Data
{
    public class Paper
    {

        public int id { get; set; }
        public int NumberCopies { get; set; }

        public String Content { get; set; }

        public String StudentMail { get; set; }
    }
}
