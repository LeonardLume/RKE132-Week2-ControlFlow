// See https://aka.ms/new-console-template for more information

//rakendus kusib kasutajal sisestada tema vanuse
//kui kasutaja vanus on vaiksem kui 13, siis konsoolis kuvatakase:
//"You are too young to use instagram"
//muul  juhul
//konsoolis kuvatakse "Welcome to Instagram"



Console.WriteLine("Enter your age");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber == true)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram!");
    }
    else
    {
        Console.WriteLine("YOu are too young to use instagram.");
    }
}
else
{
    Console.WriteLine("Could not read your age");
}
