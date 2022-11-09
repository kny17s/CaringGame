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

    List<InitialStatusData> _statusDatas = new List<InitialStatusData>();
}

[System.Serializable]
public class InitialStatusData
{
    [SerializeField]
    [Header("キャラ名")]
    string _name;

    [SerializeField]
    [Header("体力")]
    float _hp;

    [SerializeField]
    [Header("魔力")]
    float _mp;

    [SerializeField]
    [Header("攻撃力")]
    float _str;

    [SerializeField]
    [Header("防御力")]
    float _def;

    [SerializeField]
    [Header("素早さ")]
    float _agi;

    [SerializeField]
    [Header("レベル")]
    int _lv;

    [SerializeField]
    [Header("スキルポイント")]
    int _sp;
}
