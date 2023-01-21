// Задача - создали массив, и в нем ищем индекс переменной find, как только нашел, выходит из цикла (так как таких значений переменной в массиве 2,а нам нужно первое только)
int [] array = {1,12,8,4,55,46,171,8};
int n = array.Length;
int find = 8;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}