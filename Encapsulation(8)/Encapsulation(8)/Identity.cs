using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_8_
{
    public class Identity
    {
        private  string id;
        bool control=false;
        public string  MyId { 
            get
            {
                return id ;
            }
            set 
            {
                if (value.Length == 11)
                {
                    for(int i=0;i<value.Length;i++)
                    {
                        char IsNumber = value[i];
                        if(char.IsNumber(IsNumber)==false)
                        {
                            Console.WriteLine("Error.There are characters in the ID number");
                            control = false;
                            break;
                        }
                        else
                        {
                            control = true;

                        }
                        
                    }
                    if(control) 
                    { 
                        id = value;
                    }

                }
                else
                {
                    Console.WriteLine("The ID number must consist of 11 numbers");
                }
                
            } 
        }

    }
}
