string[] Entering_array(string[] str)
{
for (int i=0;i<str.Length;i++)
{
    System.Console.Write($"Введите {i+1} строкy массива:");
    str[i]=Console.ReadLine();
}
return str;
}

string[] Output_array(string[] str)
{
for (int i=0;i<str.Length;i++)
{
    System.Console.Write($"{str[i]} ");
}
return str;
}


System.Console.Write("Введите сколько будет строк в массиве:");
int size=Convert.ToInt32(Console.ReadLine());
string[] str=new string[size];
Entering_array(str);
System.Console.WriteLine("Введенный строчный массив имеет вид:");
Output_array(str);



System.Console.WriteLine("Полученный массив имеет вид:");