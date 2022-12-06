// Сколько чисел в массиве будет больше пяти?
int [] arr = {2, 4, 6, 8, 10};
int count = 0;
int num = 5;
foreach(int index in arr) 
{
    if(index > num) count ++;
}
Console.WriteLine(count);
