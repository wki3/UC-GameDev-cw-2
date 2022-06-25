

string heroName = "OREO OO";
int heroPower = 303;

string villainName = "Zahra aa";
int villainPower = 812;

if (heroPower < villainPower)
{
    Console.WriteLine("{0} is more powered than {1}", villainName , heroName);    
}
else if (heroPower > villainPower)
{
    Console.WriteLine("{1} is more powered than {0}", villainName, heroName);
}
else
{
    Console.WriteLine(" Both {0} and {1} have the same power", villainName, heroName);
}


