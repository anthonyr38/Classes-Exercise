namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car carA = new Car();
            carA.Make = "Mitsubishi";
            carA.Model = "Outlander";
            carA.Year = 2022;

            var carB = new Car()
            {
                Make = "Chevrolet",
                Model = "Cruze",
                Year = 2019
            };
        
            
            var carC = new Car("Nissan", "Versa", 2018);

            var listOfCars = new List<Car>();

            listOfCars.Add(carA);
            listOfCars.Add(carB);
            listOfCars.Add(carC);

            foreach(var auto in listOfCars) 
            {
                Console.WriteLine($"{auto.Make} {auto.Model} {auto.Year}");
            }
        }



    }
}
