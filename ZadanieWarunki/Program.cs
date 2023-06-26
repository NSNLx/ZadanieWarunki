//1
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
Console.WriteLine("podaj numer zadania");
int zadanie=Convert.ToInt32(Console.ReadLine());
switch (zadanie) {
    case 1:
int a = 5;
int b = 5;
if(a == b)
{
    Console.WriteLine("5 i 5 sq równe");
}
        break;
//2
case 2:
Console.WriteLine("Podaj liczbę");
int liczba = Convert.ToInt32(Console.ReadLine());
if(liczba%2==0)
{
    Console.WriteLine(liczba+" jest podzielna przez 2");
}
else
{
    Console.WriteLine(liczba + " nie jest podzielna przez 2");
}
        break;
//3
case 3:
Console.WriteLine("Podaj liczbę");
int liczba0 = Convert.ToInt32(Console.ReadLine());
if (liczba0<0)
{
    Console.WriteLine(liczba0 + " jest ujemna");
}
else if (liczba0 == 0) { Console.WriteLine("liczba jest neutralna"); }
else
{
    Console.WriteLine(liczba0 + " jest dodatnia");
}
        break;
//4
case 4:
Console.WriteLine("Podaj rok");
int rok = Convert.ToInt32(Console.ReadLine());
if (rok % 4 == 0 || rok%100==0)
{
    Console.WriteLine(rok + " rok jest przystepny");
}
else
{
    Console.WriteLine(rok + " rok nie jest przystepny");
}
        break;
//5
case 5:
Console.WriteLine("Podaj swój wiek");
int wiek= Convert.ToInt32(Console.ReadLine());
if (wiek >= 21 && wiek < 29)
{
    Console.WriteLine("możesz zostać posłem");
}
else if (wiek >= 30 && wiek < 35)
{
    Console.WriteLine("możesz zostać posłem i senatorem");
}
else if (wiek>=35)
{
    Console.WriteLine("możesz zostać posłem, senatorem i prezydentem");
}
else { Console.WriteLine("możesz zostać nikim"); }
        break;
//6
case 6:
Console.WriteLine("Podaj swój wzrost");
int wzrost = Convert.ToInt32(Console.ReadLine());
if (wzrost >= 140 && wzrost < 172)
{
    Console.WriteLine("jesteś niski");
}
else if (wzrost >= 172 && wzrost < 184)
{
    Console.WriteLine("jesteś git");
}
else if (wzrost >= 184)
{
    Console.WriteLine("jesteś wysoki");
}
else { Console.WriteLine("dziwny jesteś"); }
        break;
//7
case 7:
Console.WriteLine("Podaj 3 liczbt");
int numer0= Convert.ToInt32(Console.ReadLine());
int numer1 = Convert.ToInt32(Console.ReadLine());
int numer2 = Convert.ToInt32(Console.ReadLine());
if (numer0 > numer1 && numer0 > numer2)
{
    Console.WriteLine("pierwszy numer jest najwiekszy");
}
else if (numer1 > numer0 && numer0 > numer2)
{
    Console.WriteLine(" drugi numer jest najwiekszy");
}
else if (numer2 > numer1 && numer0 > numer2)
{
    Console.WriteLine(" trzeci numer jest najwiekszy");
}
        break;
//8
case 8:
        Console.WriteLine("sprawdź, czy nadasz się na studia");
        Console.WriteLine("Podaj wynik matury z matematyki");
        int matematyka= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj wynik matury z fizyki");
        int fizyka = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj wynik matury z chemii");
        int chemia = Convert.ToInt32(Console.ReadLine());
        if (matematyka > 70 && chemia > 45 && fizyka > 55) {Console.WriteLine("zostaniesz dopuszczony na studia");}
        else if ((matematyka + chemia + fizyka) > 180) { Console.WriteLine("zostaniesz dopuszczony na studia"); }
        else if (matematyka + chemia > 150) { Console.WriteLine("zostaniesz dopuszczony na studia"); }
        else if (matematyka + fizyka > 150) { Console.WriteLine("zostaniesz dopuszczony na studia"); }
        else { Console.WriteLine("nie nadajesz się"); }

        break;
    //9
case 9:
        Console.WriteLine("podaj temperaturę w stopniach Celsjusza");
        int temperatura= Convert.ToInt32(Console.ReadLine());
        if (temperatura < 0) { Console.WriteLine("cholernie piździ"); }
        if (temperatura <= 0&& temperatura>10) { Console.WriteLine("zimno"); }
        if (temperatura <= 10 && temperatura > 20) { Console.WriteLine("chłodno"); }
        if (temperatura <= 20 && temperatura > 30) { Console.WriteLine("w sam raz"); }
        if (temperatura <= 30 && temperatura > 40) { Console.WriteLine("zaczyna być słabo, bo gorąco"); }
        if (temperatura > 40) { Console.WriteLine("pierdolę, wyprowadzam się na Alaskę"); }
        break;
//10
case 10:
        Console.WriteLine("podaj pierwszą krawędź trójkąta");
        int pierwszaKrawedz= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("podaj drugą krawędź trójkąta");
        int drugaKrawedz = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("podaj trzecią krawędź trójkąta");
        int trzeciaKrawedz = Convert.ToInt32(Console.ReadLine());

        var krawedzie = new List<int>()
                    {                        
                        pierwszaKrawedz,
                        drugaKrawedz,
                        trzeciaKrawedz
                    };
        var maxKrawedz = krawedzie.Max();
        if (maxKrawedz <= pierwszaKrawedz + drugaKrawedz + trzeciaKrawedz-maxKrawedz) { Console.WriteLine("można zbudować trójkąt"); }
        else { Console.WriteLine("nie można zbudować trójkąta"); }
        break;
    //11
    case 11:
        Console.WriteLine("podaj ocenę, asie");
        int ocena= Convert.ToInt32(Console.ReadLine());
        switch (ocena)
        {
        case 1:
        Console.WriteLine("niedostateczny"); 
        break;
            case 2:
                Console.WriteLine("dopuszczający");
                break;
            case 3:
                Console.WriteLine("dostateczny");
                break;
            case 4:
                Console.WriteLine("dobry");
                break;
            case 5:
                Console.WriteLine("bardzo dobry");
                break;
            case 6:
                Console.WriteLine("celujący");
                break;
        }
        break;


    //13
    case 13:
        Console.WriteLine("podaj pierwszą liczbę");
        double liczbaA= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("podaj drugą liczbę");
        double liczbaB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("podaj numer operacji do wykonania:");
        Console.WriteLine("1. dodawanie");
        Console.WriteLine("2. odejmowanie");
        Console.WriteLine("3. mnożenie");
        Console.WriteLine("4. dzielenie");
        string akcja = Convert.ToString(Console.ReadLine());
        switch (akcja)
        {
            case "1": {  Console.WriteLine(liczbaA+liczbaB); break; }
            case "2": { Console.WriteLine(liczbaA - liczbaB); break; }
            case "3": { Console.WriteLine(liczbaA * liczbaB); break; }
            case "4": { Console.WriteLine(liczbaA / liczbaB); break; }
            default: Console.WriteLine("coś nie tak");
                break;
        }

        break;

        default: Console.WriteLine("nie ma czegos takiego");
        break;
}
