int a = 9;
int b = 2;
int c = 11;
int d = 16;
int e = 8;

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("Максимальный вес гири равен: ");
Console.Write(max);
Console.WriteLine(" кг.");