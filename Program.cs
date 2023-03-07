/*1) Observe o trecho de código abaixo:

int INDICE = 13, SOMA = 0, K = 0;

enquanto K < INDICE faça

{

K = K + 1;

SOMA = SOMA + K;

}

imprimir(SOMA);



Ao final do processamento, qual será o valor da variável SOMA?*/

using System.ComponentModel;
using System.Text;

int indice = 13, soma = 0;

for(int k = 0; k < indice; k++)
{
    soma +=+ k;
}

Console.WriteLine(soma);

//ao final a variável soma possúi o valor de 78.

/*2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.



IMPORTANTE:

Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;*/

int valorInformado, qtdPosições = 1, primeiroValor = 0, segundoValor = 1, sequencia = 0;

Console.Write("Informe um valor: ");
valorInformado = int.Parse(Console.ReadLine());

for(int i = 0; i < qtdPosições; i++)
{
    
    if (sequencia <= valorInformado)
    {
        sequencia = primeiroValor + segundoValor;
        primeiroValor = segundoValor;
        segundoValor = sequencia;
        if (valorInformado == sequencia)
        {
            Console.WriteLine("Valor pertence a sequencia de Fibonacci.");
            break;
        }
        else 
        { 
            qtdPosições++; 
        }

    }
    else
    {
        Console.WriteLine("Valor não pertence a sequencia de Fibonacci.");
    }

}

/*3) Descubra a lógica e complete o próximo elemento:



a) 1, 3, 5, 7, 9

b) 2, 4, 8, 16, 32, 64, 128

c) 0, 1, 4, 9, 16, 25, 36, 49

d) 4, 16, 36, 64, 100

e) 1, 1, 2, 3, 5, 8, 13

f) 2,10, 12, 16, 17, 18, 19, 200

*/


/*4 - Dois veículos (um carro e um caminhão) saem respectivamente de cidades opostas pela mesma rodovia. O carro de Ribeirão Preto em direção a Franca, a uma velocidade constante de 110 km/h e o caminhão de Franca em direção a Ribeirão Preto a uma velocidade constante de 80 km/h. Quando eles se cruzarem na rodovia, qual estará mais próximo a cidade de Ribeirão Preto?



IMPORTANTE:

a) Considerar a distância de 100km entre a cidade de Ribeirão Preto <-> Franca.

b) Considerar 2 pedágios como obstáculo e que o caminhão leva 5 minutos a mais para passar em cada um deles e o carro possui tag de pedágio (Sem Parar)

c) Explique como chegou no resultado.*/

/* Independente da velocidade que os dois levam para chegar no seu destino, no momento em que eles se encontram na rodovia, eles possuem a mesma distância de Ribeirão Preto.*/

/*5) Escreva um programa que inverta os caracteres de um string.



IMPORTANTE:

a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

b) Evite usar funções prontas, como, por exemplo, reverse;*/

Console.Write("Informe uma palavra ou texto a ser invertido: ");
string texto = Console.ReadLine();

string textoInvertido = "";
char[] armazena = texto.ToCharArray();

for (int i = armazena.Length - 1; i > -1; i--)
{
    Console.Write( armazena[i].ToString());
}
