using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatCalculator : MonoBehaviour
{
    public Temdata tem; //reference to the temtem to calculate for. Values are .baseAtk .baseHp etc..    .traitOne / .traitTwo    .temName

    public int lvl;
    public bool modified;

    public TMP_InputField hpSvText, hpTvText,staSvText,staTvText,spdSvText,spdTvText,atkSvText,atkTvText,spatkSvText,spatkTvText,defSvText,defTvText,spdefSvText,spdefTvText;

    public int hpSV, staSV, spdSV, atkSV, spatkSV, defSV, spdefSV;
    public int hpTV, staTV, spdTV, atkTV, spatkTV, defTV, spdefTV;

    public int hpTot, staTot, spdTot, atkTot, spatkTot, defTot, spdefTot;


    private void Start()
    {
        lvl = 48;

        hpSV = 50;
        staSV = 50;
        spdSV = 50;
        atkSV = 50;
        spatkSV = 50;
        defSV = 50;
        spdefSV = 50;

        hpTV = 0;
        staTV = 0;
        spdTV = 0;
        atkTV = 0;
        spatkTV = 0;
        defTV = 0;
        spdefTV = 0;
    }


    public void ModFlag()
    {
        modified = true;
    }


    public void CalculateStatTotal()
    {      

        hpTot = Mathf.FloorToInt(Mathf.FloorToInt(((1.5f * tem.baseHp) + hpSV + (hpTV / 5f)) * lvl / 80f) + Mathf.FloorToInt(hpSV * tem.baseHp * lvl / 20000f) + lvl + 15f);

        staTot = (int)((((1.5 * tem.baseSta) + staSV + (staTV / 5)) * lvl / 200) + (staSV * tem.baseSta * lvl / 25000) + 20);

        spdTot = (int)((((1.5 * tem.baseSpd) + spdSV + (spdTV / 5)) * lvl / 100) + (spdSV * tem.baseSpd * lvl / 25000) + 10);

        atkTot = (int)((((1.5 * tem.baseAtk) + atkSV + (atkTV / 5)) * lvl / 100) + (atkSV * tem.baseAtk * lvl / 25000) + 10);

        spatkTot = (int)((((1.5 * tem.baseSpatk) + spatkSV + (spatkTV / 5)) * lvl / 100) + (spatkSV * tem.baseSpatk * lvl / 25000) + 10);

        defTot = (int)((((1.5 * tem.baseDef) + defSV + (defTV / 5)) * lvl / 100) + (defSV * tem.baseDef * lvl / 25000) + 10);

        spdefTot = (int)((((1.5 * tem.baseSpdef) + spdefSV + (spdefTV / 5)) * lvl / 100) + (spdefSV * tem.baseSpdef * lvl / 25000) + 10);

        modified = false;
    }

    private void Update()
    {
        if (modified)
            CalculateStatTotal();
        else
            return;
    }

    public void SetHpSV()
    {
        if (hpSvText.text != "")
            hpSV = int.Parse(hpSvText.text);
        else
            hpSV = 0;
        modified = true;
    }

    public void SetHpTV()
    {
        if (hpTvText.text != "")
            hpTV = int.Parse(hpTvText.text);
        else
            hpTV = 0;
        modified = true;
    }

    public void SetStaSV()
    {
        if (staSvText.text != "")
            staSV = int.Parse(staSvText.text);
        else
            staSV = 0;
        modified = true;
    }

    public void SetStaTV()
    {
        if (staTvText.text != "")
            staTV = int.Parse(staTvText.text);
        else
            staTV = 0;
        modified = true;
    }


    public void SetSpdSV()
    {
        if (spdSvText.text != "")
            spdSV = int.Parse(spdSvText.text);
        else
            spdSV = 0;
        modified = true;
    }

    public void SetSpdTV()
    {
        if (spdTvText.text != "")
            spdTV = int.Parse(spdTvText.text);
        else
            spdTV = 0;
        modified = true;
    }


    public void SetAtkSV()
    {
        if (atkSvText.text != "")
            atkSV = int.Parse(atkSvText.text);
        else
            atkSV = 0;
        modified = true;
    }

    public void SetAtkTV()
    {
        if (atkTvText.text != "")
            atkTV = int.Parse(atkTvText.text);
        else
            atkTV = 0;
        modified = true;
    }


    public void SetSpatkSV()
    {
        if (spatkSvText.text != "")
            spatkSV = int.Parse(spatkSvText.text);
        else
            spatkSV = 0;
        modified = true;
    }

    public void SetSpatkTV()
    {
        if (spatkTvText.text != "")
            spatkTV = int.Parse(spatkTvText.text);
        else
            spatkTV = 0;
        modified = true;
    }

    public void SetDefSV()
    {
        if (defSvText.text != "")
            defSV = int.Parse(defSvText.text);
        else
            defSV = 0;
        modified = true;
    }

    public void SetDefTV()
    {
        if (defTvText.text != "")
            defTV = int.Parse(defTvText.text);
        else
            defTV = 0;
        modified = true;
    }

    public void SetSpdefSV()
    {
        if (spdefTvText.text != "")
            spdefSV = int.Parse(spdefTvText.text);
        else
            spdefSV = 0;
        modified = true;
    }

    public void SetSpdefTV()
    {
        if (spdefTvText.text != "")
            spdefTV = int.Parse(spdefTvText.text);
        else
            spdefTV = 0;
        modified = true;
    }

}
