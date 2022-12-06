// See
List<int> myList = new List<int> {2, 4, 6, 8, 10, 12, 14, 15};
int count = 0;
foreach(int index in myList) {
    if(index > 7) count++;
}
Console.WriteLine($"Колличесиво цифр, которые больше 7 = {count}");
