//using System.Diagnostics.Metrics;

//string pangram = "The quick brown fox jumps over the lazy dog";

//string[] wordArray = pangram.Split(' ');
//string[] newarray = new string[wordArray.Length];
//int counter = 0;
//foreach (string word in wordArray)
//{
//    char[] letterarray = word.ToCharArray();
//    Array.Reverse(letterarray);
//    string reverse = new string(letterarray);
//    newarray[counter] = reverse;
//    counter++;
//}

//string result = String.Join(" ", newarray);
//Console.WriteLine(result);

//string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

//string[] orderArray = orderStream.Split(',');
//Array.Sort(orderArray);

//for (int i = 0; i < orderArray.Length; i++)
//{
//    if (orderArray[i].Length != 4)
//    {
//        orderArray[i] += "\t - Error";
//    }
//    Console.WriteLine(orderArray[i]);
//}