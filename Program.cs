using System.Formats.Asn1;

Random rnd = new Random();
int talet = rnd.Next(1,101);
Console.WriteLine("Gissa ett tal");
int gissning = int.Parse(Console.ReadLine());
int försök = 0;
while(gissning != talet){
    if( gissning < talet ){
        Console.WriteLine("större");
    }
    else if( gissning > talet ){
        Console.WriteLine("mindre");
    }
    Console.WriteLine("Gissa en gång till");
    gissning = int.Parse(Console.ReadLine());
    försök++;
}
Console.WriteLine("Du fick rätt på " + (försök+1) + " försök");