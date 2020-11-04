﻿using System;
namespace CarLotSimulator
{
    public class Car
    {
        //Car shall have the following properties:
        //Year, Make, Model, EngineNoise, HonkNoise, IsDriveable -DONE
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public Car()
        {
            
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make; 
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveAble = isDriveable;


        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveAble { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }
        public void MakeHonkNoise(string makeHonkNoise)
        {
            Console.WriteLine(makeHonkNoise);
        }
    }
}
