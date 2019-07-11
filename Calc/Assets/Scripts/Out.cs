using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Out : MonoBehaviour
{
    private const string Error = "エラー" ;

    public string GetDispText()
    {
        List<Calc.IB> list = Calc.GetInputValueList();
        Analyze analyze = new Analyze(list);
        bool setresult;
        float result = 0;
        setresult = analyze.GetResult(ref result);
        if (setresult)
        {
            return result.ToString();
        }
        else
        {
            return Error;
        }

    }
}
