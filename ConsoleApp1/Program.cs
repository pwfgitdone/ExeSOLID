// See https://aka.ms/new-console-template for more information
using ExeSOLID.LSP.Violacao;

Console.WriteLine("Hello, World!");

void ObterAreaRetangulo(Retangulo ret)
{
    Console.WriteLine("Calculo da área do Retangulo");
    Console.WriteLine(ret.Altura.ToString() + " * " + ret.Largura.ToString());
    Console.WriteLine(ret.Area);
    Console.ReadKey();
}


var quad = new Quadrado()
{
    Altura = 10,
    Largura = 5
};

ObterAreaRetangulo(quad);
