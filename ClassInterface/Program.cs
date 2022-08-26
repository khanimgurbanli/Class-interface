using ClassInterface.Models;
class Program
{
    static void Main()
    {
        Cello instrumentCello = new Cello("Cello","Montagnana", "Cello Jeas", 1.017, "Excellent", "The earliest cellos were developed during the 16th century", 3.1, 1.34);
        Clarinet instrumentClarinet = new Clarinet("Clarinet", "Director Bass Clarinet in Bb", "Contralto Clarinets", 541, " Mouthpieces", "The clarinet is a relative newcomer among woodwind instruments", "Black", 1.01);
        Violin instrumentViolin = new Violin("Violin", "Snare Drum CSS-A", "Brand", 870, "Excellent", "The violin was first known in 16th-century Italy", "Avaneeswaram S R Vinu");
        Guitar instrumentGuitar = new Guitar("Guitar", "SuperModel", "Brand", 2.121, "Excellent", "The violin was first known in 16th-century", "Plectrum");
        GetInstrument(instrumentCello);
        GetInstrument(instrumentClarinet);
        GetInstrument(instrumentViolin);
        GetInstrument(instrumentGuitar);

    }

    static void GetInstrument<T>(T instrumnet)
    {
        if (instrumnet.GetType() == typeof(T))
        {
            Console.WriteLine("\n  Instrumnet name: " + instrumnet.GetType().Name + "\n" + "\nProperities: \n");
            foreach (var item in instrumnet.GetType().GetProperties())
                Console.WriteLine(item.Name + " - " + item.GetValue(instrumnet));
        }
    }
}

