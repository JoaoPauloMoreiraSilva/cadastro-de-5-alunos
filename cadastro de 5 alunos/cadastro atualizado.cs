// Criar Variáveis (Marina)
string[,] alunos = new string[5, 7];
int linha = 0;
int coluna = 0;
int codigo = 0;
string continuar = "S";
double total = 0;

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