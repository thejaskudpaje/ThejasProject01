using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ThejasProject01.Encapsulation
{
    internal class Bank
    {
        /*Private members*/
        private String PrivatePin;
        public String PublicPin
        {
            get { return PrivatePin; }
            set { PrivatePin = value; }
        }
       

        /*public type 01*/
        public string getPrivatePin()
        {
            return PrivatePin;
        }
        public void SetPrivatepi(string valueof)
        {
            PrivatePin = valueof;
        }

        /*public type 02*/
        public String TDOB = "14/10/1996";
        public string ToB
        {
            get { return TDOB; }
            
        }
        
        /*Public type 03*/
        public String Setpin { get; set; }
    }

    class User : Bank
    {
      /*  public static void Main()
        {
            
            User u=new User();
          
            u.PublicPin = "123";
            Console.WriteLine(u.PublicPin);
        }
      */
    }
}
