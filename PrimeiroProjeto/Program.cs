// Screen Sound (nome do projeto).

// Variável (sempre começa com letra minúscula. Camel case).
String mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

// Função (sempre começa com letra maiúscula. Pascal case).
// É necessário decidir se a função terá retorno ou não.
// void (Utilizado para definir funções. Esse método "void" executa uma ação, mas não produz um resultado que precisa ser utilizado posteriormente no código).
void ExibirMensagemDeBoasVindas()
{
    // @ (Verbatil Literal: serve para colocar a string do jeito que aqui no código do jeito que ela vai aparecer ao executar, para que outros devs não fiquem confusos ao pegar o código pela primeira vez.
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    // \n (utilizado para pular uma linha).
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");
}

//Chamando funções.
ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();
Console.Write("\nDigite a sua opção: ");

// Console.ReadLine (Serve para ler a opção que o usuário digitou).
// Nessa parte ja definimos a variável que vai representar a escolha do usuário.
// ! (utilizado para que esse campo não leia valores nulos).
string opcaoEscolhida = Console.ReadLine()!;

// nessa linha estamos convertendo string para int.
int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
// switch (utilizado quando existe muitas opções para o usuário escolher).
switch (opcaoEscolhidaNumerica)
{
    case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
        break;
    case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
        break;
    case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
        break;
    case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
        break;
    case -1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
        break;

 // default (utilizado caso o usuário escolha outra opção que não foi listada).
    default: Console.WriteLine("Opção inválida");
        break;
}