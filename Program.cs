

//Functions
void StampaArray(int[] array)
{
    string content = "[";
    for (int i = 0; i < array.Length; i++)
    {
        content += array[i];
    }
    Console.WriteLine(content+="]");
};

int Quadrato(int numero)
{
    return numero * numero;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[]) array.Clone();
    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = Quadrato(array[i]);
    }
    return copiaArray;
};

int sommaElementiArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}