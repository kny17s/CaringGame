using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
  fileName = "StatusData",
  menuName = "ScriptableObject/StatusData")]
public class StatusData : ScriptableObject
{
    /// <summary>ステータスの初期値</summary>
    public List<InitialStatusData> StatusDatas => _statusDatas;

    [SerializeField]
    [Header("キャラ別初期ステータス")]
    List<InitialStatusData> _statusDatas = new List<InitialStatusData>();
}

[System.Serializable]
public class InitialStatusData
{
    /// <summary>キャラ名</summary>
    public string Name => _name;
    /// <summary>体力</summary>
    public float Hp => _hp;
    /// <summary>魔力</summary>
    public float Mp => _mp;
    /// <summary>攻撃力</summary>
    public float Str => _str;
    /// <summary>防御力</summary>
    public float Def => _def;
    /// <summary>素早さ</summary>
    public float Agi => _agi;
    /// <summary>スキルポイント</summary>
    public int Sp => _sp;
    /// <summary>強化可能回数</summary>
    public int Turn => _turn;


    [SerializeField]
    [Header("キャラ名")]
    string _name = "";

    [SerializeField]
    [Header("体力")]
    float _hp = 0;

    [SerializeField]
    [Header("魔力")]
    float _mp = 0;

    [SerializeField]
    [Header("攻撃力")]
    float _str = 0;

    [SerializeField]
    [Header("防御力")]
    float _def = 0;

    [SerializeField]
    [Header("素早さ")]
    float _agi = 0;

    [SerializeField]
    [Header("スキルポイント")]
    int _sp = 0;

    [SerializeField]
    [Header("強化可能回数")]
    int _turn = 0;
}
