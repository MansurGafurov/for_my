// Как добвить элементы из массива в лист?
string[] arr = {"M", "A", "N", "S", "U", "R"};
List<string> myList = new List<string> ();
myList.AddRange(arr);
myList.Add("G");
myList.Add("A");
myList.Add("F");
myList.Add("U");
myList.Add("R");
myList.Add("O");
myList.Add("V");

foreach(string index in myList){
    Console.Write(index);
}

