using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Gambler
{
    public static void initialBetting()    //UC1
    {
        int totalStakeMoney = 100;
        int perBetMoney = 1;
        
        
    }

    //1 $ bet win or loose

    public static void FirstGambling(int totalStakeMoney,int perBetMoney)
    {
        Random random = new Random();
        int gamble = random.Next(0, 2);
        if(gamble == 0)
        {
            totalStakeMoney = totalStakeMoney - perBetMoney;
        }
        else
        {
            totalStakeMoney = totalStakeMoney + perBetMoney;
        }
    }
}
    

 

