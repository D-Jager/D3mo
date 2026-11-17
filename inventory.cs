using UnityEngine;

public class inventory : MonoBehaviour
{
int zuurstof = 0;
int breakgroen = 5;
int brandstof = 0;
int breakrood = 3;
int maansteen = 0;
int breakwit = 12;
int sterrenstof = 0;
int breakpaars = 7;

// de breaks kunnen whatever zijn, ze zijn gewoon voorbeeld van wat het moet zijn.
//zo lang dat ze maar gelinkt zijn aan de asteroïde die gebroken word, anders werkt dit helemaal niet meer. -Dean
void update ()
{
for (int i = 0; breakgroen > 0; i++)
{
    breakgroen--;
    zuurstof++;
}
    Console.WriteLine(zuurstof);

    for (int i = 0; breakrood > 0; i++)
{
    breakrood--;
    brandstof++;
}
    Console.WriteLine(brandstof);

    for (int i = 0; breakwit > 0; i++)
{
    breakwit--;
    maansteen++;
}
    Console.WriteLine(maansteen);

    for (int i = 0; breakpaars > 0; i++)
{
    breakpaars--;
    sterrenstof++;
}
    Console.WriteLine(sterrenstof);
}
}