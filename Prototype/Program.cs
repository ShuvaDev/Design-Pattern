using Prototype;

Person person1 = new Person();
person1.Name = "Shuva Dev";
person1.Email = "s.r.shuvadeb@gmail.com";
person1.Address.Street = "Chattogram";

Person person2 = person1.Clone() as Person;
person2.Address.Street = "Dhaka";

Console.WriteLine($"Person 1 : {person1.Address.Street}");
Console.WriteLine($"Person 2 : {person2.Address.Street}");
