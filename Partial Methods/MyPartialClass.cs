using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Methods
{
    partial class MyPartialClass
    {
        partial void M();// it should return void
        static partial void N();//Partial methods are implicitly private
    }
}
