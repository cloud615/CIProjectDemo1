using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIProjectDemo1
{
    public class Main
    {
        public int PrintNumberSquare(int num)
        {
            return num*num;
        }

        public string PrintString(string str)
        {
            return string.Format("现在输出的内容是：{0}", str);
        }
    }
}
