using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_singltone
{
    internal class Clock
    {



        private static Clock instance;
        private static readonly object Key = new object();


        private Clock()
        {

        }
        public static Clock GetTime()
        {
            if (instance == null)
            {
                lock (Key)
                {
                    if (instance == null)
                    {
                        instance = new Clock();
                    }

                }



            }
            return instance;
        }

        public override string ToString()
        {
            return DateTime.Now.ToString();
        }
    }

}
