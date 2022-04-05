//Funzioni

int[] array = { 2, 6, 7, 5, 3, 9 };

void StampaArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {

        if (i != array.Length-1)
        {
            Console.Write(array[i]);
            Console.Write(" , ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
    Console.WriteLine(" ] ");
}


int Quadrato(int numero)
{
    return numero * numero;
}


int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayQudarato = (int[])array.Clone();

    for (int i = 0; i < arrayQudarato.Length; i++)
    {
        arrayQudarato[i] = Quadrato(arrayQudarato[i]);
    }
    return arrayQudarato;
}


int sommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
        somma++;
    return somma;
}




StampaArray(array);

StampaArray(ElevaArrayAlQuadrato(array));

StampaArray(array);

Console.WriteLine(sommaElementiArray(array));
