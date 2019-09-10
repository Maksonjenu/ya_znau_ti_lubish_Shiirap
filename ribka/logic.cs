using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ribka
{
   public class logic
    {
        classi classi = new classi();
        
        public string hz(bool food)
        {
                    if (food == true)
                        return "h";
                    else return "0";
        }
        Random nemayor = new Random();
        public bool setplant(int x, int y, int chance)
        {
            
            int i = nemayor.Next(1,100);
            if (i < chance)
                return true;
            else return false;
        }
    }
}
