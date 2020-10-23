using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Berechnung_von_Zahnrädern
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Berechnung der Zahnradgeometrie");
            Console.WriteLine("Geben Sie ihr Modul");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben Sie ihre Zahnzahl ein");
            double z = Convert.ToDouble(Console.ReadLine());
            double ha = m;
            double d = m * z;
            

          


            Console.WriteLine("Geben Sie nur 1, 2, 3 auf ihrer Tastatur ein");
            char eingabe = Convert.ToChar(Console.ReadLine());
           
            switch (eingabe)
            {
                case '1':
                    Console.WriteLine("Zahnfußhöhe mit Standardkopfspiel in mm");

                    Console.WriteLine((m + c) + "mm");

                    Console.WriteLine("Fußkreisdurchmesser mit Standardkopfspiel in mm");

                    Console.WriteLine((m * z) + 2 * (m + c) + "mm");

                    Console.WriteLine("Zahnhöhe mit Standardkopfspiel in mm");
                   
                    Console.WriteLine((2*m+c) + "mm");
                    break;

                case '2':
                    Console.WriteLine("Zahnfußhöhe mit Kopfspiel 0.1 DIN 867 in mm");

                    Console.WriteLine((m + c1) + "mm");

                    Console.WriteLine("Fußkreisdurchmesser mit Kopfspiel 0.1 DIN 867 in mm");

                    Console.WriteLine((m * z) + 2 * (m + c1) + "mm");

                    Console.WriteLine("Zahnhöhe mit Kopfspiel 0.1 DIN 867 in mm");

                    Console.WriteLine((2 * m + c1) + "mm");
                    break;

                case '3':
                    Console.WriteLine("Zahnfußhöhe mit 0.3 DIN 867 in mm");

                    Console.WriteLine((m + c2) + "mm");

                    Console.WriteLine("Fußkreisdurchmesser mit Kopfspiel 0.3 DIN 867 in mm");

                    Console.WriteLine((m * z) + 2 * (m + c2) + "mm");

                    Console.WriteLine("Zahnhöhe mit Kopfspiel 0.3 DIN 867 in mm");

                    Console.WriteLine ((2 * m + c2) + "mm");
                    break;

                


            }

            Console.WriteLine("Teilung der Zähne am Zahnrad in mm");

            Console.WriteLine(Pi * m + "mm");

            Console.WriteLine("Grundkreisdurchmesser des Zahnrades in mm (Rechnung wird mit Wert Normverzahnung berechnet)");

            Console.WriteLine((m * z * cosα) + "mm");

            Console.WriteLine("Zahnkopfhöhe ist das Modul");

            Console.WriteLine(ha +"mm");

            Console.WriteLine("Gewicht in Gramm");
            
            Console.WriteLine("Geben Sie an wie Breit das Zahnrad ist (mm)");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Benutzen Sie 4, 5, 6 auf ihrer Tastatur");
            Console.WriteLine("4=Rechnung mit EN-GJL-200 für das Gewicht in Gramm");
            Console.WriteLine("5=Rechnung mit EN-GJS-350 für das Gewicht in Gramm");
            Console.WriteLine("6=Rechnung mit S235JR für das Gewicht in Gramm");
            

            double A=((d / 2) * (d / 2) * Pi);

            char Gewicht = Convert.ToChar(Console.ReadLine());

            switch (Gewicht)
            {
                case '4':

                    Console.WriteLine(A * b * dGJL + "g");
                    break;
                    
                case '5':
                    Console.WriteLine(A * b * dGJS + "g");
                    break;

                case '6':
                    Console.WriteLine(A * b * S235JR + "g");
                    break;
            }

            Console.WriteLine("Preis in Euro pro Gramm");
            Console.WriteLine("Benutzen Sie 7, 8, 9 auf ihrer Tastatur");
            Console.WriteLine("7= Preis mit EN-GJL-200");
            Console.WriteLine("8= Preis mit EN-GJS-350");
            Console.WriteLine("9= Preis mit S235JR");

            double V = A * b * dGJL;
            double V1 = A * b * dGJS;
            double V2 = A * b * S235JR;

            char Preis = Convert.ToChar(Console.ReadLine());

            switch (Preis)
            {
                case '7':
                    Console.WriteLine(V * dGJL +"Euro");
                    break;

                case '8':
                    Console.WriteLine(V1 * dGJS + "Euro");
                    break;

                case '9':
                    Console.WriteLine(V2 * S235JR + "Euro");
                    break;

            }
            
            



           
            Console.ReadLine();
            
        }
        public const double Pi   = 3.141592654;
        public const double S235JR = 0.00785; // Dichte S235JR 
        public const double dGJL = 7.15/1000; //Dichte EN-GJL-200
        public const double dGJS = 7.1/1000 ; //Dichte EN-GJS-350
        public const double PrS235 = 3.63; // Preis S235JR
        public const double PrdGjl = 0.80; // Preis EN-GJL-200
        public const double PrGjs = 1.10; // Preis EN-GJS-350
        public const double c = 0.167; // Kopfspiel Standard
        public const double c1 = 0.1; // Kopfspiel DIN 867
        public const double c2 = 0.3; // Kopfspiel DIN 867
        public const double cosα = 0.34906585; // Normverzahnung cos20°
        

    }
}
