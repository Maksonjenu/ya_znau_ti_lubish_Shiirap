using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ribka
{
    public class classi
    {
        public class Cells
        {
            private bool v1;
            private bool v2;

            public Cells(bool v1, bool v2)
            {
                this.v1 = v1;
                this.v2 = v2;
            }

            public bool isfood { get; set; }
            public bool isplace { get; set; }
            
        }


       


        public class Fish
        {
            Random nemayor = new Random();
            public bool sex { get; set; } // true = maneeeee ; false = deffka
            public int satiety { get; set; } // from -10 to 10
            public int age { get; set; } // from 0 to hz yet 
            public bool pregnant { get; set; } // true false 

            public int[] movement(int x, int y)
            {
                int x_ = nemayor.Next(2);   //   1 = right ; 2 = left
                int y_ = nemayor.Next(2);   //   1 = up ; down
                switch(x_)
                {
                    case 1:
                        {
                            x++;
                            break;
                        }
                    case 2:
                        {
                            x--;
                            break;
                        }
                }
                switch(y_)
                {
                    case 1:
                        {
                            y += 10;
                            break;
                        }
                    case 2:
                        {
                            y -= 10;
                            break;
                        }
                }
                int[] _x_y = new int[2];
                _x_y[0] = x_;
                _x_y[1] = y_;
                return (_x_y);

            }
            public int[] scan(int x, int y)
            {
                int[] _x_y = new int[2];
                return (_x_y);
            }
            public bool make_bebe(Fish first, Fish second)
            {
                return true;
            }


        }
    }
}
