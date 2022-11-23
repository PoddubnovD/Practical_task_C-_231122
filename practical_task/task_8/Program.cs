Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int startnum = 1;


while(startnum <= num)
    {
        if(startnum % 2 ==0)
        Console.Write(startnum + ", ");
        startnum ++;
    }