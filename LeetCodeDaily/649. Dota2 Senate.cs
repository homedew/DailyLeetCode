//https://leetcode.com/problems/dota2-senate/description/

public class Solution {
    public string PredictPartyVictory(string senate) {
        Queue<int> dParty = new Queue<int>();
        Queue<int> rParty = new Queue<int>();

        for(int i = 0; i< senate.Length; i++)
        {
            if(senate[i] =='D')
            {
                dParty.Enqueue(i);
            }else {
                rParty.Enqueue(i);
            }
        }

        int senateLength = senate.Length;

        while(dParty.Any() && rParty.Any())
        {
            int dIndice = dParty.Dequeue();
            int rIndice = rParty.Dequeue();
            
            if(dIndice < rIndice)
            {
                // add for next round
                dParty.Enqueue(dIndice + senateLength);
            } else {
                rParty.Enqueue(rIndice + senateLength);
            }
        }

        return dParty.Count == 0 ? "Radiant" : "Dire";

    }
}

// DDRRR
// -> push D D R
// DRRD

// RDD
// DR
// D

// D D 
// R \
//     4
//     R
  //         6 9
//-> dQ =  D D
           
// -> rQ = 
