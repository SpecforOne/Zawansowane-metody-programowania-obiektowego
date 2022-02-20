using System;
using System.IO;
using System.Text;

namespace ZaliczeniePiotrRomanowski
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 21;                                 //  
            int g = 0;                                  //  Deklarowanie zmiennych.
            int sr = 0;                                 //
            int srednia = 0;                            //
            StreamWriter sw = new StreamWriter("Data.txt", true, Encoding.ASCII);       //stworzenie wystąpienia, zapis do pliku "Data.txt" z dopisywaniem.
            Random los = new Random();                                                  //stworzenie wystąpienia.
            Console.WriteLine("Piotr Romanowski 18550\n\n");                            //wypisanie
            //wypisanie
            Console.WriteLine(" Zagrajmy w grę: \n twoje zadanie to trafienie wylosowanej liczby z przedziału 0 - 20 \n" +
                              " Zostaniesz poinformowany czy wybrałeś za małą czy za dużą liczbe. Powodzenia\n");
            int menu = 0;       //deklarowanie zmiennej
            
            //stworzenie pętli
            do  
            {
                int l = 0;              //  Deklarowanie zmiennych
                int b = los.Next(21);   //

                //Wypisanie poniższych zdań
                Console.WriteLine("Wybierz opcje\n");
                Console.WriteLine("1: Zagraj w grę");
                Console.WriteLine("2: Podsumowanie");
                Console.WriteLine("3: Zapisz do pliku");
                Console.WriteLine("4: Koniec\n");

                try

                {
                    // konwertowanie danych na inny typ
                    menu = Convert.ToInt32(Console.ReadLine());    
                    //sprawdzenie czy zmienna "menu" jest większa od 4 lub mniejsza od 0
                    if (menu > 4 || menu <0)
                    {
                        //Wypisanie
                        Console.WriteLine("wybierz właściwy numer!");
                    }
                }
                catch (Exception)
                {
                    //Wypisanie
                    Console.WriteLine("Nie podales liczby!");
                }

                //stworzenie pola wyboru
                switch (menu)   
                {
                    case 1:
                        //wykonuj aż zmienna "a" różni się od "b"
                        while (a != b)  
                        {

                            //Wypisanie
                            Console.WriteLine("podaj liczbe: \n");
                            try

                            {
                                //zamiana typu danych
                                a = Convert.ToInt32(Console.ReadLine());

                            }
                            catch (Exception) 
                            {
                                // w przypadku błędu wypisz poniższe:
                                Console.WriteLine("Nie podales liczby!");
                            }

                            if (a > 20 || a < 0)  //sprawdzenie czy zmienna "a " jest większa od 20 lub mniejsza od 0
                                {
                                //Wypisanie
                                Console.WriteLine("Podaj prawidłową liczbe z zakresu 0 - 20");
                                }
                                if (a == b)       // jeśli a = b
                                {
                                    
                                    l++;                                                                                        //zwiększenie zmiennej "l" o 1
                                    Console.WriteLine("Gratulacje! udało ci się zgadnąć za: " + l + " razem.");                 //Wypisanie
                                    Console.WriteLine("\n");                                                                        //Wypisanie
                                    sw.WriteLine(g + ": udalo ci sie zgadnac za: " + l + " razem. Szukana liczba to: " + b);        //zapisanie do pliku
                                    g++;                    //zwiększenie zmiennej "g" o 1
                                    sr = sr + l;            //dodanie zmiennej "l" do zmiennej "sr"
                                    srednia = sr / g;       //dzielenie zmiennej "sr" przez "g"

                                }
                                if (a < b)      //jeśli "a" mniejsze od "b"
                                {
                                
                                Console.WriteLine("za mała liczba");        //Wypisanie
                                l++;                                        //zwiększenie "l" o 1
                                }
                                if (a > b)      //jeśli "a" większe od "b"
                            {
                                    Console.WriteLine("za duża liczba");    //Wypisanie
                                    l++;                                    //zwiększenie "l" o 1        
                            }
                            
                        }
                        break;      //przerwanie switcha
                    case 2:
                        Console.WriteLine("liczba zagrań: " + g);                                                   //wypisanie
                        Console.WriteLine("średnia ilość prób do odgadnięcia wylosowanej liczby: " + srednia);      //wypisanie
                        break;      //przerwanie switcha

                    case 3:
                        sw.WriteLine("liczba gier: " + g);                                                          //wypisanie
                        sw.WriteLine("srednia ilosc prob do odgadniecia wylosowanej liczby: " + srednia + "\n");    //wypisanie


                        break;      //przerwanie switcha

                    case 4:
                        Console.WriteLine("koniec");        //wypisanie
                        break;      //przerwanie switcha

                }
            } while (menu != 4);    //wykonywanie pętli aż "menu" będzie różne od 4
            sw.Close();             //zamknięcie pliku


        }
    }
}
