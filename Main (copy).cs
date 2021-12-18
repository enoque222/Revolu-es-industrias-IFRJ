using System; 

public class Program {

  public static void Main() {
	Console.Clear();
	ConsoleKeyInfo tecla;
	tecla = Console.ReadKey();
    //Console.WriteLine(tecla.Key.ToString());
	Console.WriteLine("");
	if(tecla.Key == ConsoleKey.Enter) {
		Console.WriteLine("Voce apertou o Enter");
	}
	//UpArrow DownArrow
  }
}