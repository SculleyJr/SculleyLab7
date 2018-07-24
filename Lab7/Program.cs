using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, email, phoneNumber, date;

            Regex patternName = new Regex(@"^[A-Z][a-zA-z]{0,30}[\s][a-zA-Z]{0,30}$");
            Regex patternEmail = new Regex(@"^([\w\.\-]{5,30})@([\w\-]{5,10})((\.(\w){2,3})+)$");
            Regex patternPhone = new Regex(@"^([\d]{3})-([\d]{3})-([\d]{4})$");
            Regex patternDate = new Regex(@"^([\d]{2})/([\d]{2})/([\d]{4})$");
            bool isValid, isValidEmail, isValidPhone, isValidDate;

            Console.WriteLine("Enter a Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Email");
            email = Console.ReadLine();
            Console.WriteLine("Enter Phone number");
            phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter date");
            date = Console.ReadLine();

            GetIsValidName(name);
            GetIsValidEmail(email);
            GetIsValidPhone(phoneNumber);
            GetIsValidDate(date);

            bool GetIsValidName(string x)
            {

                if (patternName.Match(x).Success)
                {
                    Console.WriteLine("Name is Valid");
                    isValid = true;
                    return isValid;
                }
                else
                {
                    Console.WriteLine("Name is not Valid");
                    isValid = false;
                    return isValid;
                }
            }
            bool GetIsValidEmail(string y)
            {

                if (patternEmail.Match(y).Success)
                {
                    Console.WriteLine("Email is valid");
                    isValidEmail = true;
                    return isValidEmail;
                }
                else
                {
                    Console.WriteLine("Email is not valid");
                    isValidEmail = false;
                    return isValidEmail;
                }

            }
            bool GetIsValidPhone(string z)
            {

                if (patternPhone.Match(z).Success)
                {
                    Console.WriteLine("Phone is valid");
                    isValidPhone = true;
                    return isValidPhone;
                }
                else
                {
                    Console.WriteLine("Phone is not valid");
                    isValidPhone = false;
                    return isValidPhone;
                }
            }
            bool GetIsValidDate(string a)
            {

                if (patternDate.Match(a).Success)
                {
                    Console.WriteLine("Date is valid");
                    isValidDate = true;
                    return isValidDate;
                }
                else
                {
                    Console.WriteLine("Date is not valid");
                    isValidDate = false;
                    return isValidDate;
                }

            }

        }

    }








}
