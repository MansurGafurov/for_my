//  Задача. Дан массив с числами [ -1, 2 , 5, 8 ] ,  K = 7.  Напиши алгоритм, который найдет два  
//  числа в сумме дающие К?

int [] arr = {-1, 2, 5, 8};
//List<int> myList = new List<int> ();
int K = 7;
for(int i = 0; i < arr.Length; i++) {
    int a = arr[i];
    for(int y = 0; y < arr.Length ; y++)
    {
        if ((a + arr[y]) == K) {
            //myList.Add(a);
            //myList.Add(arr[y]); 
            Console.WriteLine($"[ {a} & {arr[y]} ]");
        }
        
    }
}

//foreach(int index in myList){
 //   Console.Write(index + ", ");
//}