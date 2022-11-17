using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
  fileName = "StatusData",
  menuName = "ScriptableObject/StatusData")]
public class StatusData : ScriptableObject
{
    /// <summary>�X�e�[�^�X�̏����l</summary>
    public List<InitialStatusData> StatusDatas => _statusDatas;

    [SerializeField]
    [Header("�L�����ʏ����X�e�[�^�X")]
    List<InitialStatusData> _statusDatas = new List<InitialStatusData>();
}

[System.Serializable]
public class InitialStatusData
{
    /// <summary>�L������</summary>
    public string Name => _name;
    /// <summary>�̗�</summary>
    public float Hp => _hp;
    /// <summary>����</summary>
    public float Mp => _mp;
    /// <summary>�U����</summary>
    public float Str => _str;
    /// <summary>�h���</summary>
    public float Def => _def;
    /// <summary>�f����</summary>
    public float Agi => _agi;
    /// <summary>�X�L���|�C���g</summary>
    public int Sp => _sp;
    /// <summary>�����\��</summary>
    public int Turn => _turn;


    [SerializeField]
    [Header("�L������")]
    string _name = "";

    [SerializeField]
    [Header("�̗�")]
    float _hp = 0;

    [SerializeField]
    [Header("����")]
    float _mp = 0;

    [SerializeField]
    [Header("�U����")]
    float _str = 0;

    [SerializeField]
    [Header("�h���")]
    float _def = 0;

    [SerializeField]
    [Header("�f����")]
    float _agi = 0;

    [SerializeField]
    [Header("�X�L���|�C���g")]
    int _sp = 0;

    [SerializeField]
    [Header("�����\��")]
    int _turn = 0;
}
