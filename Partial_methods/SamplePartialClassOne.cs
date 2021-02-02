using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_methods
{
    public partial class SamplePartialClass
    {
        partial void SampalepartialMathod();

        public void SampleMethod()
        {
            Console.WriteLine("Public Method Involk");
            SampalepartialMathod();
        }
        
    }
}
