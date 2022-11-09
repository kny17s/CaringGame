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

    List<InitialStatusData> _statusDatas = new List<InitialStatusData>();
}

[System.Serializable]
public class InitialStatusData
{
    [SerializeField]
    [Header("�L������")]
    string _name;

    [SerializeField]
    [Header("�̗�")]
    float _hp;

    [SerializeField]
    [Header("����")]
    float _mp;

    [SerializeField]
    [Header("�U����")]
    float _str;

    [SerializeField]
    [Header("�h���")]
    float _def;

    [SerializeField]
    [Header("�f����")]
    float _agi;

    [SerializeField]
    [Header("���x��")]
    int _lv;

    [SerializeField]
    [Header("�X�L���|�C���g")]
    int _sp;
}
