Console.Clear();
Console.WriteLine("Enter numbers: ");
double a = Convert.ToInt32(Console.ReadLine());
double count = 2;
while(count <= a)
{
Console.WriteLine(count);
count = count + 2;
}
