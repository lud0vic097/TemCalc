using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCalc : MonoBehaviour
{
    public StatCalculator temA, temB, temC, temD;// A+B = team on the left, C+D = team on the right, team A and C on top

    public Technique moveSlotA,moveSlotB,moveSlotC,moveSlotD; //reference to the move in use by corresponding tem. 

    // Calls are .type , .power , .isSpecial (boolean flag that controls an if in damage calc) and .isHyperKineticStrike for spd spatk split calculation.

    private int dmgAvsC, dmgAvsD, dmgBvsC, dmgBvsD, dmgCvsA, dmgCvsB, dmgDvsA, dmgDvsB;


    public void TestDamageAvsC()
    {
        if (moveSlotA.isHyperKineticStrike)
        {
        
        }
        else
        //standard Calcs
        { if (moveSlotA.isSpecial) //calc with special stats
            {
                dmgAvsC = (int)((7 + (temA.lvl / 200)*moveSlotA.power * temA.spatkTot / temC.spdefTot) * Modifiers(temA.tem,temC.tem));

            }
            else   // calc with physical stats
            {


            }

        }
    }


    private float Modifiers(Temdata tem, Temdata tem2) 
    {
        //logic for type matchup
        return 1;
    }

}
