
using System;

Console.WriteLine("Enter Username");
string userName = Console.ReadLine();
Console.WriteLine("Username is: " + userName);
Console.WriteLine("How old are you?!!!!!!!!!!!!!!!!");
int alter = 0;
alter = Int32.Parse(Console.ReadLine());
if  (alter < 18)
{
    Console.WriteLine("Nicht alt genug");
}else if (alter > 18)
{
    Console.WriteLine("Du Bist alt genug");
}
Console.WriteLine("Supper dann darfst du diesen Kontent gucken!!!");
