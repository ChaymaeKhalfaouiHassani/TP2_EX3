using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Csh
{
    public class Point
    {
        private double Abs;            //L'attribut Abscisse
        private double Ord;             //L'attribut Ordonne
        public Point()//constructeur par defaut
        {
        }
        public Point(double a, double o)   //Le constructeur d'initialisation
        {
            Abs = a;
            Ord = o;
        }
        public double getAbs()         //Le getter de l'attribut Abscisse
        {
            return Abs;
        }
        public void setAbs(double a)   //Le setter de l'attribut Abscisse
        {
            Abs = a;
        }
        public double getOrd()          //Le getter de l'attribut Ordonne
        {
            return Ord;
        }
        public void setOrdonne(double o)    //Le setter de l'attribut Ordonne
        {
            Ord = o;
        }
        static public double Sqr(double a) // une fonctio qui return la racine d'un nbr donnée 
        {
            return a * a;
        }
        static public double Distance(Point P1, Point P2)  //la methode distance
        {
            return Math.Sqrt(Sqr(P2.Ord - P1.Ord) + Sqr(P2.Abs - P1.Abs));
        }
        static public void Egalité(Point P1,Point P2)
        {
            if((P1.Abs == P2.Abs) && (P1.Ord == P2.Ord)){
                Console.WriteLine("les 2 points sont egaux");
            }else
                Console.WriteLine("les 2 points ne sont pas egaux");
        }
        static public void Translation(Point P1)
        {
            Console.WriteLine("nouveau abssice :");
            P1.Abs = int.Parse(Console.ReadLine());
            Console.WriteLine("nouveau ordonnee :");
            P1.Ord = int.Parse(Console.ReadLine());
            Console.WriteLine("les nouveaux coordonnees du point sont : Abc = " + P1.Abs + " Ord = " + P1.Ord);
        }
        static public void Linéarité(Point P1, Point P2, Point P3)
        {
            double a, b;
            if (P1.Abs != P2.Abs) //on va montrer d'abord que 2 point sont alignees
            {
                a = (P1.Ord - P2.Ord) / (P1.Abs - P2.Abs);  
                b = P1.Ord + a * P1.Abs;   //determiner l'equation de la droite y=ax+b
                if (a * P3.Abs + b == P3.Ord)//verifier l'appartenence du 3eme point a la droite (P1P2) 
                {
                    Console.WriteLine("les 3 points sont lineaire");
                }else
                    Console.WriteLine("les 3 points ne sont pas lineaire");
            }

        }
        static void Main(string[] args)
        {           
            Point P1 = new Point();
            Point P2 = new Point();
            Point P3 = new Point();
            

           Console.WriteLine("Entrez l'abscisse de 1ere point");
             P1.Abs = int.Parse(Console.ReadLine());
             Console.WriteLine("Entrez l'ordonnee de 1ere point");
             P1.Ord = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez l'abscisse de 2eme point");
            P2.Abs = int.Parse(Console.ReadLine());
             Console.WriteLine("Entrez l'ordonnee de 2eme point");
             P2.Ord = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez l'abscisse de 3eme point");
            P3.Abs = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez l'ordonnee de 3eme point");
            P3.Ord = int.Parse(Console.ReadLine());
            //_______________Distance______________//
            // Console.WriteLine("la distance entre ces deux points est :" + Distance(P1, P2));
            //_____________Egalité_____________//
            //Egalité(P1, P2);
            //______________Translation________//
            //Translation(P1);
            //_____________Linéarité___________//
            // Linéarité(P1, P2, P3);
        }

    }

}


