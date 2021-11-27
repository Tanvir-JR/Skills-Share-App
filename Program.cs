using System;

namespace Skills_Share
{
    class System
    {
        private const int V = 5000;
        private string name= null;
        private string dateofbirth = null;
        private string country = null;
        private string email = null;
        private bool password = true;
        private int amount = 0;
        private int userId = 0;
        
        public bool getProfile_access_permission()
        {
            return true;
        }       
        public void setProfile_access_permission(string email,  bool password)
        {
            
            this.email = email;
            this.password = password;      
        }
        public int getValidation_payment()
        {
            return amount;
        }
        public void setValidation_payment (int amount)
        {
            this.amount = amount;
        }    
        public System()
        {
        }

        static void Main(string[] args)
        {
            bool email = true;
            bool password = true;
            
            System obj = new System();
            if (obj.getProfile_access_permission()== true)
            {
                Console.WriteLine("Enter Email: ");
                Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                Console.ReadLine();
                Console.WriteLine("...Account Created...");
            }
            else
            {
                Console.WriteLine("Account is not Created.");
               
            }
            int amount = 500;
            System obj1 = new amount1();

            Console.WriteLine("\nYour current payment is: " + amount+ "$");
            
        }


    }
}
