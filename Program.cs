Console.Write("Quanti numeri vuoi inserire? ");
int n = Int32.Parse(Console.ReadLine());
int[] arrNum = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Inserisci numero {i+1} ");
    arrNum[i] = Int32.Parse(Console.ReadLine());
}
StampaArray(arrNum);
int[] arrNumQ = ElevaArrayAlQuadrato(arrNum);
StampaArray(arrNumQ);
StampaArray(arrNum);
Console.WriteLine("La somma degli elementi dell'array è " + sommaElementiArray(arrNum));
Console.WriteLine("La somma degli elementi elevati al quadrato è " + sommaElementiArray(arrNumQ));

//Functions
void StampaArray(int[] array)
{
    string content = "[";
    for (int i = 0; i < array.Length; i++)
    {
        content += array[i] + ", ";
    }
    content = content.Remove(content.Length - 2, 2);
    Console.WriteLine(content+"]");
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