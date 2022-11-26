int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 13;
int b1 = 48;
int c1 = 27;
int a2 = 11;
int b2 = 482;
int c2 = 227;
int a3 = 313;
int b3 = 848;
int c3 = 727;

/* Это "стихийный" подход, делать можно, но не удобно!
int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;
if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;
if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;
*/

// Вариант №2. Так тоже можно, но можно и лучше!!!
// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3); 

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); //Типа функциональное программирование

System.Console.WriteLine(max);