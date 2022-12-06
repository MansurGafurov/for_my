// список в стринг 

List<string> mList = new List<string> {"M", "A", "N", "U"};
mList.Add("R");
mList.Insert(0, "$");
mList.RemoveAt(0);
foreach(string i in mList) {
    Console.Write(i);
}

