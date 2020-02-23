using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatCalculator : MonoBehaviour
{
    public Temdata tem; //reference to the temtem to calculate for. Values are .baseAtk .baseHp etc..    .traitOne / .traitTwo    .temName

    public int lvl;

    public int hpSV, staSV, spdSV, atkSV, spatkSV, defSV, spdefSV;
    public int hpTV, staTV, spdTV, atkTV, spatkTV, defTV, spdefTV;

    public int hpTot, staTot, spdTot, atkTot, spatkTot, defTot, spdefTot;

    public void CalculateStatTotal()
    {
        hpTot = (int)((((1.5 * tem.baseHp) + hpSV + (hpTV / 5)) * lvl / 80) + (hpSV * tem.baseHp * lvl / 20000) + lvl + 15);

        staTot = (int)((((1.5 * tem.baseSta) + staSV + (staTV / 5)) * lvl / 200) + (staSV * tem.baseSta * lvl / 25000) + 20);

        spdTot = (int)((((1.5 * tem.baseSpd) + spdSV + (spdTV / 5)) * lvl / 100) + (spdSV * tem.baseSpd * lvl / 25000) + 10);

        atkTot = (int)((((1.5 * tem.baseAtk) + atkSV + (atkTV / 5)) * lvl / 100) + (atkSV * tem.baseAtk * lvl / 25000) + 10);

        spatkTot = (int)((((1.5 * tem.baseSpatk) + spatkSV + (spatkTV / 5)) * lvl / 100) + (spatkSV * tem.baseSpatk * lvl / 25000) + 10);

        defTot = (int)((((1.5 * tem.baseDef) + defSV + (defTV / 5)) * lvl / 100) + (defSV * tem.baseDef * lvl / 25000) + 10);

        spdefTot = (int)((((1.5 * tem.baseSpdef) + spdefSV + (spdefTV / 5)) * lvl / 100) + (spdefSV * tem.baseSpdef * lvl / 25000) + 10);

    }

}
