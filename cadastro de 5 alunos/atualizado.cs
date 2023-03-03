// Criar Variáveis (Marina)
string[,] alunos = new string[5, 7];
int linha = 0;
int coluna = 0;
int codigo = 0;
double prova1= 0;
double prova2 = 0;
double prova3 = 0;
double trabalho = 0;


// Cadastrar Produtos
for (linha = 0; linha <= 5; linha++)
{
    Console.WriteLine("Informe seu nome: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe o numero de auals dadas: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe o numero de faltas: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe a nota da prova 1: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe a nota da prova 2: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe a nota da prova 3: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe a nota do trabalho 1: ");
    alunos[linha, coluna++] = Console.ReadLine();

    coluna = 0;
}
for (linha = 0; linha <= 5; linha++)
{
    for (coluna = 0; coluna <= 7; coluna++)
    {
        Console.Write(" -- " + alunos[linha, coluna] + " -- ");
    }
    Console.WriteLine("");
}
