using System;
using System.Collections.Generic;



namespace CalcAPP
{



    class Calc
    {
        private double cnumb1, cnumb2, result;

        public double Number1
        {
            get { return this.cnumb1; }
            set { this.cnumb1 = cnumb1; }
        }
        public double Number2
        {
            get { return this.cnumb2; }
            set { this.cnumb2 = cnumb2; }
        }

        //double[] arrayNumber1 = new double [] { +1.1 ,- 3.3 , 5 , 7 ,  8.8 };
        List<double> arrayNumber1 = new List<double>() { +1.1, -3.3, 5, 7, 8.8 };//Array changed to List


        int choosing;
        public Calc() { }




        static void Main(string[] args)
        {
            //int choosing;
            bool loop = true;
            Calc calc = new Calc();

            //Console.Clear();
            //PrintMenu();

            //choosing = Option();

            while (loop)
            {

                Console.Clear();
                calc.PrintMenu();
                calc.choosing = calc.Option();


                switch (calc.choosing)
                {
                    case 1:
                        calc.Askuser();
                        //result = Add(getNumber1(), getNumber2());
                        calc.result = calc.Add(calc.Number1, calc.Number2);
                        Console.WriteLine("Addition of   " + calc.Number1 + "and" + calc.Number2 + " is =" + calc.result);
                        break;

                    case 2:
                        calc.Askuser();
                        calc.result = calc.Sub(calc.Number1, calc.Number2);
                        Console.WriteLine("Subtraction  of   " + calc.Number1 + "and" + calc.Number2 + " is =" + calc.result);
                        break;

                    case 3:
                        calc.Askuser();
                        calc.result = calc.Multiply(calc.Number1, calc.Number2);
                        Console.WriteLine("Multiplication   of   " + calc.Number1 + "and" + calc.Number2 + " is =" + calc.result);
                        break;

                    case 4:
                        calc.Askuser();
                        calc.result = calc.Divid(calc.Number1, calc.Number2);
                        Console.WriteLine("division of  " + calc.Number1 + " by " + calc.Number2 + " = " + calc.result);
                        break;
                    case 6:
                        calc.Askuser();
                        calc.result = calc.Add(calc.arrayNumber1);
                        Console.WriteLine("Addition of  summation array =  " + calc.result);
                        break;
                    case 7:
                        calc.Askuser();
                        calc.result = calc.Sub(calc.arrayNumber1);
                        Console.WriteLine("Subtruction  of  summation array = " + calc.result);
                        break;

                    case 5:
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Not a valid option!");
                        break;


                } //end switch

                if (calc.choosing != 5)
                {
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();//WAIT UNTILL PRESS E KEY
                }
            }//end while

        }//end main



        private void PrintMenu()
        {
            Console.WriteLine("----- Menu -----");
            Console.WriteLine("Choose any of number bellow to corrspondet operation");
            Console.WriteLine("  Choose(1) : Add two numbers");
            Console.WriteLine("Choose(2) : Subtract two numbers");
            Console.WriteLine("Choose(3) : Multiply two numbers");
            Console.WriteLine("Choose(4) : Divid two numbers");
            Console.WriteLine("Choose(6) : Addation of array");
            Console.WriteLine("Choose(7) : Subtraction of array");
            Console.WriteLine("Choose(5) : Exit program  ");
        }//end PrintMenu

        private int Option()
        {
            int opt;
            try
            {
                opt = Int32.Parse(Console.ReadLine());
                return opt;
            }
            catch (FormatException e)
            {

                Console.WriteLine("You shoul enter an integer!");

                return 0;
            }
            return opt;
        }//end Option

        private void Askuser()
        {
            try
            {
                if (choosing == 4)
                {
                    Console.WriteLine("Enter Numerator  Number :");
                    //double numerator = Convert.ToDouble(Console.ReadLine());
                    this.cnumb1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter denominator Number :" + "Note  that denominator should not be equal to Zero!");
                    //double denominator = Convert.ToDouble(Console.ReadLine());
                    this.cnumb2 = Convert.ToDouble(Console.ReadLine());
                }

                else if (choosing == 6 || choosing == 7)
                {
                    Console.WriteLine(" Do not any Enter Number :");
                }
                else
                {
                    Console.WriteLine("Enter First Number :");
                    this.cnumb1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Second Number :");
                    this.cnumb2 = Convert.ToDouble(Console.ReadLine());
                }

            }//End try 

            catch (FormatException e)
            {
                Console.WriteLine("You should type a number!");

            }


        }//End Ask user

        private double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        private double Add(List<double> n1)//Add overloaded
        {


            double tot = 0;
            for (int i = 0; i < n1.Count; i++)
                tot += n1[i];

            return tot;
        }

        private double Sub(double n1, double n2)
        {
            return n1 - n2;
        }
        private double Sub(List<double> n1)//Overload Sub
        {
            double tot = 0;
            for (int i = 0; i < n1.Count; i++)
                tot += n1[i];
            double sub = 10 - tot;
            return sub;
        }

        private double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        private double Divid(double n1, double n2)
        {

            //update error exception''
            //Program continue with infinity
            /* try
              {
                return  result = n1 / n2;

              }
              catch (DivideByZeroException exception)
              {
                  throw new ArgumentException("Argument n2 must be non zero.", new DivideByZeroException());


              }*/
            try // Program stop 
            {
                if (n2 == 0)
                    throw new DivideByZeroException();


                return result = n1 / n2;
            }


            catch (DivideByZeroException e)
            {

               
                Console.WriteLine(e.Message);

                throw ;
                

            }

            

        }//end Divid


    }//end class Calc

   



    }// End namespace
