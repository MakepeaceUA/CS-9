namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product product = new Product("Laptop", 10000, 50);

            //product.ShowProduct();
            //product.DecreasePrice(1000, 60);
            //product.ShowProduct();

            
            
            
            
            //Kettle kettle = new Kettle("Kettle", "Simple Kettle");
            //Microwave microwave = new Microwave("Microwave", "Simple Microwave");
            //Car car = new Car("Car", "Red Car");
            //Steamer steamship = new Steamer("Steamer", "Big Steamer");

            //Console.WriteLine(kettle.Show());
            //kettle.Sound();
            //Console.WriteLine(kettle.Desc());

            //Console.WriteLine(microwave.Show());
            //microwave.Sound();
            //Console.WriteLine(microwave.Desc());

            //Console.WriteLine(car.Show());
            //car.Sound();
            //Console.WriteLine(car.Desc());

            //Console.WriteLine(steamship.Show());
            //steamship.Sound();
            //Console.WriteLine(steamship.Desc());

            
            
            
            
            
            
            MusicalInstrument violin = new Violin("Violin","DESC");
            MusicalInstrument trombone = new Trombone("Trombone", "DESC");
            MusicalInstrument ukulele = new Ukulele("Ukulele", "DESC");
            MusicalInstrument cello = new Cello("Cello", "DESC");

            Console.WriteLine(violin.Show());
            violin.Sound();
            Console.WriteLine(violin.Desc());
            violin.History();
            Console.WriteLine();

            Console.WriteLine(trombone.Show());
            trombone.Sound();
            Console.WriteLine(trombone.Desc());
            trombone.History();
            Console.WriteLine();

            Console.WriteLine(ukulele.Show());
            ukulele.Sound();
            Console.WriteLine(ukulele.Desc());
            ukulele.History();
            Console.WriteLine();

            Console.WriteLine(cello.Show());
            cello.Sound();
            Console.WriteLine(cello.Desc());
            cello.History();


        }


    }
}
