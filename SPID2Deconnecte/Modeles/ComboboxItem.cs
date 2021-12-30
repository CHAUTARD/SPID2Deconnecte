using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPID2Deconnecte.Modeles
{
    internal class ComboboxItem
    {
        public string Value { get; set; }

        public string Key { get; set; }

        public override string ToString()
        {
            return Value;
        }
    }
}
