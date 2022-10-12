using System;

class voertuig
{
    public int wielen {get; set;}
    public bool KanVliegen {get; set;}
    public bool KanVaren {get; set;}

    public string AsText()
    {
        string vliegen = "kan niet vliegen";
        if (KanVliegen){
            vliegen = "kan vliegen";

        }
         string varen = "kan niet varen";
        if (KanVaren){
            varen = "kan varen";

        }
        return "dit voertuig heeft " + wielen + " wielen, " + vliegen + " en " + varen;

    }

}

class auto : voertuig
{
    

    public auto ()
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
class vliegtuig : voertuig
{
    

    public vliegtuig ()
    {
        wielen = 6;
        KanVliegen = true;
        KanVaren = false;
        
    }

   
}
class boot : voertuig
{
    

    public boot ()
    {
        wielen = 0;
        KanVliegen = false;
        KanVaren = true;
        
    }

   
}

class Program
{
    static void Main(string[] args)
    {
        
        voertuig voertuig = new voertuig();
        auto auto = new auto();
        vliegtuig vliegtuig = new vliegtuig();
        boot boot = new boot();

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
    }
}