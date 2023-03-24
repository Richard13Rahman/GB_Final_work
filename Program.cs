System.Console.Write("Введите сколько будет строк в массиве:");
int size=Convert.ToInt32(Console.ReadLine());
string[] str=new string[size];
Entering_array(str);
System.Console.WriteLine("Введенный строчный массив имеет вид:");
Output_array(str);
string[] str_short=new string[size];
int j=-1, strLen=0;
for (int i=0;i<str.Length;i++)
{
    strLen=str[i].Length;
    if (strLen<4)
    {
        str_short[j+1]=str[i];
        j=j+1;
    }
}
if (j<0)//Добавил на случай если нужных по условию значений не будет среди введенных данных
    System.Console.WriteLine("В веденном массиве нету строк трех и менее символов");
else
{
    System.Console.WriteLine("Полученный массив имеет вид:");
    Output_array(str_short);
}

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
    if (str[i]!=null)//Добавил чтобы на экране не было пустых кавычек, на случай если второй массив короче первого. Вместо:('12' 'как' 'Ау' '' '') будет это:('12' 'как' 'Ау')
    System.Console.Write($"'{str[i]}' ");
}
System.Console.WriteLine();
return str;
}
