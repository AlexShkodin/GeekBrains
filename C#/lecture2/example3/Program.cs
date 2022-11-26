int[] array = {777, 11, 21, 31, 44, 575, 678, 777, 8, 99};

int n = array.Length;
int find = 777;
int index = 0;

while(index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}