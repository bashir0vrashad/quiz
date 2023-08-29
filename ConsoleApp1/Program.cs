

string s1 = "Python dili necenci ilde yaradilmisdir?";
string s2 = "C++ dili necenci ilde yaradilmisdir?";
string s3 = "Java dili necenci ilde yaradilmisdir?";
string s4 = "C# dili necenci ilde yaradilmisdir?";
string s5 = "Php dili necenci ilde yaradilmisdir?";
string s6 = "Swift dili necenci ilde yaradilmisdir?";
string s7 = "C dili necenci ilde yaradilmisdir?";
string s8 = "Ruby dili necenci ilde yaradilmisdir?";
string s9 = "Javascript dili necenci ilde yaradilmisdir?";
string s10 = "Go dili necenci ilde yaradilmisdir?";


string[] suallar = { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10 };

string[][] cavablar = new string[10][]
{
  new string[]  {"1991" ,"1992" ,"1993" },
  new string[]  {"1983" ,"1984" ,"1985" },
 new string[]   {"1995" ,"1996" ,"1997" },
  new string[]  {"2001" ,"2002" ,"2003" },
 new string[]   {"1995" ,"1996" ,"1997" },
 new string[]   {"2014" ,"2015" ,"2016" },
 new string[]   {"1972" ,"1973" ,"1974" },
 new string[]   {"1995" ,"1996" ,"1997" },
 new string[]   {"1996" ,"1997" ,"1998" },
  new string[]  {"2009" ,"2010" ,"2011" }
};


static int[] randomlas(int say)
{
    int[] index = new int[say];
    int a;
    int h = 0;
    bool yoxla;

    while (h < say)
    {
        yoxla = true;
        a = Random.Shared.Next(0, say);
        if (h == 0) index[h] = a;
           
        for (int i = 0; i < h; i++)
        {
            if (index[i] == a) {
                yoxla = false;
                break;
            }
            else { if (i == h - 1) index[h] = a; }
        }
        if (yoxla == false) continue;
        h++;
    }
    return index;
}



static void show(string[] menyu, int a)
{
    for (int i = 0; i < 3; i++)
    {
        if (a == i) Console.ForegroundColor = ConsoleColor.Blue;
        else Console.ResetColor();
        Console.WriteLine(menyu[i]);
    }
}




int[] c= randomlas(10); // suallari randomlasdirma ucun
int[] u;
int xal = 0;


for (int i = 0; i < 10; i++)
{
    u = randomlas(3); // variantlari randomlasdirmaq ucun

    int a = 0;  // variantlar secilende  kursoru harda oldugunu bildirmek ucun

    while (true)
    {
        Console.Clear();
        Console.ResetColor();
        Console.WriteLine(suallar[c[i]]);

        string[] yeni=new string[3];
        for (int k = 0; k < 3; k++)
        {
            yeni[k] = cavablar[c[i]][u[k]];
        }
        show(yeni, a);
        var secim = Console.ReadKey();
        if (secim.Key == ConsoleKey.DownArrow)
        {
            if (a == 2) a = 0;
            else a++;
        }
        else if (secim.Key == ConsoleKey.UpArrow)
        {
            if (a == 0) a = 2;
            else a--;
        }


        if (secim.Key == ConsoleKey.Enter)
        {
            Console.ResetColor();
            Console.Clear();
            if (cavablar[c[i]][0] == yeni[a])
            {
                Console.WriteLine(suallar[c[i]]);
                for (int j = 0; j < 3; j++)
                {
                    if (j == a) Console.ForegroundColor = ConsoleColor.Green;
                    else Console.ResetColor();
                    Console.WriteLine(yeni[j]);
                }
                Console.ResetColor();
                Console.WriteLine("Tebrikler 10 xal qazandiniz.");
                xal += 10;
            }
            else
            {
                Console.WriteLine(suallar[c[i]]);
                for (int j = 0; j < 3; j++)
                {
                    if (j == a) Console.ForegroundColor = ConsoleColor.Red;
                    else Console.ResetColor();
                    Console.WriteLine(yeni[j]);
                }
                Console.ResetColor();
                Console.WriteLine("Tessuf olsun ki, 10 xal itirdiniz....");
                xal -= 10;
            }


            Thread.Sleep(1500);
           break;
        }
    }

    Console.Clear();
    Console.WriteLine(xal > 0 ? $"Neticeniz: {xal} xal" : "Neticeniz: 0 xal");

}











