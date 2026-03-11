// Task 1 ----------------------------
//static int Topla(int x, int y)
//{
//    return x + y;
//}
//static int Cixma(int x, int y)
//{
//    return x - y;
//}

//static int Vurma(int x, int y)
//{
//    return x * y;
//}

//static double Bolme(double x, double y)
//{
//    return x / y;
//}

//Console.WriteLine(Topla(5 ,10));
//Console.WriteLine(Cixma(8 ,4));
//Console.WriteLine(Vurma(5 ,10));
//Console.WriteLine(Bolme(48 ,6));

// Task 2 ----------------------------

//int[] arr = { 14, 20, 35, 40, 57, 60, 100 };
//PluralSingular(arr);
//static void PluralSingular(params int[] arr)
//{
//    for(int i = 0; i < arr.Length; i++)
//    {
//    if (arr[i] % 2 == 0)
//        {
//            Console.WriteLine(arr[i] + "cut ededler");
//        }
//        else
//        {
//            Console.WriteLine(arr[i] + "tek ededler");
//        }

//    }
//}

// Task 3 ----------------------------

//int[] arr = [14, 20, 35, 40, 57, 60, 100];
//DordBeseBolunenler(arr);

//static void DordBeseBolunenler(int[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if(arr[i] % 4 == 0 && arr[i] % 5 == 0)
//        {
//            Console.WriteLine(arr[i] + "Bu Eded 5 ve 4 e Qaliqsiz Bolunur");
//        }
//    }
//}


// Task 4 ----------------------------

//Console.WriteLine("Cumle Daxil Edin:");
//string sentence = Console.ReadLine();

//Console.WriteLine("Simvol Daxil Edin:");
//char symbol = Convert.ToChar(Console.ReadLine());

//SimvolSayi(sentence, symbol);


//static void SimvolSayi(string sentence, char symbol)
//{
//    int count = 0;

//    for (int i = 0; i < sentence.Length; i++)
//    {
//        if(sentence[i] == symbol)
//        {
//            count++; 
//        }
//    }

//    Console.WriteLine("Bu Simvoldan " + count + " Eded Var");
//}





























