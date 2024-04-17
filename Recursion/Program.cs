namespace Recursion;
static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Teste de Soma por Recursão:");
        
        List<int> sample1 = new List<int>() { 1, 2, 3, 4 };
        List<int> sample2 = new List<int>() { 2, 4, 6 };
        List<int> sample3 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> sample4 = new List<int>() { 1, 2 };
        List<int> sample5 = new List<int>();

        // Soma Recursiva.
        Console.WriteLine($"Resultado esperado: 10 | Resultado obtido: {Sum(sample1)}");
        Console.WriteLine($"Resultado esperado: 12 | Resultado obtido: {Sum(sample2)}");

        // Contagem Recursiva.
        Console.WriteLine($"Resultado esperado: 10 | Resultado obtido: {CountRecursive(sample3)}");
        Console.WriteLine($"Resultado esperado: 2 | Resultado obtido: {CountRecursive(sample4)}");
        Console.WriteLine($"Resultado esperado: 0 | Resultado obtido: {CountRecursive(sample5)}");
    }

    static int Sum(List<int> list)
    {
        if(list.Count == 0)
            return 0;
            
        return list.Pop(0) + Sum(list);
    }

    static int Pop(this List<int> list, int index)
    {
        int popped = list[index];
        list.RemoveAt(index);
        return popped;
    }

    static int CountRecursive(List<int> list)
    {
        if(!list.Any())
            return 0;

        list.Pop(0);
        
        return 1 + CountRecursive(list);
    }
}
