using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korhatar
{
    internal interface ILegalAge
    {
        int AgeLimit { get; }

        int Penalty(int age);
    }
}
