using System.ComponentModel.Design;

Console.WriteLine(@"Opção de Usuário:
S para soma
R para subtração
M para multiplicação
D para divisão");

string operacao = Console.ReadLine().ToUpper();


Console.WriteLine("Digite o valor 1: ");
string valorUm = Console.ReadLine();
double convertValor1 = Convert.ToDouble(valorUm);


Console.WriteLine("Digite o valor 2: ");
string valorDois = Console.ReadLine();
double convertValor2 = Convert.ToDouble(valorDois);

//if (operacao == "S")
//{
//    Console.WriteLine($"{convertValor1} + {convertValor2} = {convertValor1 + convertValor2}");
//}

//if (operacao == "R") 
//{
//    Console.WriteLine($"{convertValor1} - {convertValor2} = {convertValor1 - convertValor2}");
//}

//if (operacao == "M")
//{
//    Console.WriteLine($"{convertValor1} x {convertValor2} = {convertValor1 * convertValor2}");
//}

//if (operacao == "D" && convertValor2 != 0)
//{
//    Console.WriteLine($"{convertValor1} / {convertValor2} = {convertValor1 / convertValor2}");
//}

//else
//{
//    Console.WriteLine(@"Erro! 

//Opção de Operador Inválida. 

//Ou Divisão por Zero. 

//Bye!");
//};

// mesma lógica utilizando switch();


switch (operacao)
{
    case "S":
        Console.WriteLine($"{convertValor1} + {convertValor2} = {convertValor1 + convertValor2}");
        break;

    case "R":
        Console.WriteLine($"{convertValor1} - {convertValor2} = {convertValor1 - convertValor2}");
        break;

    case "M":
        Console.WriteLine($"{convertValor1} x {convertValor2} = {convertValor1 * convertValor2}");
        break;

    case "D":
        if (convertValor2 != 0)
        {
            Console.WriteLine($"{convertValor1} / {convertValor2} = {convertValor1 / convertValor2}");
        }
        break;

    default:
        Console.WriteLine("Opção inserida invalida");
        break;
};