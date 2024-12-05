using System;

class Program
{
    //1112410002 馮子玹
    // 處理數值型陣列的輸入與計算平均值
    static void HandleNumericArray<T>(string prompt, T[] array, Func<string, T> parseFunc) where T : struct
    {
        Console.WriteLine(prompt);
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"請輸入第 {i + 1} 項：");
            array[i] = parseFunc(Console.ReadLine());
            sum += array[i];
        }
        Console.WriteLine($"平均值為: {sum / array.Length}");
    }

    // 處理字串型陣列的輸入
    static void HandleStringArray(string prompt, string[] array)
    {
        Console.WriteLine(prompt);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"請輸入第 {i + 1} 項：");
            array[i] = Console.ReadLine();
        }
        Console.WriteLine("陣列內容如下：");
        foreach (var item in array) Console.WriteLine(item);
    }

    static void MyHomeWork01()
    {
        HandleNumericArray("請輸入 10 個整數：", new int[10], int.Parse);
        HandleNumericArray("請輸入 8 個浮點數：", new float[8], float.Parse);
        HandleNumericArray("請輸入 4 個倍精確度數：", new double[4], double.Parse);
        HandleStringArray("請輸入 5 個字串：", new string[5]);
    }

    static void MyHomeWork02()
    {
        int[] intArray = { 1, 2, 3, 4, 5 };
        float[] floatArray = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
        double[] doubleArray = { 1.22, 2.33, 3.44, 4.55, 5.66 };
        string[] stringArray = { "王小明", "陳大明", "李小英", "張小美", "陳不良" };

        Console.WriteLine("整數陣列內容與平均值：");
        PrintArrayWithAverage(intArray);

        Console.WriteLine("\n浮點數陣列內容與平均值：");
        PrintArrayWithAverage(floatArray);

        Console.WriteLine("\n倍精確度數字陣列內容與平均值：");
        PrintArrayWithAverage(doubleArray);

        Console.WriteLine("\n字串陣列內容：");
        foreach (var item in stringArray) Console.WriteLine(item);
    }

    static void PrintArrayWithAverage<T>(T[] array) where T : struct
    {
        dynamic sum = 0;
        foreach (var item in array)
        {
            Console.WriteLine(item);
            sum += item;
        }
        Console.WriteLine($"平均值為: {sum / array.Length}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("執行第 1, 2 題內容:");
        MyHomeWork01();

        Console.WriteLine("\n執行第 3, 4 題內容:");
        MyHomeWork02();
    }
}
