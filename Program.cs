//EINGABE
//Testnummer: 308342310318769

var input = "";

while (true)
{
    Console.Write("Bitte 15 stellige Payback-Kartennummer eingeben: ");
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
for (var i = 0; i < sequence.Length; i++)
{
    //Console.Write($"{sequence[i]} = ");
    if (i % 2 == 0)
    {
        sequence[i] *= 2;
    }
    //Console.WriteLine($"{sequence[i]},");
}

//Quersumme bilden
var sum = 0;
for (var i = 0; i < sequence.Length; i++)
{
    //Console.WriteLine($"{sum} + {sequence[i]},");
    if (sequence[i] > 9)
    {
        sum += sequence[i] - 9;
    }
    else
    {
          sum += sequence[i];
    }
  
}

//Prüfziffer berechnen
var checkNum = 10 - sum % 10;

//AUSGABE
Console.WriteLine($"Prüfziffer für {input} ist {checkNum}.");