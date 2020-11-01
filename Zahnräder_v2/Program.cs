using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
        
namespace Berechnung_von_Zahnrädern{
    class Program{
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

        static void Main(string[] args){
            Console.WriteLine("BERECHNUNG DER ZAHNRADGEOMETRIE\n-------------------------------");
            Console.Write("Geben Sie ihr Modul ein:                ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geben Sie ihre Zahnzahl ein:            ");
            double z = Convert.ToDouble(Console.ReadLine());
            double d = m * z;
            Console.Write("Geben Sie an wie Breit das Zahnrad ist: ");
            double b = Convert.ToDouble(Console.ReadLine()); 

            double A=((d / 2) * (d / 2) * Pi);

            int material = 0;
            while (material < 1 || material > 3){
                Console.Write("\nWaehlen Sie das Material\n1: EN-GJL-200\n2: EN-GJS-350\n3: S235JR\nAuswahl: ");
                material = Convert.ToInt16(Console.ReadLine());
                if (material < 1 || material > 3) Console.WriteLine("\nFEHLER: Ungueltige Eingabe");
            }

            int eingabe = 0;
            while (eingabe < 1 || eingabe > 3){
                Console.Write("\nWählen Sie das Kopfspiel\n1: Standardkopfspiel\n2: Kopfspiel 0.1 DIN 867\n3: Kopfspiel 0.3 DIN 867\nAuswahl:");
                eingabe = Convert.ToInt16(Console.ReadLine());
                if (eingabe < 1 || eingabe > 3)     Console.WriteLine("\nFEHLER: Ungueltige Eingabe");
            }

            switch (eingabe){
                case 1:
                    Console.WriteLine("\nZahnfußhöhe mit Standardkopfspiel in mm:               " + (m + c) + "mm");
                    Console.WriteLine("\nFußkreisdurchmesser mit Standardkopfspiel in mm:       " + (m * z) + 2 * (m + c) + "mm");
                    Console.WriteLine("\nZahnhöhe mit Standardkopfspiel in mm:                  " + (2*m+c) + "mm");
                    break;

                case 2:
                    Console.WriteLine("\nZahnfußhöhe mit Kopfspiel 0.1 DIN 867 in mm:           " + (m + c1) + "mm");
                    Console.WriteLine("\nFußkreisdurchmesser mit Kopfspiel 0.1 DIN 867 in mm:   " + (m * z) + 2 * (m + c1) + "mm");
                    Console.WriteLine("\nZahnhöhe mit Kopfspiel 0.1 DIN 867 in mm:              " + (2 * m + c1) + "mm");
                    break;

                case 3:
                    Console.WriteLine("\nZahnfußhöhe mit Kopfspiel 0.3 DIN 867 in mm:           " + (m + c2) + "mm");
                    Console.WriteLine("\nFußkreisdurchmesser mit Kopfspiel 0.3 DIN 867 in mm:   " + (m * z) + 2 * (m + c2) + "mm");
                    Console.WriteLine("\nZahnhöhe mit Kopfspiel 0.3 DIN 867 in mm:              " + (2 * m + c2) + "mm");
                    break;
            }

            Console.WriteLine("\nTeilung der Zähne am Zahnrad in mm:                    " + Pi * m + "mm");
            Console.WriteLine("\nGrundkreisdurchmesser des Zahnrades in mm:             " + (m * z * cosα) + "mm");
            Console.WriteLine("\nZahnkopfhöhe ist das Modul:                            " + m + "mm");

            double V = A * b * dGJL;
            double V1 = A * b * dGJS;
            double V2 = A * b * S235JR;

            switch (material){
                case 1:
                    Console.WriteLine("\nGewicht:                                               " + (A * b * dGJL) + "g");
                    Console.WriteLine("\nPreis:                                                 " + (V * dGJL) + "Euro");
                    break;
                    
                case 2:
                    Console.WriteLine("\nGewicht:                                               " + (A * b * dGJS) + "g");
                    Console.WriteLine("\nPreis:                                                 " + (V1 * dGJS) + "Euro");
                    break;

                case 3:
                    Console.WriteLine("\nGewicht:                                               " + (A * b * S235JR) + "g");
                    Console.WriteLine("\nPreis:                                                 " + (V2 * S235JR) + "Euro");
                    break;
            }
        }
    }
}
