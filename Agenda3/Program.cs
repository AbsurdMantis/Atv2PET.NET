using System;
using System.Collections;
using System.Threading;

class Agenda2
{
    struct employee
    {
        public int iD;
        public string eName;
        public string eEmail;
        public char Type;
        public dtObirth Date;
        public cmpltAdress Address;
        public string Phone;
        public string Obs;
        public int bdistance;

    }
    struct dtObirth
    {
        public int Day;
        public int Month;
        public int Year;
    }
    struct cmpltAdress
    {
        public string District;
        public string City;
        public string State;
    }

    static void Main(string[] args)
    {
        int total = 99;
        int ReadInput = 0;
        int cindex = 0;
        ArrayList Contacts = new ArrayList();

        

        static void CreateContact(int total, ArrayList Contacts, int cindex)
        {
            if (total <= 0)
            {
                total++;
                Console.Write("\n\nContact list full, please delete contacts before adding a new one.\n");
                Thread.Sleep(4000);
                Console.Clear();

            }
            else { 
            int dd = 0, mm = 0, yy = 0;
            Console.Write("\n\nInsert contact details ahead:\n");
            Console.Write("-------------------------------------------------------\n");
            
            

            Console.Write("Name of the contact: ");
            string nm = Console.ReadLine();
            Console.Clear();

            Console.Write("Contact type:\n");
            Console.Write("C - Cellphone\n");
            Console.Write("T - Work \n");
            Console.Write("H - Home \n");
            Console.Write("P - Main \n");
            Console.Write("V - Pager \n");
            Console.Write("F - Fax \n");
            Console.Write("R - Home Fax \n");
            Console.Write("O - Other \n");
            char ty = Console.ReadKey().KeyChar;
            Console.Clear();

            Console.Write("Contact email: ");
            string em = Console.ReadLine();
            Console.Clear();

            Console.Write("Phone number: ");
            string ph = Console.ReadLine();
            Console.Clear();

            Console.Write("Input day of the birth : ");
            dd = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Input month of the birth : ");
            mm = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Input year for the birth : ");
            yy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();

            Console.Write("District : ");
            string di = Console.ReadLine();
            Console.Clear();

            Console.Write("City : ");
            string ci = Console.ReadLine();
            Console.Clear();

            Console.Write("State : ");
            string st = Console.ReadLine();
            Console.Clear();

            Console.Write("Obs: ");
            string ob = Console.ReadLine();
            Console.Clear();

            string mtoday = DateTime.Now.ToString("MM");
            string dtoday = DateTime.Now.ToString("dd");
            int month = Convert.ToInt16(mtoday);
            int day = Convert.ToInt16(dtoday);

            int date1 = (month - 1) * 30 + day;
            int date2 = (mm - 1) * 30 + dd;

            int distance = Math.Abs(date1 - date2);


            employee emp = new employee();
            emp.iD = cindex;
            emp.eName = nm;
            emp.Type = ty;
            emp.eEmail = em;
            emp.Phone = ph;
            emp.Date.Day = dd;
            emp.Date.Month = mm;
            emp.Date.Year = yy;
            emp.Address.District = di; 
            emp.Address.City = ci;
            emp.Address.State = st;
            emp.Obs = ob;
            emp.bdistance = distance;
            Contacts.Add(emp);
            }
        }

        static void DeleteContact(int total, ArrayList Contacts)
        {
            foreach (employee Contact in Contacts)
            {
                Console.Write(Contact.iD + " - " + Contact.eName + "\n");
            }
            Console.Write("\n\n Insert the index of which the contact shall be deleted:\n");
            int Delete = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            foreach (employee Contact in Contacts)
            {
                if (Contact.iD == Delete)
                {
                    Contacts.Remove(Contact);
                    break;
                }
            }
        }
        static void LookupFull(ArrayList Contacts)
        {
                Console.Write("\n\n Insert the desired contact's full name:\n");
                string Delete = Console.ReadLine();
                Console.Clear();
                foreach (employee Contact in Contacts)
                {
                    if (Contact.eName == Delete)
                    {
                    Console.Write("Name: " + Contact.eName + "\n\n");
                    Console.Write("Type of contact: " + Contact.Type + "\n\n");
                    Console.Write("Phone number: " + Contact.Phone + "\n\n");
                    Console.Write("Email address: " + Contact.eEmail + "\n\n");
                    Console.Write("Distance until birthday: " + Contact.bdistance + " days.\n\n");
                    break;
                    }
                }



        }
        static void LookupCity(ArrayList Contacts)
        {
            Console.Write("\n\nInsert the city that shall be used as filter:\n");
            string Delete = Console.ReadLine();
            Console.Clear();
            foreach (employee Contact in Contacts)
            {
                if (Contact.Address.City == Delete)
                {
                    Console.Write("Name: " + Contact.eName + "\n\n");
                    Console.Write("Type of contact: " + Contact.Type + "\n\n");
                    Console.Write("Phone number: " + Contact.Phone + "\n\n");
                    Console.Write("Email address: " + Contact.eEmail + "\n\n");
                    Console.Write("Distance until birthday: " + Contact.bdistance + " days.\n\n");

                    break;
                }
            }



        }
        static void LookupType(ArrayList Contacts)
        {
            Console.Write("\n\n Insert the type of contact desired as filter:\n");
            Console.Write("Contact type:\n\n\n");
            Console.Write("C - Cellphone \n\n");
            Console.Write("T - Work \n\n");
            Console.Write("H - Home \n\n");
            Console.Write("P - Main \n\n");
            Console.Write("V - Pager \n\n");
            Console.Write("F - Fax \n\n");
            Console.Write("R - Home Fax \n\n");
            Console.Write("O - Other \n\n");
            char ty = Console.ReadKey().KeyChar;
            Console.Clear();
            foreach (employee Contact in Contacts)
            {
                if (Contact.Type == ty)
                {
                    Console.Write("Name: " + Contact.eName + "\n\n");
                    Console.Write("Type of contact: " + Contact.Type + "\n\n");
                    Console.Write("Phone number: " + Contact.Phone + "\n\n");
                    Console.Write("Email address: " + Contact.eEmail + "\n\n");
                    Console.Write("Distance until birthday: " + Contact.bdistance + " days.\n\n");
                    break;
                }
            }



        }
        static void LookupFirstName(ArrayList Contacts)
        {
            Console.Write("\n\n Insert the contact's first name:\n");
            string Delete = Console.ReadLine();
            Console.Clear();

            foreach (employee Contact in Contacts)
            {
                if (Contact.eName.Contains(Delete))
                {
                    Console.Write("Name: "+Contact.eName + "\n\n");
                    Console.Write("Type of contact: "+Contact.Type + "\n\n");
                    Console.Write("Phone number: "+Contact.Phone + "\n\n");
                    Console.Write("Email address: "+Contact.eEmail + "\n\n");
                    Console.Write("Distance until birthday: "+Contact.bdistance + " days.\n");
                    break;
                }
            }



        }

        while (ReadInput != 7)
        {
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("1 - Search by first name \n");
            Console.WriteLine("2 - Search by full name \n");
            Console.WriteLine("3 - Search by Contact Type \n");
            Console.WriteLine("4 - Search by City \n");
            Console.WriteLine("5 - Insert Contact \n");
            Console.WriteLine("6 - Remove Contact \n");
            Console.WriteLine("7 - Exit");
            ReadInput = int.Parse(Console.ReadLine());
            switch (ReadInput)
            {
                case 1:
                    Console.Clear();
                    LookupFirstName(Contacts);
                    break;
                case 2:
                    Console.Clear();
                    LookupFull(Contacts);
                    break;
                case 3:
                    Console.Clear();
                    LookupType(Contacts);
                    break;
                case 4:
                    Console.Clear();
                    LookupCity(Contacts);
                    break;
                case 5:
                    Console.Clear();
                    total--;
                    cindex++;
                    CreateContact(total, Contacts, cindex);
                    break;
                case 6:
                    Console.Clear();
                    total++;
                    DeleteContact(total, Contacts);
                    break;
                case 7:
                    System.Environment.Exit(0);
                    break;
            }
        }
    }
}