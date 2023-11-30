[15:58] Paweł Klimczyk
/* Online C#
Compiler
and Editor */
using System.IO;
using System;
using System.Runtime.InteropServices;
 
class Program //komentarz jednolinijkowy
{
    static void Main()
    {
        // Console.WriteLine("Hello, World!");
        // Console.WriteLine("Jakis tekst");
        // Console.WriteLine(2+3);
        // Console.Write("abc");
        // Console.WriteLine("xyz");
        
        // int mojaLiczba = 10;
        // Console.WriteLine(mojaLiczba);
        // mojaLiczba=12;
        // Console.WriteLine(mojaLiczba);
        
        // string mojTekst = "jakis tekst do wyswietlenia";
        // Console.WriteLine(mojTekst);
        
        // const int jakasStala=12;
        
        // int x=10, y=12, z=14;
        // Console.WriteLine(x+y+z);
        
        // int a, b, c;
        // a=b=c=30;
        // Console.WriteLine(a+b+c);
        
        // int mojaliczba=20;
        
        // string userName=Console.ReadLine();
        // Console.WriteLine("Username: " + userName);
        
        // int userAge=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("User age: "+userAge);
        
        // int zmienna=0;
        // zmienna++;
        // Console.WriteLine(zmienna);
 
        // zmienna+=5;
        // Console.WriteLine(zmienna);
 
        // if (10>5) {
        //     Console.WriteLine("10 jest większe od 5");
        // }else{
        //     Console.WriteLine("10 nie jes większe od 5");
        // }
 
 
        // if(zmienna==0){
        //     Console.WriteLine("Zmienna == 0");
        // }else if(zmienna>6)
        // {
        //     Console.WriteLine("Zmienna jest większa od 0");
        // }else{
        //     Console.WriteLine("Zmienna jest mniejsza od 6");
        // }
        
        // // int i = 99999999;
        // // int j = 99999999;
        // // for(i=9999999;i>0;i--){
        // //     Console.WriteLine("#####################");
        // //     for(j=9999999;j>0;){
        // //         Console.WriteLine("#####################");
        // //     }
        // // }
 
        // int dzien=3;
 
        // switch(dzien){
        //     case 1:
        //         Console.WriteLine("Poniedziałek");
        //         break;
        //     case 2:
        //         Console.WriteLine("Wtorek");
        //         break;
        //     case 3:
        //         Console.WriteLine("Środa");
        //         break;
        //     case 4:
        //         Console.WriteLine("Czwartek");
        //         break;
        //     case 5:
        //         Console.WriteLine("Piątek");
        //         break;
        //     case 6:
        //         Console.WriteLine("Sobota");
        //         break;
        //     case 7:
        //         Console.WriteLine("Niedziela");
        //         break;
        //     default:
        //         Console.WriteLine("Nie ma takiego dnia tygodnia!");
        //         break;
        // }
        // int i=0;
        // while(i<4){
        //     Console.WriteLine(i);
        //     i++;
        // }
 
        // int p=0;
        // do{
        //     Console.WriteLine(p);
        //     p++;
        // }while(p<5);
 
        // for (int j=0;j<5;j++){
        //     Console.WriteLine(j);
        // }
        // int z = 0;
        // a=9999999;
        // for (int l=0;l<a;l++){
        //     for (int m=0;m<a;a++){
        //         Console.WriteLine("#");
        //     }
        // Console.WriteLine();
        // }
 
 
        Console.WriteLine("======================");
        Console.WriteLine("      KALKULATOR      ");
        Console.WriteLine("Bitte podaj first numero: ");
        int liczba1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please daj nummer segundo: ");
        int liczba2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Jakie acción wollen do (+,-,*,:,**,)?");
        var dzialanie=Console.ReadLine();
        Console.WriteLine("Dane podane poprawnie!");
        switch(dzialanie){
            case "+":
                Console.WriteLine("Wynik działania "+liczba1+"+"+liczba2+"="+(liczba1+liczba2));
                return;
            case "-":
                Console.WriteLine("Wynik działania "+liczba1+"-"+liczba2+"="+(liczba1-liczba2));
                return;
            case "*":
                Console.WriteLine("Wynik działania "+liczba1+"*"+liczba2+"="+(liczba1*liczba2));
                return;
            case ":":
                while (liczba2==0){
                    Console.WriteLine("Nie można dzielić przez 0! Podaj nowy dzielnik: ");
                    liczba2=Convert.ToInt32(Console.ReadLine());
                }
                    Console.WriteLine("Wynik działania "+liczba1+":"+liczba2+"="+(liczba1/liczba2));
                return;
            case "**":
                Console.WriteLine("Wynik działania "+liczba1+"**"+liczba2+"="+(liczba1^liczba2));
                return;
            case "":
                Console.WriteLine("Wynik działania "+liczba1+"**"+liczba2+"="+(liczba1^liczba2));
                return;
        }
 
        
    }
}