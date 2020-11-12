using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
        
namespace Berechnung_von_Zahnrädern{
    class Program{
        public const double Pi   = Math.PI;
        public const double S235JR = 0.00785; // Dichte S235JR 
        public const double dGJL = 7.15/1000; //Dichte EN-GJL-200
        public const double dGJS = 7.1/1000 ; //Dichte EN-GJS-350
        public const double PrS235 = 3.63; // Preis S235JR
        public const double PrdGjl = 0.80; // Preis EN-GJL-200
        public const double PrGjs = 1.10; // Preis EN-GJS-350
        public const double c = 0.167; // Kopfspiel Standard
        public const double c1 = 0.1; // Kopfspiel DIN 867
        public const double c2 = 0.3; // Kopfspiel DIN 867
        public static double cosα = Math.Cos(20); // Normverzahnung cos20°
       

        static void Main(string[] args){
            Console.WriteLine("BERECHNUNG DER ZAHNRADGEOMETRIE\n-------------------------------");
            Console.Write("Geben Sie ihr Modul ein:                             ");
            double m = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Geben Sie ihre Zahnzahl ein:                         ");
            double z = Convert.ToDouble(Console.ReadLine());
            double d = m * z;
            Console.Write("Geben Sie an wie Breit das Zahnrad ist in mm:        ");
            double b = Convert.ToDouble(Console.ReadLine());

            double A =Math.Round(d / 2) * (d / 2) * Math.PI;

            int material = 0;
            while (material < 1 || material > 3){
                Console.Write("\nWaehlen Sie das Material\n1: EN-GJL-200\n2: EN-GJS-350\n3: S235JR\nAuswahl: ");
                material = Convert.ToInt16(Console.ReadLine());
                if (material < 1 || material > 3) Console.WriteLine("\nFEHLER: Ungueltige Eingabe");
            }

            int eingabe =  0;
            while (eingabe < 1 || eingabe > 3){
                Console.Write("\nWählen Sie das Kopfspiel\n1: Standardkopfspiel\n2: Kopfspiel 0.1 DIN 867\n3: Kopfspiel 0.3 DIN 867\nAuswahl:");
                eingabe = Convert.ToInt16(Console.ReadLine());
                if (eingabe < 1 || eingabe > 3)     Console.WriteLine("\nFEHLER: Ungueltige Eingabe");
            }

            switch (eingabe){
                case 1:
                    Console.WriteLine("\nZahnfußhöhe mit Standardkopfspiel:                     " + Math.Round(m + (c*m)) + "mm");
                    Console.WriteLine("\nFußkreisdurchmesser mit Standardkopfspiel:             " + Math.Round(d - 2 * (m + (c*m))) + "mm");
                    Console.WriteLine("\nZahnhöhe mit Standardkopfspiel:                        " + Math.Round(2*m+(c*m)) + "mm");
                    Console.WriteLine("\nTeilkreisdurchmesser:                                  " + Math.Round(m * z) + "mm");
                    Console.WriteLine("\nKopfkreisdurchmesser:                                  " + Math.Round(d + 2 * m) + "mm");
                    Console.WriteLine("\nTeilung der Zähne am Zahnrad:                          " + Math.Round(Pi * m) + "mm");
                    Console.WriteLine("\nZahnkopfhöhe:                                          " + m + "mm");
                    break;

                case 2:
                    Console.WriteLine("\nZahnfußhöhe mit Kopfspiel 0.1 DIN 867:                 " + Math.Round(m + (c1*m)) + "mm");
                    Console.WriteLine("\nFußkreisdurchmesser mit Kopfspiel 0.1 DIN 867:         " + Math.Round(d - 2 * (m + (c1*m))) + "mm");
                    Console.WriteLine("\nZahnhöhe mit Kopfspiel 0.1 DIN 867:                    " + Math.Round(2 * m + (c1+m)) + "mm");
                    Console.WriteLine("\nTeilkreisdurchmesser:                                  " + Math.Round(m * z) + "mm");
                    Console.WriteLine("\nKopfkreisdurchmesser:                                  " + Math.Round(d + 2 * m) + "mm");
                    Console.WriteLine("\nTeilung der Zähne am Zahnrad:                          " + Math.Round(Pi * m) + "mm");
                    Console.WriteLine("\nZahnkopfhöhe:                                          " + m + "mm");
                    break;

                case 3:
                    Console.WriteLine("\nZahnfußhöhe mit Kopfspiel 0.3 DIN 867:                 " + Math.Round(m + (c2*m)) + "mm");
                    Console.WriteLine("\nFußkreisdurchmesser mit Kopfspiel 0.3 DIN 867:         " + Math.Round(d - 2 * (m + (c2*m))) + "mm");
                    Console.WriteLine("\nZahnhöhe mit Kopfspiel 0.3 DIN 867:                    " + Math.Round(2 * m + (c2*m)) + "mm");
                    Console.WriteLine("\nTeilkreisdurchmesser:                                  " + Math.Round(m * z) + "mm");
                    Console.WriteLine("\nKopfkreisdurchmesser:                                  " + Math.Round(d + 2 * m) + "mm");
                    Console.WriteLine("\nTeilung der Zähne am Zahnrad:                          " + Math.Round(Pi * m) + "mm");
                    Console.WriteLine("\nZahnkopfhöhe:                                          " + m + "mm");

                    break;
            }
   
            double V = Math.Round(A * b * dGJL);
            double V1 = Math.Round(A * b * dGJS);
            double V2 = Math.Round(A * b * S235JR);

            switch (material){
                case 1:
                    Console.WriteLine("\nGewicht:                                               " + Math.Round(A * b * dGJL) + "g");
                    Console.WriteLine("\nPreis:                                                 " + V * dGJL + "Euro");
                    break;
                    
                case 2:
                    Console.WriteLine("\nGewicht:                                               " + Math.Round(A * b * dGJS) + "g");
                    Console.WriteLine("\nPreis:                                                 " + V1 * dGJS + "Euro");
                    break;

                case 3:
                    Console.WriteLine("\nGewicht:                                               " + Math.Round(A * b * S235JR) + "g");
                    Console.WriteLine("\nPreis:                                                 " + V2 * S235JR + "Euro");
                    break;


                
            }
            Console.ReadKey();
        }
    }
}
