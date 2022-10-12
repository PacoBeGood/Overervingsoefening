using System;

Voertuig voertuig = new Voertuig();
Auto auto = new Auto();
Vliegtuig vliegtuig = new Vliegtuig();
Boot boot = new Boot();

Console.WriteLine("Info over het object voertuig van de klasse Voertuig:");
Console.WriteLine(voertuig.AsText());
Console.WriteLine();

Console.WriteLine("Info over het object auto van de klasse Auto:");
Console.WriteLine(auto.AsText());
Console.WriteLine();

Console.WriteLine("Info over het object vliegtuig van de klasse Vliegtuig:");
Console.WriteLine(vliegtuig.AsText());
Console.WriteLine();

Console.WriteLine("Info over het object boot van de klasse boot:");
Console.WriteLine(boot.AsText());
Console.ReadKey();

class Voertuig
{
    public int wielen { get; set; }
    public bool KanVliegen { get; set; }
    public bool KanVaren { get; set; }

    public string AsText()
    {
        string vliegen = "kan niet vliegen";
        if (KanVliegen)
        {
            vliegen = "kan vliegen";

        }
        string varen = "kan niet varen";
        if (KanVaren)
        {
            varen = "kan varen";

        }
        return "dit voertuig heeft " + wielen + " wielen, " + vliegen + " en " + varen;

    }

}

class Auto : Voertuig
{


    public Auto()
    {
        wielen = 4;
        KanVliegen = false;
        KanVaren = false;

    }

    public string Talk()
    {
        return "tuut tuut";
    }
}
class Vliegtuig : Voertuig
{


    public Vliegtuig()
    {
        wielen = 6;
        KanVliegen = true;
        KanVaren = false;

    }


}
class Boot : Voertuig
{


    public Boot()
    {
        wielen = 0;
        KanVliegen = false;
        KanVaren = true;

    }


}



