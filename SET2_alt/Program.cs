using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SET2_alt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SET2();
            Console.WriteLine("Aplicatia s-a inchis.");
        }

        private static void SET2()
        {
            Console.WriteLine("SET2 de exercitii in ConsoleApp - Fundamentele programarii 2022 - pali roland\n");
            Console.WriteLine("Apasa orice buton pentru a continua spre meniul de alegere al exercitiilor");
            Console.ReadKey();
            while (true)
            {
                MENU();
                string menubrowser = Console.ReadLine();
                switch (menubrowser.ToLower())
                {
                    case "exit":
                        return;
                    case "1":
                        Start();
                        P1();
                        Finish();
                        break;
                    case "2":
                        Start();
                        P2();
                        Finish();
                        break;
                    case "3":
                        Start();
                        P3();
                        Finish();
                        break;
                    case "4":
                        Start();
                        P4();
                        Finish();
                        break;
                    case "5":
                        Start();
                        P5();
                        Finish();
                        break;
                    case "6":
                        Start();
                        P6();
                        Finish();
                        break;
                    case "7":
                        Start();
                        P7();
                        Finish();
                        break;
                    case "8":
                        Start();
                        P8();
                        Finish();
                        break;
                    case "9":
                        Start();
                        P9();
                        Finish();
                        break;
                    case "10":
                        Start();
                        P10();
                        Finish();
                        break;
                    case "11":
                        Start();
                        P11();
                        Finish();
                        break;
                    case "12":
                        Start();
                        P12();
                        Finish();
                        break;
                    case "13":
                        Start();
                        P13();
                        Finish();
                        break;
                    case "14":
                        Start();
                        P14();
                        Finish();
                        break;
                    case "15":
                        Start();
                        P15();
                        Finish();
                        break;
                    case "16":
                        Start();
                        P16();
                        Finish();
                        break;
                    case "17":
                        Start();
                        P17();
                        Finish();
                        break;
                    default:
                        Console.WriteLine("Valoarea introdusa nu apartine criteriului cerut, apasa orice buton pentru a reveni la meniul de selectie!");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private static void P17()
        {
            Console.WriteLine("ex 17:\n   Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. \n    Determinati daca secventa reprezinta o secventa de paranteze corecta si,\n    daca este, determinati nivelul maxim de incuibare a parantezelor.");
            Console.WriteLine("\nIntroduceti lungimea secventei (n): ");
            uint n = N_CHECK();
            Console.WriteLine("\nIntroduceti secventa de numere:");          
            int countst = 0; // paranteze deschise
            int countf = 0; // paranteze inchise
            int incuib = 1;
            int incuibaux1 = 0;
            int incuibaux2 = 1;
            bool cerinta = true;
            try
            {               
                for (int i = 0; i < n; i++)
                {
                    int a;
                    a = int.Parse(Console.ReadLine());
                    if (a < 0 || a > 1)
                    {
                        Console.WriteLine("Secventa poate contine doar 0-uri si 1-uri!!!");
                        return;
                    }
                    if (i == 0)
                    {
                        if (a == 1)
                        {
                            cerinta = false;
                        }
                    }
                    if (a == 0)
                    {
                        countst++;
                        incuibaux1++;
                    }
                    if (a == 1)
                    {
                        countst--;
                        incuibaux1--;
                    }
                    if (incuibaux1 > 0 && a == 0)
                    {
                        incuib = incuibaux1;
                        if (incuibaux2 < incuib)
                        {
                            incuibaux2 = incuib;
                        }
                    }
                    if (incuibaux1 == 0) incuib = 0;
                    if(countst < 0)
                    {
                        cerinta = false;
                    }
                }
                if (countst != 0 || !cerinta)
                {
                    Console.WriteLine("Secventa introdusa este incorecta");
                    return;
                }
                Console.WriteLine($"Secventa introdusa este corecta si are nivelul maxim de incuibare {incuibaux2}"); // - 1 pentru ca nivel 1 = 1 paranteza intr-o paranteza prin interpretarea mea.
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// secventa bitonica rotita
        /// </summary>
        private static void P16()
        {
            Console.WriteLine("ex 16:\n   Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.");
            Console.WriteLine("\nIntroduceti lungimea secventei (n): ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            int wascresc = 0;
            int wasdescresc = 0;
            bool bitonic = true;
            bool rotit = false;
            bool crescmax1 = false;
            bool descrescmax1 = false;
            int endseq = 0, startseq = 0;
            int prevnr = 0;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int a;
                    a = int.Parse(Console.ReadLine());
                    if (!bitonic)
                    {
                        continue;
                    }
                    if (i == 0) // trebuie inregistrat primul nr din secventa
                    {
                        prevnr = a;
                        startseq = a;
                    }
                    if (i == n - 1) // trebuie inregistrat ultimul nr din secventa in cazul rotirii
                    {
                        endseq = a;
                    }
                    if (wascresc > 1 || wasdescresc > 1) // clauza de rotire
                    {
                        rotit = true;
                    }
                    if (wascresc >= 1 && wasdescresc >= 1) // pentru a gasi o contradictie dupa ce au avut loc deja o serie crescatoare si descrescatoare
                    {
                        if (crescmax1) // in acest caz de aici seria nu mai are voie sa creasca
                        {
                            if (a < prevnr)
                            {
                                wasdescresc = 2;
                                prevnr = a;
                                continue;
                            }
                            if (a > prevnr)
                            {
                                if (wasdescresc == 2)
                                {
                                    bitonic = false;
                                    continue;
                                }
                                prevnr = a;
                                continue;
                            }
                        }
                        if (descrescmax1) // in acest caz seria nu mai are voie sa descreasca
                        {
                            if (a > prevnr)
                            {
                                wascresc = 2;
                                prevnr = a;
                                continue;
                            }
                            if (a < prevnr)
                            {
                                if (wascresc == 2)
                                {
                                    bitonic = false;
                                    continue;
                                }
                                prevnr = a;
                                continue;
                            }
                        }
                    }
                    if (a > prevnr) 
                    {
                        if (wasdescresc == 1) // daca a inceput descrescator
                        {
                            crescmax1 = true;
                        }
                        wascresc = 1;
                    }
                    if (a < prevnr)
                    {
                        if (wascresc == 1) // daca a inceput crescator
                        {
                            descrescmax1 = true;
                        }
                        wasdescresc = 1;
                    }
                    prevnr = a;
                }
                if (rotit) // daca secventa este rotita trebuie comparate capetele secventei pentru continuitate de monotonie
                {
                    if (crescmax1)
                    {
                        if (startseq > endseq)
                        {
                            bitonic = false;
                        }
                    }
                    if (descrescmax1)
                    {
                        if (startseq < endseq)
                        {
                            bitonic = false;
                        }
                    }
                }
                if (!bitonic)
                {
                    Console.WriteLine("Secventa nu este bitonica rotita");
                    return;
                }
                Console.WriteLine("Secventa este bitonica rotita"); // chiar sper ca functioneaza cum trebuie, astea bitonice sunt greu de interpretat
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// secventa bitonica
        /// </summary>
        private static void P15()
        {
            Console.WriteLine("ex 15:\n   Se da o secventa de n numere. Sa se determine daca este bitonica. ");
            Console.WriteLine("\nIntroduceti lungimea secventei (n): ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            bool bitonic = false;
            bool cresc = false;
            try
            {
                int a, prevnr = Int32.MinValue;
                for (int i = 0; i < n; i++)
                {
                    if (!bitonic) // prima data ii crescator, verifica pana cand secventa descreste.
                    {
                        a = int.Parse(Console.ReadLine());                     
                        if (i > 0 && a > prevnr) // trebuie sa fie crescator minim odata.
                        {
                            cresc = true;
                        }
                        if (prevnr > a)
                        {
                            bitonic = true;
                            continue;
                        }
                        prevnr = a;
                    }
                    // de aici are voie doar sa fie descrescator.
                    if (bitonic)
                    {
                        a = int.Parse(Console.ReadLine());
                        if (prevnr < a)
                        {
                            bitonic = false;
                        }
                        prevnr = a;
                    }
                }               
                if (bitonic && cresc) 
                {
                    Console.WriteLine("Secventa este bitonica.");
                    return;
                }
                Console.WriteLine("Secventa nu este bitonica.");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// secventa monotona rotita
        /// </summary>
        private static void P14()
        {
            Console.WriteLine("ex 14:\n   Determinati daca o secventa de n numere este o secventa monotona rotita. ");
            Console.WriteLine("\nIntroduceti lungimea secventei (n): ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            int countcresc = 0, countdescresc = 0;
            int prevnr = int.MaxValue; // n-are importanta dar nu ma lasa sa ii schimb valoare in functia if
            int startseq = 0;
            int endseq = 0;
            try
            {
                for (int i = 0; i < n; i++)
                {    
                    int a;
                    a = int.Parse(Console.ReadLine());
                    if (i == 0)
                    {
                        prevnr = a;
                        startseq = a;
                    }
                    if (i == n - 1) 
                    {
                        endseq = a;
                    }
                    if (a > prevnr)
                    {
                        countcresc++;
                    }
                    if (a < prevnr)
                    {
                        countdescresc++;
                    }
                    prevnr = a;
                }
                if(countdescresc== 0 || countcresc== 0)
                {
                    Console.WriteLine("Secventa este monotona rotita.");
                    return;
                }
                if (countdescresc < 2 && countcresc < 2) // orice secventa de 3 elemente poate fi rotita sa formeze una monotona.
                {
                    Console.WriteLine("Secventa este monotona rotita.");
                    return;
                }
                if ( countdescresc < 2 && countcresc > 2 ) // secventa crescatoare
                {
                    if (startseq > endseq)
                    {
                        Console.WriteLine("Secventa este monotona rotita.");
                        return;
                    }
                }
                if ( countcresc < 2 && countdescresc > 2 ) // secventa descrescatoare
                {
                    if ( startseq < endseq)
                    {
                        Console.WriteLine("Secventa este monotona rotita.");
                        return;
                    }
                }
                Console.WriteLine("Secventa nu este monotona rotita.");
                //Console.WriteLine($"C: {countcresc}, D: {countdescresc}");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// secventa crescatoare rotita
        /// </summary>
        private static void P13()
        {
            Console.WriteLine("ex 13:\n   Determinati daca o secventa de n numere este o secventa crescatoare rotita. ");
            Console.WriteLine("\nIntroduceti lungimea secventei (n): ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            bool cerinta = true;
            bool rotit = false;
            int startseq = 0;
            int endseq = 0;
            try
            {
                int a, prevnr = Int32.MinValue;
                for (int i = 0; i < n; i++)
                {
                    a = int.Parse(Console.ReadLine());
                    if (i == 0)
                    {
                        startseq = a;
                    }                  
                    if (i == n - 1)
                    {
                        endseq = a;
                    }
                    if (rotit)
                    {
                        if (prevnr > a)
                        {
                            cerinta = false;
                        }                       
                    }
                    if (prevnr > a)
                    {
                        rotit = true;
                    }                   
                    prevnr = a;
                }
                if (rotit)
                {
                    if (startseq < endseq)
                    {
                        Console.WriteLine("Secventa nu este o secventa crescatoare rotita.");
                        return;
                    }
                }
                if (cerinta)
                {
                    Console.WriteLine("Secventa este o secventa crescatoare rotita.");
                }
                else Console.WriteLine("Secventa nu este o secventa crescatoare rotita.");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// grupuri de nr consecutive delimitate de 0
        /// </summary>
        private static void P12()
        {
            // interpretarea mea este ca cautam cate numere reale, dintr-un sir A(n) in care numerele A(n) != 0 formeaza grupul, iar 0 delimita grupurile.
            // nu stiu daca numere consecutive inseamna si numere in ordine crescatoare
            Console.WriteLine("ex 12:\n   Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. \n   Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.");
            Console.WriteLine("\nIntroduceti lungimea secventei (n): ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            int countegal = 0, countgrup = 1;
            try
            {
                for (int i = 0; i < n ; i++)
                {
                    int a;
                    a = int.Parse(Console.ReadLine());
                    if (a != 0)
                    {
                        countegal++;
                    }
                    if (a == 0 && countegal != 0)
                    {                       
                        countgrup++;
                        countegal = 0;
                    }
                    if ( i == n - 1) // se uita la ultima cifra din secventa, daca e 0 scade un grup pentru ca nu urmeaza grup dupa 0.
                    {
                        if (a == 0)
                        {
                            countgrup--;
                        }
                    }
                }
                Console.WriteLine($"Secventa contine {countgrup} grupuri de numere consecutive diferite de zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// suma inverselor ale numerelor dintr-o secventa
        /// </summary>
        private static void P11()
        {
            Console.WriteLine("ex 11:\n   Se da o secventa de n numere. Se cere sa se calculeze suma inverselor acestor numere.");
            Console.WriteLine("\nIntroduceti lungimea secventei (n): ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            long suma = 0;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int a, inv = 0;
                    a = int.Parse(Console.ReadLine());
                    while (a != 0)
                    {
                        inv = inv * 10 + a % 10;
                        a /= 10;
                    }
                    suma += inv;
                }
                Console.WriteLine($"Suma inverselor numerelor din secventa este: {suma}");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// nr consecutive egale
        /// </summary>
        private static void P10()
        {
            Console.WriteLine("ex 10:\n   Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.");
            Console.WriteLine("\nIntroduceti lungimea secventei (n): ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            int countegal = 0, countmax = 0, countmaxaux = 0, st = 0;
            try
            {
                for (int i = 0; i < n ; i++)
                {
                    int a;
                    a = int.Parse(Console.ReadLine());
                    if (i == 0)
                    {
                        st = a;
                        continue;
                    }
                    if (a == st)
                    {
                        countegal++;
                        countmax = countegal;
                        if (countmaxaux < countmax)
                        {
                            countmaxaux = countmax;
                        }
                    }
                    if (a != st) 
                    { 
                        countegal = 0; 
                    }
                    st = a;
                }
                Console.WriteLine($"Secventa contine maxim {countmaxaux + 1} numere consecutive egale.");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// monotonia secventei
        /// </summary>
        private static void P9()
        {
            Console.WriteLine("ex 9:\n   Sa se determine daca o secventa de n numere este monotona.");
            Console.WriteLine("\nIntroduceti lungimea secventei (n): ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            int countcresc = 0, countdescresc = 0;
            int st = 0;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int a;
                    a = int.Parse(Console.ReadLine());
                    if (i == 0)
                    {
                        st = a;
                    }
                    if (a > st)
                    {
                        st = a;
                        countcresc++;
                    }
                    if (a < st)
                    {
                        st = a;
                        countdescresc++;
                    }                   
                }
                if (countdescresc > 0 && countcresc > 0)
                {
                    Console.WriteLine("Secventa nu este monotona.");
                    return;
                }
                Console.WriteLine("Secventa este monotona.");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// Fibonacci calculator
        /// </summary>
        private static void P8()
        {
            Console.WriteLine("ex 8:\n   Determianti al n-lea numar din sirul lui Fibonacci.\n   Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2).");
            int nr0 = 0;
            int nr1 = 1;
            int nr = 1;
            Console.WriteLine("\nIntroduceti n : ");
            uint n = N_CHECK();
            if (n == 0) return;
            if (n == 1)
            {
                Console.WriteLine("Primul termen din sirul lui fibonacci este 0.");
                return;
            }
            if (n == 2)
            {
                Console.WriteLine("Al 2-lea termen din sirul lui fibonacci este 1.");
                return;
            }
            for (uint i = 3; i <= n; i++)
            {
                nr = nr0 + nr1;
                nr0 = nr1;
                nr1 = nr;
                // Console.WriteLine($"\n{nr}");
            }
            Console.WriteLine($"\nAl {n}-lea termen din sirul lui Fibonacci este: {nr}");

        }
        /// <summary>
        /// Valoare minima si maxima dintr-o secventa
        /// </summary>
        private static void P7()
        {
            Console.WriteLine("ex 7:\n   Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. ");
            Console.WriteLine("\nIntroduceti lungimea secventei (n): ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            int max = Int32.MinValue, min = Int32.MaxValue;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int a;
                    a = int.Parse(Console.ReadLine());
                    if (a > max)
                    {
                        max = a;
                    }
                    if (a < min)
                    {
                        min = a;
                    }
                    //Console.WriteLine(a);                  
                }
                Console.WriteLine($"\nValoarea minima din secventa este {min} iar valoarea maxima este {max}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// Test ordine crescatoare
        /// </summary>
        private static void P6()
        {
            Console.WriteLine("ex 6:\n   Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.");
            Console.WriteLine("\nIntroduceti lungimea secventei (n): ");
            uint n = N_CHECK();
            bool cerinta = true;
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            try
            {
                int a, prevnr = Int32.MinValue;
                for (int i = 0; i < n; i++)
                {                   
                    a = int.Parse(Console.ReadLine());
                    if (prevnr > a)
                    {
                        cerinta = false;
                    }
                    prevnr = a;
                }
                if (cerinta)
                {
                    Console.WriteLine("\nNumerele din secventa sunt in ordine crescatoare");
                }
                else 
                {
                    Console.WriteLine("\nNumerele din secventa nu sunt in ordine crescatoare");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// Test egalitate numar si pozitie in secventa
        /// </summary>
        private static void P5()
        {
            Console.WriteLine("ex 5:\n   Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. \n   Se considera ca primul element din secventa este pe pozitia 0. ");
            Console.WriteLine("\nIntroduceti lungimea secventei (n): ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            int count = 0;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int a;
                    a = int.Parse(Console.ReadLine());
                    if (a == i) count++;
                    //Console.WriteLine(a);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
            Console.WriteLine($"In aceasta secventa sunt {count} numere egale cu pozitia lor in secventa");
        }
        /// <summary>
        /// Pozitia unui numar 'a' dintr-o secventa de n numere.
        /// </summary>
        private static void P4()
        {
            Console.WriteLine("ex 4:\n   Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numar 'a'.");
            Console.WriteLine("\nIntroduceti lungimea secventei (n): ");
            uint n = N_CHECK();
            if (n == 0) return;           
            int a;
            Console.WriteLine("\nIntroduceti numarul 'a' pe care vreti sa il gasiti in secventa: ");
            var aAsString = Console.ReadLine();
            while (!int.TryParse(aAsString, out a))
            {
                Console.WriteLine("Trebuie sa introduci un numar! Incearca din nou!");
                Console.WriteLine();
                Console.Write("a = ");
                aAsString = Console.ReadLine();
            }
            int count = -1;
            int poz = count;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int x;
                    x = int.Parse(Console.ReadLine());
                    count++;
                    if (x == a)
                    {
                        poz = count;
                    }
                }
                Console.WriteLine($"Numarul {a} se afla in pozitia {poz}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
        }
        /// <summary>
        /// Suma si produsul primelor N numere
        /// </summary>
        private static void P3()
        {
            Console.WriteLine("ex 3:\n   Calculati suma si produsul numerelor de la 1 la n.");
            Console.WriteLine("\nIntroduceti 'n' : ");
            ulong n = ulong.Parse(Convert.ToString(N_CHECK()));
            if (n == 0) return;
            if (n < 1)
            {
                Console.WriteLine("'n' trebuie sa fie mai mare decat 1 ca operatia sa aiba sens!!!"); // serios cine nu citeste indicatia
                return;
            }
            ulong suma; // precizie pana la n = 2^33-1
            double produs = 1; // foarte mare cand n > 20
            try
            {
                checked
                {
                    if (n % 2 == 0)
                    {
                        suma = n / 2 * (n + 1);
                    }
                    else suma = ((n + 1) / 2) * n;
                }
                if (n > 170) // la 171 deja are overflow peste limita de double // precis fara punct zecimal pana la n < 18
                {
                    Console.WriteLine($"Pentru numerele de la 1 la {n}:\nSuma lor este: {suma}\nProdusul lor este prea mare sa poata fi calculat ( peste 20 de cifre lung ).");
                    return;
                }
                else
                {
                    for (double i = 2; i <= n; i++)
                    {
                        produs *= i;

                    }
                }
                Console.WriteLine($"Pentru numerele de la 1 la {n}:\nSuma lor este: {suma}\nProdusul lor este: {produs}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Numarul introdus este prea mare pentru a putea fi calculat!!!");
            }

        }
        /// <summary>
        /// Secventa in care se gasesc numere pozitive, negative si 0.
        /// </summary>
        private static void P2()
        {
            Console.WriteLine("ex 2:\n   Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ");
            Console.WriteLine("\nIntroduceti lungimea secventei (n): ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            int countneg = 0;
            int countzero = 0;
            int countpos = 0;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int a;
                    a = int.Parse(Console.ReadLine());
                    if (a < 0) countneg++;
                    if (a == 0) countzero++;
                    if (a > 1) countpos++;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
            Console.Write($"\nIn secventa ");
            if (countpos == 0) Console.Write("nu este nici un numar pozitiv,");
            if (countpos == 1) Console.Write("este 1 numar pozitiv,");
            if (countpos > 1) Console.Write($"sunt {countpos} numere pozitive,");
            if (countzero == 0) Console.Write(" nu este nici un zero,");
            if (countzero == 1) Console.Write(" este 1 zero,");
            if (countzero > 1) Console.Write($" sunt {countzero} zerouri,");
            if (countneg == 0) Console.Write(" nu este nici un numar negativ.");
            if (countneg == 1) Console.Write(" este 1 numar negativ.");
            if (countneg > 1) Console.Write($" sunt {countneg} numere negative.");
        }
        /// <summary>
        /// Secventa in care se gasesc nr pare.
        /// </summary>
        private static void P1()
        {
            Console.WriteLine("ex 1:\n   Se da o secventa de n numere. Sa se determine cate din ele sunt pare.");
            Console.WriteLine("\nIntroduceti lungimea secventei (n): ");
            uint n = N_CHECK();
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            int count = 0;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    int a;
                    a = int.Parse(Console.ReadLine());
                    if (a % 2 == 0) count++;
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine caractere necorespunzatoare sau nu corespunde lungimii declarate anterior!!!");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSecventa de numere introdusa contine un numar prea mare!!!");
                return;
            }
            Console.WriteLine($"In secventa sunt {count} numere pare.");
        }
        private static void MENU()
        {
            Console.Clear();
            Console.WriteLine("SET 2 de exercitii:");
            Console.WriteLine("1. Se da o secventa de n numere. Sa se determine cate din ele sunt pare.");
            Console.WriteLine("2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ");
            Console.WriteLine("3. Calculati suma si produsul numerelor de la 1 la n. ");
            Console.WriteLine("4. Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numar 'a'. \n   Se considera ca primul element din secventa este pe pozitia zero. \n   Daca numarul nu se afla in secventa raspunsul va fi -1. ");
            Console.WriteLine("5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. \n   Se considera ca primul element din secventa este pe pozitia 0. ");
            Console.WriteLine("6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.");
            Console.WriteLine("7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. ");
            Console.WriteLine("8. Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: \n   f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2).");
            Console.WriteLine("9. Sa se determine daca o secventa de n numere este monotona.");
            Console.WriteLine("10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.");
            Console.WriteLine("11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.");
            Console.WriteLine("12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. \n    Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.");
            Console.WriteLine("13. Determinati daca o secventa de n numere este o secventa crescatoare rotita. ");
            Console.WriteLine("14. Determinati daca o secventa de n numere este o secventa monotona rotita. ");
            Console.WriteLine("15. Se da o secventa de n numere. Sa se determine daca este bitonica. ");
            Console.WriteLine("16. Se cere sa se determine daca este o secventa bitonica rotita. ");
            Console.WriteLine("17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. \n    Determinati daca secventa reprezinta o secventa de paranteze corecta si,\n    daca este, determinati nivelul maxim de incuibare a parantezelor.");
            Console.WriteLine();

            Console.Write("Introduceti un numar de la 1 la 17 sau 'exit' pentru a iesi din aplicatie: ");
        }
        private static void Finish()
        {
            Console.WriteLine();
            Console.WriteLine("Pentru a reveni la meniul de selectie apasati orice buton.");
            Console.ReadKey();
            return;
        }
        private static void Start()
        {
            Console.Clear();
        }
        /// <summary>
        /// Validare de date pentru lungimea secventei
        /// </summary>
        /// <returns>lungimea secventei</returns>
        private static uint N_CHECK()
        {
            uint n;
            var nAsString = Console.ReadLine();
            while (!uint.TryParse(nAsString, out n))
            {
                Console.WriteLine("Trebuie sa introduci un numar pozitiv! Incearca din nou!");
                Console.WriteLine();
                Console.Write("n = ");
                nAsString = Console.ReadLine();
            }
            if (n == 0)
            {
                Console.WriteLine("O secventa de 0 numere nu exista!!!");
            }
            return n;
        }
    }
}
