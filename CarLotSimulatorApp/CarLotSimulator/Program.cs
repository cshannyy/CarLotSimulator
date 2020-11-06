using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Instanciate the a Carlot at the beginning of the program and as
            //you create a car add the car to the list.

            var lot = new CarLot();
            
           

            //Create a seperate class file called Car-Done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property--DONE


            //Now that the Car class is created we can instanciate 3 new cars--DONE

            //setting values to car - Using Dot Notation
            var firstCar = new Car();
            firstCar.Make = "Cadilac";
            firstCar.Model = "Escalade";
            firstCar.Year = 2015;
            firstCar.EngineNoise = "loud";
            firstCar.HonkNoise = "Clown";
            firstCar.IsDriveAble = true;

            lot.Cars.Add(firstCar);


            //Object Initializer Syntax
            var billysBurban = new Car()
            {
                Year = 2007,
                Make = "Chevrolet",
                Model = "Suburban",
                EngineNoise = "erk erk",
                HonkNoise = "boop bop",
                IsDriveAble = false

               

            };

            lot.Cars.Add(billysBurban);

            //using the constructor to allow paramter
            //values to be placed inside propeties

            var brettsTruck = new Car(2016, "Ford", "F150", "loud", "rawr" , true);

            lot.Cars.Add(brettsTruck);
            //Call Methods
            firstCar.MakeEngineNoise(firstCar.EngineNoise);
            billysBurban.MakeEngineNoise(billysBurban.EngineNoise);
            brettsTruck.MakeEngineNoise(brettsTruck.EngineNoise);




            //Set the properties for each of the cars-DONE
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each --DONE

            //*************BONUS X 2*************//

            //Create a CarLot class--DONE
            //It should have at least one property: a List of cars--DONE
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.--DONE

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
