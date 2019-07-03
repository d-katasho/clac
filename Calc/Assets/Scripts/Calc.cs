using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Calc : MonoBehaviour
{
    /// <summary>入力値</summary>
    public enum IB
    {
        IB0,
        IB1,
        IB2,
        IB3,
        IB4,
        IB5,
        IB6,
        IB7,
        IB8,
        IB9,
        IBPlus,
        IBMinus,
        IBMulti,
        IBDiv,
        IBEqual
    }

    private static List<IB> InputValueList = new List<IB> { };

    /// <summary>
    /// INで入力された値を格納する
    /// </summary>
    /// <returns></returns>
    public static bool AddInputValue()
    {
        //Array.Resize<List<IB>>(ref InputValueList, InputValueList.Count + 1);
        InputValueList.Add(IB.IB0);
        return true;
    }

    /// <summary>
    /// 最終入力値を削除する
    /// </summary>
    /// <returns></returns>
    public static bool RemoveInputValueLast()
    {
        InputValueList.Remove(IB.IB0);
        return false;
    }

    /// <summary>
    /// 入力値を全削除する
    /// </summary>
    /// <returns></returns>
    public static bool ClearInputValue()
    {
        return false;
    }

    /// <summary>
    /// 入力値を他へ渡す
    /// </summary>
    /// <returns></returns>
    public static List<IB> GetInputValueList()
    {
        return InputValueList;
    }

    void Start()
    {
        InputValueList = new List<IB> { };
    }

}
