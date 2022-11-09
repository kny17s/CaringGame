using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class SaveData
{
    public int num;
    public string str; 
}

public class SaveClass : MonoBehaviour
{
    public int num;
    public string str;

    public void SetValue(SaveData saveData)
    {
        //値をSaveDataからセット
        num = saveData.num;
        str = saveData.str;
    }

    public static SaveClass I { get; private set; }

    private void Awake()
    {
        I = this;
    }
}
