using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My.Package
{
    public class User
    {
        public string Name { get; set; }

#if !DEBUG
        public int Age { get; set; }
#endif
    }
}
