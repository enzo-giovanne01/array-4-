using static System.Console;

int[]numeros = new int[10];
int[]pares = new int[10];
int[]impares = new int[10];
for (int i = 0; i < numeros.Length; i++)
{
    WriteLine("Digite um número maior que zero.");
    numeros[i] = Convert.ToInt32(ReadLine());
}
for (int p = 0; p < numeros.Length; p++)
{
    if (numeros[p] %2 == 0)
    {
        pares[p] = numeros[p];
    }
    else
    {
        impares[p] = numeros[p];
    }
}
Array.Sort(numeros);
Array.Sort(pares);
Array.Sort(impares);
Clear();
WriteLine("Números digitados.... ");
foreach(int item in numeros)
{
    WriteLine(item);
}
WriteLine("Números pares... ");
foreach(int item in pares)
{
    WriteLine(item);
}
WriteLine("Números impares... ");
foreach(int item in impares)
{
    WriteLine(item);
}

