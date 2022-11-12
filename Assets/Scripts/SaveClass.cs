using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class SaveData
{
    /// <summary>�L������</summary>
    public string _name;
    /// <summary>�̗�</summary>
    public float _hp;
    /// <summary>����</summary>
    public float _mp;
    /// <summary>�U����</summary>
    public float _str;
    /// <summary>�h���</summary>
    public float _def;
    /// <summary>�f����</summary>
    public float _agi;
    /// <summary>���x��</summary>
    public int _lv;
    /// <summary>�X�L���|�C���g</summary>
    public int _sp;
    /// <summary>�����\��</summary>
    public int _turn;
}

public class SaveClass : MonoBehaviour
{
    public static SaveClass I;
    public string Name => _name;
    public float Hp => _hp;
    public float Mp => _mp;
    public float Str => _str;
    public float Def => _def;
    public float Agi => _agi;
    public int Lv => _lv;
    public int Sp => _sp;
    public int Turn => _turn;

    /// <summary>�L������</summary>
    string _name;
    /// <summary>�̗�</summary>
    float _hp;
    /// <summary>����</summary>
    float _mp;
    /// <summary>�U����</summary>
    float _str;
    /// <summary>�h���</summary>
    float _def;
    /// <summary>�f����</summary>
    float _agi;
    /// <summary>���x��</summary>
    int _lv;
    /// <summary>�X�L���|�C���g</summary>
    int _sp;
    /// <summary>�����\��</summary>
    int _turn;

    int _random;
    public void SetValue(SaveData saveData)
    {
        //�l��SaveData����Z�b�g
        _name = saveData._name;
        _hp = saveData._hp;
        _mp = saveData._mp;
        _str = saveData._str;
        _def = saveData._def;
        _agi = saveData._agi;
        _lv = saveData._lv;
        _sp = saveData._sp;
        _turn = saveData._turn;
    }

    private void Awake() => I = this;

    /// <summary>�̗͂�����</summary>
    public void HpUp()
    {
        _random = UnityEngine.Random.Range(0, 20);
        _hp += _random;
        Training();
    }

    /// <summary>���͂�����</summary>
    public void MpUp()
    {
        _random = UnityEngine.Random.Range(0, 20);
        _mp += _random;
        Training();
    }

    /// <summary>�U���͂�����</summary>
    public void StrUp()
    {
        _random = UnityEngine.Random.Range(0, 20);
        _str += _random;
        Training();
    }

    /// <summary>�h��͂�����</summary>
    public void DefUp()
    {
        _random = UnityEngine.Random.Range(0, 20);
        _def += _random;
        Training();
    }

    /// <summary>�f����������</summary>
    public void AgiUp()
    {
        _random = UnityEngine.Random.Range(0, 20);
        _agi += _random;
        Training();
    }

    /// <summary>���ʂ̖���</summary>
    public void Training()
    {
        _turn--;
        SaveController.I.OverWriteSaveData();
        CharStatus.I.Reload();
    }
}
