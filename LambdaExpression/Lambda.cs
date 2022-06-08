using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class Lambda
    {
        public static void ValidateUserEntry(List<Person> listed)
        {
            listed.Add(new Person("Kajal", "Shendage", "shendagekajal@gmail.com", "7208590504", "Kbse@123"));
            listed.Add(new Person("Pihu", "Sone", "sonepihu123@gmail.com", "9954347646", "Pst@124$"));
            listed.Add(new Person("Sonal", "Jadhav", "jadhavsonal45@yahoo.com", "8345985467", "Stjq145!#"));
          
            Console.WriteLine(listed.ToString());

            listed.ForEach(x => Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}\t", x.FirstName.ToString(), x.LastName.ToString(), x.Email.ToString(), x.Mobile.ToString(), x.Password.ToString()));
        }
    }
}
