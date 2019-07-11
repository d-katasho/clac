using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        // テスト用配列
        Analyze analyze = new Analyze(new List<Calc.IB>{Calc.IB.IB1});
        float result = 0;
        bool success = analyze.GetResult(ref result);
        Debug.Log(result);
    }
}
