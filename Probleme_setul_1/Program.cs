using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_Setul_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16();
            //P17();
            //P18();
            //P19();
            //P20();
            //P21();
        }

        /// <summary>
        /// Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?"
        /// </summary>
        private static void P21()
        {
            int x, n;
            Random rnd = new Random();
            x = rnd.Next(1, 1025);
            Console.WriteLine("Ghiciti un numar cuprins intre 1 si 1024");
            do
            {
                Console.Write($"Numarul este mai mare decat ");
                n = int.Parse(Console.ReadLine());
                if (x > n)
                    Console.WriteLine("DA");
                else
                {
                    if (x < n)
                        Console.WriteLine("NU");
                    else
                    {
                        Console.WriteLine($"Numar selectat de calculator este: {x}");
                        return;
                    }
                }

            } while (n != x);
        }

        /// <summary>
        /// Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3)
        /// O fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0
        /// O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5. 
        /// O fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5. 
        /// </summary>
        private static void P20()
        {
            int m, n;
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            int parteInt, parteFract;
            parteInt = m / n; // 0
            parteFract = m % n; // 13
            Console.Write($"{parteInt},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                //Console.Write($"{cifra}");
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }

        /// <summary>
        /// Determinati daca un numar e format doar cu 2 cifre care se pot repeta.
        /// De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.
        /// </summary>
        private static void P19()
        {
            int n, cn, c = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 9; i++)
            {
                cn = n;
                while (cn != 0)
                {
                    if (cn % 10 == i)
                    {
                        c++;
                        break;
                    }
                    cn /= 10;
                }
            }
            if (c == 2)
                Console.WriteLine($"Numarul {n} este format doar din 2 cifre");
            else
                Console.WriteLine($"Numarul {n} nu este format doar din 2 cifre");

        }

        /// <summary>
        /// Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2.
        /// </summary>
        private static void P18()
        {
            int n, exponent, divizor = 2;
            bool ok = false;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            while (n != 1)
            {
                exponent = 0;
                while (n % divizor == 0)
                {
                    exponent++;
                    n /= divizor;
                }
                if (exponent != 0)
                {
                    if (ok)
                        Console.Write($" x {divizor}^{exponent}");
                    else
                    {
                        Console.Write($"{divizor}^{exponent}");
                        ok = true;
                    }
                }
                if (divizor == 2)
                    divizor++;
                else
                    divizor = divizor + 2;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. 
        /// Folositi algoritmul lui Euclid.
        /// </summary>
        private static void P17()
        {
            int a, b, rest, cmmdc, cmmmc;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            int ca = a, cb = b;
            rest = ca % cb;
            while (rest != 0)
            {
                ca = cb;
                cb = rest;
                rest = ca % cb;
            }
            cmmdc = cb;
            cmmmc = (a * b) / cmmdc;
            Console.WriteLine($"Cel mai mare divizor comun al numerelor {a} si {b} este {cmmdc}");
            Console.WriteLine($"Cel mai mic multiplu comun al numerelor {a} si {b} este {cmmmc}");
        }

        /// <summary>
        /// Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
        /// </summary>
        private static void P16()
        {
            Console.WriteLine("Introduceti 5 numere:");
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d= ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("e= ");
            int e = int.Parse(Console.ReadLine());
            int max = 0;
            if (a > b)
            {
                max = a;
                a = b;
                b = max;
            }
            if (b > c)
            {
                max = b;
                b = c;
                c = max;
            }
            if (c > d)
            {
                max = c;
                c = d;
                d = max;
            }
            if (d > e)
            {
                max = d;
                d = e;
                e = max;
            }
            if (a > b)
            {
                max = a;
                a = b;
                b = max;
            }
            if (b > c)
            {
                max = b;
                b = c;
                c = max;
            }
            if (c > d)
            {
                max = c;
                c = d;
                d = max;
            }
            if (a > b)
            {
                max = a;
                a = b;
                b = max;
            }
            if (b > c)
            {
                max = b;
                b = c;
                c = max;
            }
            if (a > b)
            {
                max = a;
                a = b;
                b = max;
            }
            Console.WriteLine($"Numerele ordonate crescator sunt {a}, {b}, {c}, {d} si {e}");
        }

        /// <summary>
        /// Se dau 3 numere. Sa se afiseze in ordine crescatoare.
        /// </summary>
        private static void P15()
        {
            int a, b, c;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());
            if (a > b && b > c)
                Console.Write($"{c},{b},{a}");
            if (a > b && a > c && c > b)
                Console.Write($"{b},{c},{a}");
            if (b > a && a > c)
                Console.Write($"{c},{a},{b}");
            if (b > a && b > c && c > a)
                Console.Write($"{a},{c},{b}");
            if (c > a && a > b)
                Console.Write($"{b},{a},{c}");
            if (c > a && c > b && b > a)
                Console.Write($"{a},{b},{c}");
            Console.WriteLine();
        }

        /// <summary>
        /// Determianti daca un numar n este palindrom. 
        /// Un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
        /// </summary>
        private static void P14()
        {
            int n, oglindit = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            int cn = n;
            while (cn != 0)
            {
                oglindit = oglindit * 10 + cn % 10;
                cn /= 10;
            }
            if (oglindit == n)
                Console.WriteLine($"Numarul {n} este palindrom");
            else
                Console.WriteLine($"Numarul {n} nu este palindrom");
        }

        /// <summary>
        /// Determianti cati ani bisecti sunt intre anii y1 si y2.
        /// </summary>
        private static void P13()
        {
            int y1, y2, aux, cati = 0;
            Console.Write("y1=");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("y2=");
            y2 = int.Parse(Console.ReadLine());
            if (y1 > y2)
            {
                aux = y1;
                y1 = y2;
                y2 = aux;
            }
            for (int i = y1; i <= y2; i++)
                if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                    cati++;
            Console.WriteLine($"Intre anii {y1} si {y2} sunt {cati} ani bisecti");
        }

        /// <summary>
        /// Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
        /// </summary>
        private static void P12()
        {
            int a, b, n, cate = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int aux = a;
                a = b;
                b = aux;
            }
            for (int i = a; i <= b; i++)
                if (n % i == 0)
                    cate++;
            Console.WriteLine($"In intervalul [{a},{b}] sunt {cate} numere divizibile cu {n}");
        }

        /// <summary>
        /// Afisati in ordine inversa cifrele unui numar n. 
        /// </summary>
        private static void P11()
        {
            int n, cifra;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write($"Cifrele numarului {n} in ordine inversa sunt:");
            while (n != 0)
            {
                cifra = n % 10;
                n /= 10;
                Console.Write($"{cifra} ");
            }
        }

        /// <summary>
        /// Test de primalitate: determinati daca un numar n este prim.
        /// </summary>
        private static void P10()
        {
            int n, d;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            bool prim = true;
            if (n < 2)
                prim = false;
            if (n % 2 == 0 && n != 2)
                prim = false;
            for (d = 3; d * d <= n; d = d + 2)
            {
                if (n % d == 0)
                    prim = false;
            }
            if (prim == true)
                Console.WriteLine($"Numarul {n} este numar prim");
            else
                Console.WriteLine($"Numarul {n} nu este numar prim");
        }

        /// <summary>
        /// Afisati toti divizorii numarului n.
        /// </summary>
        private static void P9()
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Divizorii lui n sunt:");
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    Console.WriteLine(i);
        }

        /// <summary>
        ///  Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
        ///  Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  
        /// </summary>
        private static void P8()
        {
            double a, b;
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a={a} si b={b}");
        }

        /// <summary>
        ///  Se dau doua variabile numerice a si b ale caror valori sunt date de intrare.
        ///  Se cere sa se inverseze valorile lor. 
        /// </summary>
        private static void P7()
        {
            double a, b, aux;
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"a={a} si b={b}");
        }

        /// <summary>
        /// Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
        /// </summary>
        private static void P6()
        {
            int a, b, c;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0 && (a + b > c) && (b + c > a) && (a + c) > b)
                Console.WriteLine($"{a},{b} si {c} pot fi lungimile laturilor unui triunghi");
            else
                Console.WriteLine($"{a},{b} si {c} nu pot fi lungimile laturilor unui triunghi");
        }

        /// <summary>
        /// Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
        /// </summary>
        private static void P5()
        {
            int n, k, cifra = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());

            if (k == 1)
            {
                Console.WriteLine($"Prima cifra a lui n este {n % 10}");
                return;
            }

            int copie_k = k;
            while (n != 0 && copie_k != 0)
            {
                cifra = n % 10;
                n /= 10;
                copie_k--;
            }
            if (n == 0 && copie_k != 0)
                Console.WriteLine($"Numarul introdus nu contine {k} cifre");
            else
                Console.WriteLine($"A {k}-a cifra a lui n, de la dreapta la stanga, este {cifra}");
        }

        /// <summary>
        /// Detreminati daca un an y este an bisect
        /// </summary>
        private static void P4()
        {
            int y;
            Console.Write("Dati un an: ");
            y = int.Parse(Console.ReadLine());
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                Console.WriteLine("Anul ales este un an bisect");
            else
                Console.WriteLine("Acest an nu este an bisect");
        }

        /// <summary>
        /// Determinati daca n se divide cu k, unde n si k sunt date de intrare.
        /// </summary>
        private static void P3()
        {
            int n, k;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine("n se divide cu k");
            else
                Console.WriteLine("n nu se divide cu k");
        }

        /// <summary>
        /// Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.
        /// Tratati toate cazurile posibile. 
        /// </summary>
        private static void P2()
        {
            double a, b, c, x1, x2;
            double delta;
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            c = double.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Solutiile ecuatiei sunt {x1} si {x2}");
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"Solutia ecuatiei este x={x1}");
            }
            else Console.WriteLine("Ecuatia nu are solutii reale");
        }

        /// <summary>
        /// Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
        /// </summary>
        private static void P1()
        {
            double a, b, x;
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());
            x = -b / a;
            Console.WriteLine($"Solutia ecuatiei {a}x+{b}=0 este x={x}");
        }
    }
}
