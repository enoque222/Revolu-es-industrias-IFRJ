using System; 

public class Program {


  //MAIN
  public static void Main() {
	inicio:
	ConsoleKeyInfo tecla, tecla2;
	Console.Clear();
	Console.WriteLine("Revolucoes industriais\n\n\n\nClique nesta tela azul e depois use a tecla para cima ou para baixo para selecionar.\n\n\n");
	Console.WriteLine(">>START<<  Aperte o enter ou clique para baixo");
	Console.WriteLine("SOBRE O PROGRAMA");

	tecla = Console.ReadKey();
    //Console.WriteLine(tecla.Key.ToString());
	Console.WriteLine("");
	if(tecla.Key == ConsoleKey.DownArrow) {
		fonte:
		Console.Clear();
		Console.WriteLine("Revolucoes industriais\n\n\n\nClique nesta tela azul e depois use a tecla para cima ou para baixo para selecionar.\n\n\n");
		Console.WriteLine("START");
		Console.WriteLine(">>SOBRE O PROGRAMA<<   Aperte o enter ou clique para cima");
		
		tecla2 = Console.ReadKey();
    
		if(tecla2.Key == ConsoleKey.UpArrow) {
			Console.Clear();
			goto inicio;
		}
		else if(tecla2.Key == ConsoleKey.Enter) {
			Console.Clear();
			Program.sp();
		}
		else {
			Console.Clear();
			goto fonte;
		}
	}
	else if(tecla.Key == ConsoleKey.Enter) {
		Program.jogo();
	}
	else {
		Console.Clear();
		goto inicio;
	}
	//UpArrow DownArrow
  }

  //JOGO
  static void jogo(){
	int uss = 0;

	inicio:

	Console.Clear();
	Console.WriteLine("1)Qual a contribuicao das principais invencoes da primeira revolucao industrial?\n\nA)O escoamento das materias primas\nB)Melhor qualidade de trabalho\nC)Melhoria do meio ambiente.");

	string r1 = Console.ReadLine();
	if(r1 == "A" | r1 == "a") {
		Console.Clear();
		Console.WriteLine("Resposta correta!\nAperte o Enter");
		Console.ReadKey();
		uss++;
	}
	else if(r1 == "B" | r1 == "b" | r1 == "C" | r1 == "c") {
		Console.Clear();
		Console.WriteLine("Resposta errada!\nAperte o Enter");
		Console.ReadKey();
	}
	else {
		Console.Clear();
		goto inicio;
	}

	inicio2:
	Console.Clear();
	Console.WriteLine("2)Qual invencao contribuiu para mudancas geograficas durante a segunda revolucao industrial?\n\nA)A construcao de ferrovias\nB)O desevolvimento da energia atomica\nC)A introducao do sistema de producao fordista.");

	 r1 = Console.ReadLine();
	if(r1 == "A" | r1 == "a") {
		Console.Clear();
		Console.WriteLine("Resposta correta!\nAperte o Enter");
		Console.ReadKey();
		uss++;
	}
	else if(r1 == "B" | r1 == "b" | r1 == "C" | r1 == "c") {
		Console.Clear();
		Console.WriteLine("Resposta errada!\nAperte o Enter");
		Console.ReadKey();
	}
	else {
		Console.Clear();
		goto inicio2;
	}

	inicio3:
	Console.Clear();
	Console.WriteLine("3)As invencoes de quais areas contribuiram para a modificacao geografica durante a terceira revolucao industrial?\n\nA)Informatica\nB)robotica\nC)Transporte.");

	 r1 = Console.ReadLine();
	if(r1 == "C" | r1 == "c") {
		Console.Clear();
		Console.WriteLine("Resposta correta!\nAperte o Enter");
		Console.ReadKey();
		uss++;
	}
	else if(r1 == "B" | r1 == "b" | r1 == "A" | r1 == "a") {
		Console.Clear();
		Console.WriteLine("Resposta errada!\nAperte o Enter");
		Console.ReadKey();
	}
	else {
		Console.Clear();
		goto inicio3;
	}

	d:

	Console.Clear();
	Console.WriteLine("Parabens voce acertou {0} perguntas\n\nAperte o Enter para voltar.",uss);

	ConsoleKeyInfo tecla = Console.ReadKey();

	Console.WriteLine("");
	if(tecla.Key == ConsoleKey.Enter) {
		Program.Main();
	}
	else {
		Console.Clear();
		goto d;
	}
  }

  //SP
  static void sp(){
	inicio:
	ConsoleKeyInfo tecla;
	Console.WriteLine("Este programa foi criado pelo aluno Enoque Gofeto Moreira da Silva da Ele231\n\nAperte o Enter para voltar.");

	tecla = Console.ReadKey();

	Console.WriteLine("");
	if(tecla.Key == ConsoleKey.Enter) {
		Program.Main();
	}
	else {
		Console.Clear();
		goto inicio;
	}

  }
}