
public class PowitaniaNazw
{
    private string imie;  // pole prywatne 

    
    public PowitaniaNazw(string imie) // Konstruktor klasy 
    {
        this.imie = imie;
    }
    
    // Metoda zwracająca funkcję (closure)
    public Func<string, string> GetNazwa()
    {
        return (nazwisko) => // Funkcja Lambda będąca closure
        {
            return $"{imie} {nazwisko}";
        };
    }
    
}

class Program
{
    static void Main()
    {
        // Tworzenie instancji klasy PowitaniaNazw
        PowitaniaNazw generatorImie = new PowitaniaNazw("Mateusz");
        PowitaniaNazw generatorImie2= new PowitaniaNazw("Grzegorz");
        // Pobieranie closure z instancji klasy
        
        Func<string, string> generatorNazwisko = generatorImie.GetNazwa();
        Func<string, string> generatorNazwisko2 = generatorImie2.GetNazwa();

        Console.WriteLine(generatorNazwisko("Kwiatkowski")); 
        Console.WriteLine(generatorNazwisko2("Strażak"));     
    }
}
