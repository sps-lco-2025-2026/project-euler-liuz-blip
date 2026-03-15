


class Program
{
    static void Main()
    {
        
        sums = 0;
        oddeven = 1;

        for (int i = 1; i < 764; i++)
        {
            if (oddeven == 1)
            {
                sums += i * i;
                oddeven += -1;
            } else if (oddeven == -1)
            {
                oddeven += -1;
                continue;
            }
        }
    }
}


