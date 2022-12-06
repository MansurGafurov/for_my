// 
Console.WriteLine("Введите размер массива");
int [] arr = new int [Convert.ToInt32(Console.ReadLine())];
foreach(int index in arr) {
    index = new Random(). Next(1,99);
    Console.WriteLine(index);
}


// пока не работает!!!