using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Állomány_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //állomány bekérés
            string[] állomány = File.ReadAllLines("állomány.txt");
            //tömb adattárolók létrehozása
            string[] Player = new string[állomány.Length];
            string[] Nation = new string[állomány.Length];
            string[] Pos = new string[állomány.Length];
            string[] Squad = new string[állomány.Length];
            string[] Comp = new string[állomány.Length];
            int[] Age = new int[állomány.Length];
            int[] Born = new int[állomány.Length];
            int[] MP = new int[állomány.Length];
            int[] Starts = new int[állomány.Length];
            //lista adattárolók létrehozása
            List<string> Kimenet = new List<string>();
            List<string> bevitel_elemek = new List<string>();
            List<string> bevitel_elemek_értéke = new List<string>();
            //egyéb változók létrehozása
            string bevitel;
            string bevitel2;
            bool van_s = true;
            bool van_j = true;
            bool van_n = true;
            bool van_p = true;
            bool van_cs = true;
            bool van_c = true;
            bool van_k = true;
            bool van_sz = true;
            bool van_mp = true;
            bool van_st = true;
            //állomány szétbontás
            for (int i = 0; i < állomány.Length; i++)
            {

                Player[i] = állomány[i].Split(';')[1].Remove(0, 1).Remove(állomány[i].Split(';')[1].Remove(0, 1).Length - 1);
                Nation[i] = állomány[i].Split(';')[2].Remove(0, 1).Remove(állomány[i].Split(';')[2].Remove(0, 1).Length - 1);
                Pos[i] = állomány[i].Split(';')[3].Remove(0, 1).Remove(állomány[i].Split(';')[3].Remove(0, 1).Length - 1);
                Squad[i] = állomány[i].Split(';')[4].Remove(0, 1).Remove(állomány[i].Split(';')[4].Remove(0, 1).Length - 1);
                Comp[i] = állomány[i].Split(';')[5].Remove(0, 1).Remove(állomány[i].Split(';')[5].Remove(0, 1).Length - 1);
                Age[i] = int.Parse(állomány[i].Split(';')[6].Remove(0, 1).Remove(állomány[i].Split(';')[6].Remove(0, 1).Length - 1));
                Born[i] = int.Parse(állomány[i].Split(';')[7].Remove(0, 1).Remove(állomány[i].Split(';')[7].Remove(0, 1).Length - 1));
                MP[i] = int.Parse(állomány[i].Split(';')[8].Remove(0, 1).Remove(állomány[i].Split(';')[8].Remove(0, 1).Length - 1));
                Starts[i] = int.Parse(állomány[i].Split(';')[9].Remove(0, 1));
                Kimenet.Add("" + i + ";" + Player[i] + ";" + Nation[i] + ";" + Pos[i] + ";" + Squad[i] + ";" + Comp[i] + ";" + Age[i] + ";" + Born[i] + ";" + MP[i] + ";" + Starts[i]);
            }
            //MAIN program
            do
            {


                //kódbeviteli mező
                do
                {
                    //bekérés segítő
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("1.  szortírozás sorszám          11. rendezés sorszám                21. látszat sorszám");
                    Console.WriteLine("2.  szortírozás játékos          12. rendezés betűsorrend            22. látszat játékos");
                    Console.WriteLine("3.  szortírozás nemzetiség       13. rendezés nemzet                 23. látszat nemzet");
                    Console.WriteLine("4.  szortírozás posz             14. rendezés poszt                  24. látszat poszt");
                    Console.WriteLine("5.  szortírozás csapat           15. rendezés csapat                 25. látszat csapat");
                    Console.WriteLine("6.  szortírozás comp             16. rendezés comp                   26. látszat comp");
                    Console.WriteLine("7.  szortírozás kor              17. rendezés kor                    27. látszat kor");
                    Console.WriteLine("8.  szortírozás születés         18. rendezés születés               28. látszat születés");
                    Console.WriteLine("9.  szortírozás MP               19. rendezés MP                     29. látszat MP");
                    Console.WriteLine("10. szortírozás Starts           20. rendezés Starts                 30. látszat Starts");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("reset: reset");
                    Console.WriteLine("kilépés: kilépés");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("válasszon értéket");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("bevitel végéhez nyomjon ENTER-t");
                    bevitel = Console.ReadLine();
                    
                    Console.WriteLine();
                    Console.Clear();
                    if ((bevitel != "reset" && bevitel != "" && bevitel != "kilépés") && (int.Parse(bevitel) == 1 || (int.Parse(bevitel) >= 7 && int.Parse(bevitel) <= 10)))
                    {
                        Console.WriteLine("állomány hossza jelenleg {0}", Kimenet.Count);
                        Console.WriteLine("egy elem kiválasztásához írjon egy számot");
                        Console.WriteLine("több elem kiválasztásához írjon 2 számot - jel el elválasztva");
                        bevitel_elemek.Add(bevitel);
                        bevitel2 = Console.ReadLine();
                        bevitel_elemek_értéke.Add(bevitel2);
                    }
                    else if ((bevitel != "reset" && bevitel != "" && bevitel != "kilépés") && (int.Parse(bevitel) >= 2 && int.Parse(bevitel) <= 6))
                    {
                        Console.WriteLine("állomány hossza jelenleg {0}", Kimenet.Count);
                        Console.WriteLine("Adja meg pontosan a szöveget vagy egy részletét a pontatlanabb kereséshez");
                        bevitel_elemek.Add(bevitel);
                        bevitel2 = Console.ReadLine();
                        bevitel_elemek_értéke.Add(bevitel2);
                    }
                    else if ((bevitel != "reset" && bevitel != "" && bevitel != "kilépés") && (int.Parse(bevitel) >= 11 && int.Parse(bevitel) <= 20))
                    {
                        Console.WriteLine("állomány hossza jelenleg {0}", Kimenet.Count);
                        Console.WriteLine("növekvő sorrendhez vigyen be (n) betűt");
                        Console.WriteLine("csökkenő sorrendhez vigyen be (cs) betűt");
                        bevitel_elemek.Add(bevitel);
                        bevitel2 = Console.ReadLine();
                        bevitel_elemek_értéke.Add(bevitel2);
                    }
                    else if ((bevitel != "reset" && bevitel != "" && bevitel != "kilépés") && (int.Parse(bevitel) >= 21 && int.Parse(bevitel) <= 30))
                    {
                        Console.WriteLine("állomány hossza jelenleg {0}", Kimenet.Count);
                        Console.WriteLine("A megjelenés törléséhez vigyen be (f) betűt");
                        Console.WriteLine("A megjelenés megjelenítéséhez vigyen be (t) betűt");
                        bevitel_elemek.Add(bevitel);
                        bevitel2 = Console.ReadLine();
                        bevitel_elemek_értéke.Add(bevitel2);
                    }
                    Console.Clear();
                    if (bevitel != "reset" && bevitel != "" && bevitel != "kilépés")
                    {
                        for (int i = 0; i < bevitel_elemek.Count; i++)
                        {
                            Console.WriteLine("bevitt érték: {0} {1}", bevitel_elemek[i], bevitel_elemek_értéke[i]);
                        }
                    }
      
                    Console.WriteLine();
                } while (bevitel != "" && bevitel != "reset" && bevitel != "kilépés");



                
                //kimenet reset eldöntése
                if (bevitel != "reset")
                {

                    //folyamat megkezdése
                    for (int i = 0; i < bevitel_elemek.Count; i++)
                    {
                        //bevitel elemének kiértékelése

                        switch (bevitel_elemek[i])
                        {
                            //keresési feltételek
                            case "1":
                                Kimenet = sorszám(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "2":
                                Kimenet = neve(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "3":
                                Kimenet = nemzet(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "4":
                                Kimenet = poszt(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "5":
                                Kimenet = csapat(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "6":
                                Kimenet = comp(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "7":
                                Kimenet = kora(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "8":
                                Kimenet = születés(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "9":
                                Kimenet = MP_(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "10":
                                Kimenet = Starts_(Kimenet, bevitel_elemek_értéke[i]);
                                break;



                            //szortírozási feltételek
                            case "11":
                                Kimenet = sorszám_(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "12":
                                Kimenet = neve_(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "13":
                                Kimenet = nemzet_(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "14":
                                Kimenet = poszt_(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "15":
                                Kimenet = csapat_(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "16":
                                Kimenet = comp_(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "17":
                                Kimenet = kora_(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "18":
                                Kimenet = születés_(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "19":
                                Kimenet = MP__(Kimenet, bevitel_elemek_értéke[i]);
                                break;
                            case "20":
                                Kimenet = Starts__(Kimenet, bevitel_elemek_értéke[i]);
                                break;



                            //látszati feltételek
                            case "21":
                                if (bevitel_elemek_értéke[i] == "f")
                                {
                                    van_s = false;
                                }
                                else
                                {
                                    van_s = true;
                                }
                                break;
                            case "22":
                                if (bevitel_elemek_értéke[i] == "f")
                                {
                                    van_j = false;
                                }
                                else
                                {
                                    van_j = true;
                                }
                                break;
                            case "23":
                                if (bevitel_elemek_értéke[i] == "f")
                                {
                                    van_n = false;
                                }
                                else
                                {
                                    van_n = true;
                                }
                                break;
                            case "24":
                                if (bevitel_elemek_értéke[i] == "f")
                                {
                                    van_p = false;
                                }
                                else
                                {
                                    van_p = true;
                                }
                                break;
                            case "25":
                                if (bevitel_elemek_értéke[i] == "f")
                                {
                                    van_cs = false;
                                }
                                else
                                {
                                    van_cs = true;
                                }
                                break;
                            case "26":
                                if (bevitel_elemek_értéke[i] == "f")
                                {
                                    van_c = false;
                                }
                                else
                                {
                                    van_c = true;
                                }
                                break;
                            case "27":
                                if (bevitel_elemek_értéke[i] == "f")
                                {
                                    van_k = false;
                                }
                                else
                                {
                                    van_k = true;
                                }
                                break;
                            case "28":
                                if (bevitel_elemek_értéke[i] == "f")
                                {
                                    van_sz = false;
                                }
                                else
                                {
                                    van_sz = true;
                                }
                                break;
                            case "29":
                                if (bevitel_elemek_értéke[i] == "f")
                                {
                                    van_mp = false;
                                }
                                else
                                {
                                    van_mp = true;
                                }
                                break;
                            case "30":
                                if (bevitel_elemek_értéke[i] == "f")
                                {
                                    van_st = false;
                                }
                                else
                                {
                                    van_st = true;
                                }
                                break;
                        }
                        //adathiánynál fellépő probléma jelző
                        if (Kimenet.Count == 0)
                        {
                            Console.WriteLine("nincsen hiba található a {0}:{1} paracs kiértékelésekor", bevitel_elemek[i], bevitel_elemek_értéke[i]);
                            break;
                        }


                    }
                    //kiíratás
                    Console.Clear();
                    if (bevitel != "kilépés")
                    {
                        //távolságszámítás
                        int zero0 = zeroh(Kimenet)[0];
                        int zero1 = zeroh(Kimenet)[1] + zero0;
                        int zero2 = zeroh(Kimenet)[2] + zero1;
                        int zero3 = zeroh(Kimenet)[3] + zero2;
                        int zero4 = zeroh(Kimenet)[4] + zero3;
                        int zero5 = zeroh(Kimenet)[5] + zero4;
                        int zero6 = zeroh(Kimenet)[6] + zero5;
                        int zero7 = zeroh(Kimenet)[7] + zero6;
                        int zero8 = zeroh(Kimenet)[8] + zero7;
                        for (int i = 0; i < Kimenet.Count; i++)
                        {
                            int corsor_p = Console.CursorTop;
                            Console.ForegroundColor = ConsoleColor.Green;
                            //műveletek: látszat
                            if (van_s)
                            {
                                Console.SetCursorPosition(0, corsor_p);
                                Console.Write(Kimenet[i].Split(';')[0]);
                            }
                            if (van_j)
                            {
                                Console.SetCursorPosition(zero0, corsor_p);
                                Console.Write(Kimenet[i].Split(';')[1]);
                            }
                            if (van_n)
                            {
                                Console.SetCursorPosition(zero1, corsor_p);
                                Console.Write(Kimenet[i].Split(';')[2]);
                            }
                            if (van_p)
                            {
                                Console.SetCursorPosition(zero2, corsor_p);
                                Console.Write(Kimenet[i].Split(';')[3]);
                            }
                            if (van_cs)
                            {
                                Console.SetCursorPosition(zero3, corsor_p);
                                Console.Write(Kimenet[i].Split(';')[4]);
                            }
                            if (van_c)
                            {
                                Console.SetCursorPosition(zero4, corsor_p);
                                Console.Write(Kimenet[i].Split(';')[5]);
                            }
                            if (van_k)
                            {
                                Console.SetCursorPosition(zero5, corsor_p);
                                Console.Write(Kimenet[i].Split(';')[6]);
                            }
                            if (van_sz)
                            {
                                Console.SetCursorPosition(zero6, corsor_p);
                                Console.Write(Kimenet[i].Split(';')[7]);
                            }
                            if (van_mp)
                            {
                                Console.SetCursorPosition(zero7, corsor_p);
                                Console.Write(Kimenet[i].Split(';')[8]);
                            }
                            if (van_st)
                            {
                                Console.SetCursorPosition(zero8, corsor_p);
                                Console.Write(Kimenet[i].Split(';')[9]);
                            }
                            Console.WriteLine();



                        }
                    }
                    //kimenet reset
                    else
                    {
                        bevitel_elemek.Clear();
                        bevitel_elemek_értéke.Clear();
                        Kimenet.Clear();
                        for (int i = 0; i < állomány.Length; i++)
                        {
                            Kimenet.Add("" + i + ";" + Player[i] + ";" + Nation[i] + ";" + Pos[i] + ";" + Squad[i] + ";" + Comp[i] + ";" + Age[i] + ";" + Born[i] + ";" + MP[i] + ";" + Starts[i]);
                        }
                    }
                }
                    
            } while (bevitel != "kilépés");


            //program vége
            Console.ReadLine();


        }
        //hosszámítás
        static int[] zeroh(List<string> Kimenet)
        {
            int[] zeroh = new int[9] {0,0,0,0,0,0,0,0,0} ;
            for (int i = 0; i < Kimenet.Count; i++)
            {
                if (Kimenet[i].Split(';')[0].Length > zeroh[0])
                {
                    zeroh[0] = Kimenet[i].Split(';')[0].Length +4;
                }
                if (Kimenet[i].Split(';')[1].Length > zeroh[1])
                {
                    zeroh[1] = Kimenet[i].Split(';')[1].Length + 4;
                }
                if (Kimenet[i].Split(';')[2].Length > zeroh[2])
                {
                    zeroh[2] = Kimenet[i].Split(';')[2].Length + 4;
                }
                if (Kimenet[i].Split(';')[3].Length > zeroh[3])
                {
                    zeroh[3] = Kimenet[i].Split(';')[3].Length + 4;
                }
                if (Kimenet[i].Split(';')[4].Length > zeroh[4])
                {
                    zeroh[4] = Kimenet[i].Split(';')[4].Length + 4;
                }
                if (Kimenet[i].Split(';')[5].Length > zeroh[5])
                {
                    zeroh[5] = Kimenet[i].Split(';')[5].Length + 4;
                }
                if (Kimenet[i].Split(';')[6].Length > zeroh[6])
                {
                    zeroh[6] = Kimenet[i].Split(';')[6].Length + 4;
                }
                if (Kimenet[i].Split(';')[7].Length > zeroh[7])
                {
                    zeroh[7] = Kimenet[i].Split(';')[7].Length + 4;
                }
                if (Kimenet[i].Split(';')[8].Length > zeroh[8])
                {
                    zeroh[8] = Kimenet[i].Split(';')[8].Length + 4;
                }

            }
            return zeroh;
        }
        //műveletek: keresés
        static List<string> sorszám_(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            if (bevitel_elemek_értéke == "n")
            {
                List<string> uj = new List<string>();
                List<int> list = new List<int>();
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    list.Add(int.Parse(Kimenet[i].Split(';')[0]));
                }
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    uj.Add(Kimenet[list.IndexOf(list.Max())]);
                    list[list.IndexOf(list.Max())] = -1;
                }
                return uj;
            }
            else
            {
                List<string> uj = new List<string>();
                List<int> list = new List<int>();
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    list.Add(int.Parse(Kimenet[i].Split(';')[0]));
                }
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    uj.Add(Kimenet[list.IndexOf(list.Min())]);
                    list[list.IndexOf(list.Min())] = list.Max() + 1;
                }
                return uj;
            }

        }
        static List<string> neve_(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            if (bevitel_elemek_értéke == "n")
            {
                string abc = "aábcdeéfghiíjklnmoóöőpqrstuúüűvwxyz";
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    int van = -1;
                    for (int j = i; j > -1; j--)
                    {


                        if (abc.IndexOf(Convert.ToChar(Kimenet[i].Split(';')[1][0]).ToString().ToLower()) > abc.IndexOf(Convert.ToChar(Kimenet[j].Split(';')[1][0]).ToString().ToLower()))
                        {
                            van = j;
                        }

                    }
                    if (i != Kimenet.Count && van != -1)
                    {
                        string ideiglenes = Kimenet[i];
                        Kimenet.Remove(Kimenet[i]);
                        Kimenet.Insert(van, ideiglenes);

                    }

                }
                return Kimenet;
            }
            else
            {
                string abc = "aábcdeéfghiíjklnmoóöőpqrstuúüűvwxyz";
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    int van = -1;
                    for (int j = i; j > -1; j--)
                    {


                        if (abc.IndexOf(Convert.ToChar(Kimenet[i].Split(';')[1][0]).ToString().ToLower()) < abc.IndexOf(Convert.ToChar(Kimenet[j].Split(';')[1][0]).ToString().ToLower()))
                        {
                            van = j;
                        }

                    }
                    if (i != Kimenet.Count && van != -1)
                    {
                        string ideiglenes = Kimenet[i];
                        Kimenet.Remove(Kimenet[i]);
                        Kimenet.Insert(van, ideiglenes);

                    }

                }
                return Kimenet;
            }

        }
        static List<string> nemzet_(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            if (bevitel_elemek_értéke == "n")
            {
                string abc = "aábcdeéfghiíjklnmoóöőpqrstuúüűvwxyz";
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    int van = -1;
                    for (int j = i; j > -1; j--)
                    {


                        if (abc.IndexOf(Convert.ToChar(Kimenet[i].Split(';')[2][0]).ToString().ToLower()) > abc.IndexOf(Convert.ToChar(Kimenet[j].Split(';')[2][0]).ToString().ToLower()))
                        {
                            van = j;
                        }

                    }
                    if (i != Kimenet.Count && van != -1)
                    {
                        string ideiglenes = Kimenet[i];
                        Kimenet.Remove(Kimenet[i]);
                        Kimenet.Insert(van, ideiglenes);

                    }

                }
                return Kimenet;
            }
            else
            {
                string abc = "aábcdeéfghiíjklnmoóöőpqrstuúüűvwxyz";
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    int van = -1;
                    for (int j = i; j > -1; j--)
                    {


                        if (abc.IndexOf(Convert.ToChar(Kimenet[i].Split(';')[2][0]).ToString().ToLower()) < abc.IndexOf(Convert.ToChar(Kimenet[j].Split(';')[2][0]).ToString().ToLower()))
                        {
                            van = j;
                        }

                    }
                    if (i != Kimenet.Count && van != -1)
                    {
                        string ideiglenes = Kimenet[i];
                        Kimenet.Remove(Kimenet[i]);
                        Kimenet.Insert(van, ideiglenes);

                    }

                }
                return Kimenet;
            }

        }
        static List<string> poszt_(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            if (bevitel_elemek_értéke == "n")
            {
                string abc = "aábcdeéfghiíjklnmoóöőpqrstuúüűvwxyz";
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    int van = -1;
                    for (int j = i; j > -1; j--)
                    {


                        if (abc.IndexOf(Convert.ToChar(Kimenet[i].Split(';')[3][0]).ToString().ToLower()) > abc.IndexOf(Convert.ToChar(Kimenet[j].Split(';')[3][0]).ToString().ToLower()))
                        {
                            van = j;
                        }

                    }
                    if (i != Kimenet.Count && van != -1)
                    {
                        string ideiglenes = Kimenet[i];
                        Kimenet.Remove(Kimenet[i]);
                        Kimenet.Insert(van, ideiglenes);

                    }

                }
                return Kimenet;
            }
            else
            {
                string abc = "aábcdeéfghiíjklnmoóöőpqrstuúüűvwxyz";
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    int van = -1;
                    for (int j = i; j > -1; j--)
                    {


                        if (abc.IndexOf(Convert.ToChar(Kimenet[i].Split(';')[3][0]).ToString().ToLower()) < abc.IndexOf(Convert.ToChar(Kimenet[j].Split(';')[3][0]).ToString().ToLower()))
                        {
                            van = j;
                        }

                    }
                    if (i != Kimenet.Count && van != -1)
                    {
                        string ideiglenes = Kimenet[i];
                        Kimenet.Remove(Kimenet[i]);
                        Kimenet.Insert(van, ideiglenes);

                    }

                }
                return Kimenet;
            }

        }
        static List<string> csapat_(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            if (bevitel_elemek_értéke == "n")
            {
                string abc = "aábcdeéfghiíjklnmoóöőpqrstuúüűvwxyz";
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    int van = -1;
                    for (int j = i; j > -1; j--)
                    {


                        if (abc.IndexOf(Convert.ToChar(Kimenet[i].Split(';')[4][0]).ToString().ToLower()) > abc.IndexOf(Convert.ToChar(Kimenet[j].Split(';')[4][0]).ToString().ToLower()))
                        {
                            van = j;
                        }

                    }
                    if (i != Kimenet.Count && van != -1)
                    {
                        string ideiglenes = Kimenet[i];
                        Kimenet.Remove(Kimenet[i]);
                        Kimenet.Insert(van, ideiglenes);

                    }

                }
                return Kimenet;
            }
            else
            {
                string abc = "aábcdeéfghiíjklnmoóöőpqrstuúüűvwxyz";
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    int van = -1;
                    for (int j = i; j > -1; j--)
                    {


                        if (abc.IndexOf(Convert.ToChar(Kimenet[i].Split(';')[4][0]).ToString().ToLower()) < abc.IndexOf(Convert.ToChar(Kimenet[j].Split(';')[4][0]).ToString().ToLower()))
                        {
                            van = j;
                        }

                    }
                    if (i != Kimenet.Count && van != -1)
                    {
                        string ideiglenes = Kimenet[i];
                        Kimenet.Remove(Kimenet[i]);
                        Kimenet.Insert(van, ideiglenes);

                    }

                }
                return Kimenet;
            }

        }
        static List<string> comp_(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            if (bevitel_elemek_értéke == "n")
            {
                string abc = "aábcdeéfghiíjklnmoóöőpqrstuúüűvwxyz";
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    int van = -1;
                    for (int j = i; j > -1; j--)
                    {


                        if (abc.IndexOf(Convert.ToChar(Kimenet[i].Split(';')[5][0]).ToString().ToLower()) > abc.IndexOf(Convert.ToChar(Kimenet[j].Split(';')[5][0]).ToString().ToLower()))
                        {
                            van = j;
                        }

                    }
                    if (i != Kimenet.Count && van != -1)
                    {
                        string ideiglenes = Kimenet[i];
                        Kimenet.Remove(Kimenet[i]);
                        Kimenet.Insert(van, ideiglenes);

                    }

                }
                return Kimenet;
            }
            else
            {
                string abc = "aábcdeéfghiíjklnmoóöőpqrstuúüűvwxyz";
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    int van = -1;
                    for (int j = i; j > -1; j--)
                    {


                        if (abc.IndexOf(Convert.ToChar(Kimenet[i].Split(';')[5][0]).ToString().ToLower()) < abc.IndexOf(Convert.ToChar(Kimenet[j].Split(';')[5][0]).ToString().ToLower()))
                        {
                            van = j;
                        }

                    }
                    if (i != Kimenet.Count && van != -1)
                    {
                        string ideiglenes = Kimenet[i];
                        Kimenet.Remove(Kimenet[i]);
                        Kimenet.Insert(van, ideiglenes);

                    }

                }
                return Kimenet;
            }

        }
        static List<string> kora_(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            if (bevitel_elemek_értéke == "n")
            {
                List<string> uj = new List<string>();
                List<int> list = new List<int>();
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    list.Add(int.Parse(Kimenet[i].Split(';')[6]));
                }
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    uj.Add(Kimenet[list.IndexOf(list.Max())]);
                    list[list.IndexOf(list.Max())] = -1;
                }
                return uj;
            }
            else
            {
                List<string> uj = new List<string>();
                List<int> list = new List<int>();
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    list.Add(int.Parse(Kimenet[i].Split(';')[6]));
                }
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    uj.Add(Kimenet[list.IndexOf(list.Min())]);
                    list[list.IndexOf(list.Min())] = list.Max() + 1;
                }
                return uj;
            }

        }
        static List<string> születés_(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            if (bevitel_elemek_értéke == "n")
            {
                List<string> uj = new List<string>();
                List<int> list = new List<int>();
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    list.Add(int.Parse(Kimenet[i].Split(';')[7]));
                }
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    uj.Add(Kimenet[list.IndexOf(list.Max())]);
                    list[list.IndexOf(list.Max())] = -1;
                }
                return uj;
            }
            else
            {
                List<string> uj = new List<string>();
                List<int> list = new List<int>();
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    list.Add(int.Parse(Kimenet[i].Split(';')[7]));
                }
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    uj.Add(Kimenet[list.IndexOf(list.Min())]);
                    list[list.IndexOf(list.Min())] = list.Max() + 1;
                }
                return uj;
            }

        }
        static List<string> MP__(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            if (bevitel_elemek_értéke == "n")
            {
                List<string> uj = new List<string>();
                List<int> list = new List<int>();
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    list.Add(int.Parse(Kimenet[i].Split(';')[8]));
                }
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    uj.Add(Kimenet[list.IndexOf(list.Max())]);
                    list[list.IndexOf(list.Max())] = -1;
                }
                return uj;
            }
            else
            {
                List<string> uj = new List<string>();
                List<int> list = new List<int>();
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    list.Add(int.Parse(Kimenet[i].Split(';')[8]));
                }
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    uj.Add(Kimenet[list.IndexOf(list.Min())]);
                    list[list.IndexOf(list.Min())] = list.Max() + 1;
                }
                return uj;
            }

        }
        static List<string> Starts__(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            if (bevitel_elemek_értéke == "n")
            {
                List<string> uj = new List<string>();
                List<int> list = new List<int>();
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    list.Add(int.Parse(Kimenet[i].Split(';')[9]));
                }
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    uj.Add(Kimenet[list.IndexOf(list.Max())]);
                    list[list.IndexOf(list.Max())] = -1;
                }
                return uj;
            }
            else
            {
                List<string> uj = new List<string>();
                List<int> list = new List<int>();
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    list.Add(int.Parse(Kimenet[i].Split(';')[9]));
                }
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    uj.Add(Kimenet[list.IndexOf(list.Min())]);
                    list[list.IndexOf(list.Min())] = list.Max() + 1;
                }
                return uj;
            }

        }



        //műveletek: szortírozás
        static List<string> sorszám(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            List<string> uj = new List<string>();
            if (bevitel_elemek_értéke.Contains('-'))
            {
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    if (int.Parse(Kimenet[i].Split(';')[0]) >= int.Parse(bevitel_elemek_értéke.Split('-')[0]) && int.Parse(Kimenet[i].Split(';')[0]) <= int.Parse(bevitel_elemek_értéke.Split('-')[1]))
                    {
                        uj.Add(Kimenet[i]);
                    }
                }
            }
            else
            {
                uj.Add(Kimenet[int.Parse(bevitel_elemek_értéke)]);
            }
            return uj;
        }
        static List<string> neve(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            List<string> uj = new List<string>();
            for (int i = 0; i < Kimenet.Count; i++)
            {
                if (Kimenet[i].Split(';')[1].ToLower().Contains(bevitel_elemek_értéke.ToLower()))
                {
                    uj.Add(Kimenet[i]);
                }
            }
            return uj;
        }
        static List<string> nemzet(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            List<string> uj = new List<string>();
            for (int i = 0; i < Kimenet.Count; i++)
            {
                if (Kimenet[i].Split(';')[2].ToLower() == bevitel_elemek_értéke.ToLower())
                {
                    uj.Add(Kimenet[i]);
                }
            }
            return uj;
        }
        static List<string> poszt(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            List<string> uj = new List<string>();
            for (int i = 0; i < Kimenet.Count; i++)
            {
                if (Kimenet[i].Split(';')[3] == bevitel_elemek_értéke)
                {
                    uj.Add(Kimenet[i]);
                }
            }
            return uj;
        }
        static List<string> csapat(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            List<string> uj = new List<string>();
            for (int i = 0; i < Kimenet.Count; i++)
            {
                if (Kimenet[i].Split(';')[4].ToLower().Contains(bevitel_elemek_értéke.ToLower()))
                {
                    uj.Add(Kimenet[i]);
                }
            }
            return uj;
        }
        static List<string> comp(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            List<string> uj = new List<string>();
            for (int i = 0; i < Kimenet.Count; i++)
            {
                if (Kimenet[i].Split(';')[5].ToLower().Contains(bevitel_elemek_értéke.ToLower()))
                {
                    uj.Add(Kimenet[i]);
                }
            }
            return uj;
        }
        static List<string> kora(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            List<string> uj = new List<string>();
            if (bevitel_elemek_értéke.Contains('-'))
            {
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    if (int.Parse(Kimenet[i].Split(';')[6]) >= int.Parse(bevitel_elemek_értéke.Split('-')[0]) && int.Parse(Kimenet[i].Split(';')[6]) <= int.Parse(bevitel_elemek_értéke.Split('-')[1]))
                    {
                        uj.Add(Kimenet[i]);
                    }
                }
            }
            else
            {
                uj = Kimenet.FindAll(elem => elem.Split(';')[6].Contains(bevitel_elemek_értéke.ToString()));
            }
            return uj;
        }
        static List<string> születés(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            List<string> uj = new List<string>();
            if (bevitel_elemek_értéke.Contains('-'))
            {
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    if (int.Parse(Kimenet[i].Split(';')[7]) >= int.Parse(bevitel_elemek_értéke.Split('-')[0]) && int.Parse(Kimenet[i].Split(';')[7]) <= int.Parse(bevitel_elemek_értéke.Split('-')[1]))
                    {
                        uj.Add(Kimenet[i]);
                    }
                }
            }
            else
            {
                uj = Kimenet.FindAll(elem => elem.Split(';')[7].Contains(bevitel_elemek_értéke.ToString()));
            }
            return uj;
        }
        static List<string> MP_(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            List<string> uj = new List<string>();
            if (bevitel_elemek_értéke.Contains('-'))
            {
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    if (int.Parse(Kimenet[i].Split(';')[8]) >= int.Parse(bevitel_elemek_értéke.Split('-')[0]) && int.Parse(Kimenet[i].Split(';')[8]) <= int.Parse(bevitel_elemek_értéke.Split('-')[1]))
                    {
                        uj.Add(Kimenet[i]);
                    }
                }
            }
            else
            {
                uj = Kimenet.FindAll(elem => elem.Split(';')[8].Contains(bevitel_elemek_értéke.ToString()));
            }
            return uj;
        }
        static List<string> Starts_(List<string> Kimenet, string bevitel_elemek_értéke)
        {
            List<string> uj = new List<string>();
            if (bevitel_elemek_értéke.Contains('-'))
            {
                for (int i = 0; i < Kimenet.Count; i++)
                {
                    if (int.Parse(Kimenet[i].Split(';')[9]) >= int.Parse(bevitel_elemek_értéke.Split('-')[0]) && int.Parse(Kimenet[i].Split(';')[9]) <= int.Parse(bevitel_elemek_értéke.Split('-')[1]))
                    {
                        uj.Add(Kimenet[i]);
                    }
                }
            }
            else
            {
                uj = Kimenet.FindAll(elem => elem.Split(';')[9].Contains(bevitel_elemek_értéke.ToString()));
            }
            return uj;
        }


    }
}
