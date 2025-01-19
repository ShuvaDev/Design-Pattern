using Factory_Method;

Car car1 = new NissanFactory().CreateProduct();
Console.WriteLine(car1.Model + " " + car1.Price);

Car car2 = new ToyotaFactory().CreateProduct();
Console.WriteLine(car2.Model + " " + car2.Price);