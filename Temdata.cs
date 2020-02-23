using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Temdata : ScriptableObject
{
    public string typeOne,typeTwo;
    public int baseHp, baseSta, baseSpd, baseAtk, baseSpatk, baseDef, baseSpdef;
    public string temName;
    public string traitOne, traitTwo;
}
