using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nosl_d_edv
{
    public enum Value
    {
        Unknown,
        O,
        X

    }
    public class Symbol
    {
        public string Player { get; set; }

        public Value Value { get; set; }
        public object O { get; internal set; }
    }
}
