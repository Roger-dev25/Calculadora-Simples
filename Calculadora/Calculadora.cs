using System;

class Calculadora{
    static void Main(){
        double som=0,sub=0,mult=0,div=0;
        double res=0;

        res = calculadora(som, sub, mult, div);
    }
    static double calculadora(double soma, double subtracao, double multiplicacao, double divisao){
        double n1=0, n2=0, resultado=0; int operador=0;

        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("          Calculadora Simples.");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("       Olá usuário, seja bem vindo!");
        Console.WriteLine("--------------------------------------------");
        Console.Write("Entre com o primeiro valor: ");
            while(!double.TryParse(Console.ReadLine(), out n1)){
                Console.Clear();
                Console.WriteLine("Permitido somente números!");
                Console.Write("Entre com o primeiro valor: ");
            }
        Console.Write("Entre com o segundo valor: ");
            while(!double.TryParse(Console.ReadLine(), out n2)){
                Console.Clear();
                Console.WriteLine("Permitido somente números!");
                Console.Write("Entre com o segundo valor: ");
            }
        Console.Clear();
        
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("        Escolha a operação desejada.        ");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Opção 0: CANCELAR.");
        Console.WriteLine("Opção 1: ADIÇÃO.");
        Console.WriteLine("Opção 2: SUBTRAÇÃO.");
        Console.WriteLine("Opção 3: MULTIPLICAÇÃO.");
        Console.WriteLine("Opção 4: DIVISÃO.");
        Console.WriteLine("Opção 5: RESTO DA DIVISÃO.");
        operador=int.Parse(Console.ReadLine());
        Console.Clear();
        if(operador != 0){
            switch(operador){
                case 1:
                    resultado=n1+n2;
                    Console.WriteLine("A adição de {0} + {1} é igual a: {2}",n1,n2, resultado);
                break;
                case 2:
                    resultado=n1-n2;
                    Console.WriteLine("A subtração de {0} - {1} é igual a: {2}",n1,n2, resultado);
                break;
                case 3:
                    resultado=n1*n2;
                    Console.WriteLine("A multiplicação de {0} * {1} é igual a: {2}",n1,n2, resultado);
                break;
                case 4:
                    if(n1 == 0 || n2 == 0){
                        Console.WriteLine("Não é possível dividir por zero.");
                    }else{
                        resultado=n1/n2;
                        Console.WriteLine("A divisão de {0} / {1} é igual a: {2}",n1,n2, resultado);
                    }
                break;
                case 5:
                    resultado = n1 % n2;
                    if(resultado >= 0){
                        Console.WriteLine("O resto da divisão de {0} por {1} é igual a: {2}",n1,n2, resultado); 
                    }else if(n1 >= 0){
                        Console.WriteLine("O resto da divisão de {0} por {1} é igual a: {2}", n1,n2,n1);
                    }else{
                        Console.WriteLine("O resto da divisão de {0} por {1} é igual a: {2}", n1,n2,n2);
                    } 
                break;              
                default:
                    Console.WriteLine("Operação inválida.");
                break;
            }  
        }
        return resultado;
    }
}