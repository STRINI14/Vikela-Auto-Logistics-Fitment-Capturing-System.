using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vikela_Auto_Heavy_PPO_Fitment_Capturing_System
{
    internal class ClassUser
    {

        static string? Uname;
        public static string? uname
        {
            get
            {
                return Uname;
            }
            set
            {
                Uname = value;
            }


        }
    }
}
