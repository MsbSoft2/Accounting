using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Utility.Convertor
{
   public static class MonyConvertor
    {
        public static string ToRial(this  int value)
        {
            return value.ToString("#,00");
        }
    }
}
