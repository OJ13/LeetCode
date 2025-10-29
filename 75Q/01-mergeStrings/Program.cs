using System.Text;

class Solution
{

    public static void Main(string[] args)
    {
        string word1 = Console.ReadLine().Trim();
        string word2 = Console.ReadLine().Trim();

        string result = MergeAlternately(word1, word2);

        Console.WriteLine(result);
    }
    //Solucao 1
    // public static string MergeAlternately(string word1, string word2)
    // {
    //     StringBuilder resultado = new StringBuilder();
    //     int contador = Math.Max(word1.Length, word2.Length);
    //     for (int i = 0; i < contador; i++)
    //     {
    //         if (i < word1.Length) 
    //             resultado.Append(word1[i]);

    //         if (i < word2.Length)
    //             resultado.Append(word2[i]);
    //     }

    //     return resultado.ToString();
    // }

    //SOLUCAO MAIS RAPIDA LEETCODE
    // public static string MergeAlternately(string word1, string word2)
    // {
    //     int j = 0;
    //     string word = "";
    //     if (word1.Length > word2.Length)
    //     {
    //         for (int i = 0; i < word2.Length; i++)
    //         {
    //             word += word1[i];
    //             word += word2[i];
    //             j = i;
    //         }
    //         word += word1.Substring(j + 1);
    //     }
    //     else
    //     {
    //         for (int i = 0; i < word1.Length; i++)
    //         {
    //             word += word1[i];
    //             word += word2[i];
    //             j = i;
    //         }
    //         word += word2.Substring(j + 1);
    //     }
    //     return word;
    // }

    //RESULTADO - MESCLANDO COM O MAIS RAPIDO - Buscando mais performance
    public static string MergeAlternately(string word1, string word2)
    {
        StringBuilder resultado = new StringBuilder();
        int contador = Math.Min(word1.Length, word2.Length);
        int j = 0;
        for (int i = 0; i < contador; i++)
        {
            resultado.Append(word1[i]);
            resultado.Append(word2[i]);
            j = i;
        }

        resultado.Append(word1.ToString().Substring(j + 1)).Append(word2.ToString().Substring(j + 1));
        
        return resultado.ToString();
    }
}