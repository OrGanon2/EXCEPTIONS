using System;
using System.Collections.Generic;
using System.Text;

namespace EXCEPTIONS
{
    class Garage : IGarage
    {
        

        public Garage(string[] cartypes,int AmountOfCars)
        {
            Cartypes = cartypes;
            cars = new Car[AmountOfCars];
            
        }
        //public Garage(cars[] cars)
        //{
        //    int Fix = 0;
        //    for (int i = 0; i < cars.Length; i++)
        //    {
        //        if (cars[i].TotalLost == false)
        //        {
        //            CanFixCars[Fix] = cars[i];
        //            Fix++;
        //        }

        //    }
        //}

        public Car[] cars { get; set; }
        public string[] Cartypes { get; set; }

        //public Car[] CanFixCars{  get; set; }

        
      

        public void Addcar(Car car)
        {
            try
                {
                     for (int i = 0; i < cars.Length; i++)
                {
                    if (car == cars[i])
                    {
                        throw new CarAlreadyHereException();
                    }
                    else if (car.TotalLost)
                    {
                        throw new WeDoNotFixTotalLostException();
                    }
                    else if (! car.needsrepair)
                    {
                        throw new RepairMismatchException();
                    }
                    for (int j = 0; j < cars.Length; j++)
                    {
                        if (car.Brand != Cartypes[j])
                        {
                            break;
                            
                        }
                        else if (car.Brand != Cartypes[j] && j == Cartypes.Length-1)
                        {
                            throw new WrongGarageException();
                        }
                    }
                  
                }
                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i] == null)
                    {
                        cars[i] = car;
                        break;
                    }
                }
               

                
                
                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i] == null)
                    {
                        cars[i] = car;
                        break;
                    }
                }
                Console.WriteLine("the car added successfuly");

            }
            catch (CarAlreadyHereException)
            {

                Console.WriteLine("car is already here");
            }
            catch(WeDoNotFixTotalLostException)
            {
                Console.WriteLine("we can't fix total lost cars");
            }
            catch(WrongGarageException)
            {
                Console.WriteLine("car doesnt fit to the brand we fix");
            }
            catch(NullReferenceException )
            {
                Console.WriteLine("there are no cars present");
            }
          
        }

        public void fixCar()
        {
            Console.WriteLine("car is fixed");
        }

        public void takeOutCar()
        {
            Console.WriteLine("take your car away");
        }
        
    }
}
