/*
int[] nums = { 2, 43, 56, 23, 6, 67, 32 };
for (int i=0; i<nums.Length; i++)
    Console.Write(nums[i]+" ");
*/


/*
int sum = 0; double avg = 0;
int[] nums = { 2, 43, 56, 265, 6, 98,61,67, 32 };
for (int i = 0; i < nums.Length; i++)
{
    sum+=nums[i];   
    avg=sum/nums.Length;
    Console.WriteLine(nums[i] + " ");
}
Console.WriteLine("The sum of the numbers in the array is:" + sum);
Console.WriteLine("The average of the numbers in the array is:" + avg);
*/


/*
double num50 = 0; double avg = 0; int counter = 0;
double[] nums = { 23.1, 32.1, 12, 1.0, 3.2, 0.22, 1.44, 7.2, 55 };
for (int i=0;i<nums.Length;i++)
{
    if (nums[i] <= 50)
    {
        num50 += nums[i];
        counter++;
    }
    else
        continue;
}
avg = num50 / counter;
Console.WriteLine("Sum:"+num50);

Console.WriteLine("Average:"+avg);
*/




/*
int[] nums=new int[10];
int even = 0, odd = 0, sumeven = 0, sumodd =0;
for (int i = 0; i < nums.Length; i++)
{
    Console.Write("enter number:");
    nums[i]=Convert.ToInt32(Console.ReadLine());
}
foreach (int i in nums)

{
    if (i % 2 == 0)

    {
        sumeven += i;
        even++;
    }
    else
    {
        sumodd += i;
        odd++;
    }
}
Console.WriteLine($"there are {odd} odd numbers");
Console.WriteLine("sum of odd numbers:"+sumodd);
Console.WriteLine($"there are {even} odd numbers");
Console.WriteLine("sum of even numbers:"+sumeven);

*/
















/*
string[] names = new string [5];
for(int i =0;i<5;i++)
{
    Console.Write("Please enter your name:");
    names[i]=Convert.ToString(Console.ReadLine());
}
for (int i = 0; i < 5; i++)
{
    Console.Write(names[i]+" ");
}
*/

/*
string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

foreach (string i in months)
{
    Console.Write(i+" ");
   
}
*/

/*
string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

foreach (string i in months)
{
    if (i == "February" || i == "December" || i == "January")
    {
        Console.WriteLine(i+" in the winter season");
    }
    else if (i == "March" || i == "April" || i == "May")
    {
        Console.WriteLine(i+" in the spring season");
    }
    else if (i == "June" || i == "July" || i == "August")
    {
        Console.WriteLine(i+" in the summer season");
    }
    else
    {
        Console.WriteLine(i+" in the autumn season");
    }

}
*/


/*
Console.Write("enter the number of workers:");
int worker=Convert.ToInt32(Console.ReadLine());

string[] namesarray=new string[worker];

for (int i=0; i<namesarray.Length; i++)
{
    Console.Write( (i+1)+". worker:" );
    namesarray[i] = Console.ReadLine();
    
}
foreach (String j in namesarray)
{
    Console.WriteLine(j);
}
*/



/*
Console.Write("enter the number of workers:");
int worker = Convert.ToInt32(Console.ReadLine());
string[] name=new string[worker];
string[] surname=new string[worker];
string[] gsm=new string[worker];
string[] email=new string[worker];
for (int i=0; i<name.Length; i++)
{
    Console.Write("Enter name:");
    name[i] = Console.ReadLine();

    Console.Write("Enter surname:");
    surname[i] = Console.ReadLine();

    Console.Write("Enter telephone number :");
    gsm[i] = Console.ReadLine();

    Console.Write("Enter e-mail:");
    email[i] = Console.ReadLine();
}
for (int i=0; i<name.Length; i++)
{
    Console.Write(name[i]+"\t"+ surname[i] + "\t" + gsm[i] + "\t" + email[i] + "\n");
}
*/


/*
double[] yesno = { 1.3, 3.3,4.4, 5.6, 3, 2.5, 4.4, 55, 4.4, 2.7, 7.2 };
int counter = 0;

Console.Write("Enter number:");
double n1 = double.Parse(Console.ReadLine());
foreach (double i in yesno)
{
    if(i==n1)
    {
        Console.WriteLine("Yes");
        counter++;
    }
}
s
Console.WriteLine($" There are {n1} out of {counter}");
*
*/












/*
string[] names = { "hans", "sam", "tony", "johny", "herkel", "frank" };
for (int i=0; i<names.Length; i++)
{
    Console.WriteLine(i+". index:" + names[i]);
}
*/


/*
string[] names = { "hans", "sam", "tony", "johny", "herkel", "frank" };
for (int i = 0; i < names.Length; i++)
{
    if (names[i]=="hans")
    {
        Console.WriteLine(names[i] +" is father of " + names[i+1]);
    }
}
*/

















