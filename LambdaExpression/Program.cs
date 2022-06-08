// See https://aka.ms/new-console-template for more information

using LambdaExpression;

UserRegistration patterns = new UserRegistration();
Console.WriteLine(patterns.ValidateFirstName("Piya"));
Console.WriteLine(patterns.ValidateLastName("Sawant"));
Console.WriteLine(patterns.ValidateEmail("Piyaswnat@gmail.com"));
Console.WriteLine(patterns.ValidatePhoneNumber("+91 9924156412"));
Console.WriteLine(patterns.ValidatePassword("Cabbdgeq"));
Console.WriteLine();

Console.WriteLine("To validate the user entry using lambda function");
List<Person> listed = new List<Person>();
Lambda.ValidateUserEntry(listed);

