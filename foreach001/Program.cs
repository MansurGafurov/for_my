// цикл foreach - проходит по каждому элементу 
// и проделывает какую то работу (внутри цикла) с каждым элементом 

int [] array = {1, 2, 3, 4, 5};
int count = 0;
foreach (int index  in array)
{
    Console.WriteLine($"Элемент {count} = {index}");
    count++;
}

