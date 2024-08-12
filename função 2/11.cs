void Mensagem(){
    Console.WriteLine("oiierr");
}

Mensagem();

void Escreva (string msg){
    Console.WriteLine(msg);
}

Escreva ("oiii sarolaa");
string minhaMsg = "tudo bem?";
Escreva (minhaMsg);


void MostrarIdade(string nome, int idade)
{
    Escreva($"{nome} tem {idade}");
}

MostrarIdade("sarola", 15);

void CaucularIdade2(string nome, int ano)
{
int idade = 2024 - ano;
MostrarIdade(nome,idade);
}

CaucularIdade2("sarola ", 2009);

int MaiorEntre(int a, int b)
{
if(a >= b)
{
    return a;
}
else
{
    return b;
}
}
Console.WriteLine(MaiorEntre(99,200));
Console.WriteLine(MaiorEntre(65,9));
Console.WriteLine(MaiorEntre(1,1));

///exemplo de repetição

float resultado;

resultado = (1*8 + 5*7) / 2f;
Console.WriteLine("a média é" + resultado);

resultado = (7*9 + 5*0) / 2f;
Console.WriteLine("a média é" + resultado);

resultado = (9*9 + 3*3) / 2f;
Console.WriteLine("a média é" + resultado);

void Caucularmedia(int a, int b)
{
float resultado = (2*a + 3*b)/5f;
Console.WriteLine("a média é" + resultado);
}

Caucularmedia(100,50);