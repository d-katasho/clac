using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Analyze : MonoBehaviour
{
    private List<Calc.IB> iBList;
    public Analyze (List<Calc.IB> iBList)
    {
        this.iBList = iBList;
    }

    public bool GetResult(ref float result)
    {
        result = 2;
        return true;



        //return false;
    }
}
