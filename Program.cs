//EINGABE
//Testnummer: 276101123456789

var input = "";

while (true)
{
    Console.Write("Bitte 15 stellige UPN eingeben: ");
    input = Console.ReadLine();

    if (input != null && input.Length == 15)
    {
        break;
    }
    Console.WriteLine($"Bitte erneut eingeben. Aktuell {input!.Length}/15 Ziffern");
}

//VERARBEITUNG

var sequence = new int[input.Length];
for (var i = 0; i < input.Length; i++)
{
    var parsed = int.Parse(input[i].ToString());
    //Console.Write($"{input[i]} = {parsed}, ");
    sequence[i] = parsed;
}

//Gewichtung der Ziffern
var sum = 0;
var prod = 10;
for (var i = 0; i < sequence.Length; i++)
{
    sum = (prod + sequence[i]) % 10;
    if (sum == 0)
    {
        sum = 10;
    }
    prod = (2 * sum) % 11;
}

//Prüfziffer berechnen
var checkNum = 11 - prod;

//AUSGABE
Console.WriteLine($"Prüfziffer für {input} ist {checkNum}.");