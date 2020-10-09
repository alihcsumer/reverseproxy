using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReverseProxyApplication
{
    public class EarthmineConfig
    {
        public string EarthmineURL { get; set; }
      

        public override string ToString()
        {
            return $"{EarthmineURL}";
        }
    }
}
