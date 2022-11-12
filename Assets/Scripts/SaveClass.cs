using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class SaveData
{
    /// <summary>キャラ名</summary>
    public string _name;
    /// <summary>体力</summary>
    public float _hp;
    /// <summary>魔力</summary>
    public float _mp;
    /// <summary>攻撃力</summary>
    public float _str;
    /// <summary>防御力</summary>
    public float _def;
    /// <summary>素早さ</summary>
    public float _agi;
    /// <summary>レベル</summary>
    public int _lv;
    /// <summary>スキルポイント</summary>
    public int _sp;
    /// <summary>強化可能回数</summary>
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

    /// <summary>キャラ名</summary>
    string _name;
    /// <summary>体力</summary>
    float _hp;
    /// <summary>魔力</summary>
    float _mp;
    /// <summary>攻撃力</summary>
    float _str;
    /// <summary>防御力</summary>
    float _def;
    /// <summary>素早さ</summary>
    float _agi;
    /// <summary>レベル</summary>
    int _lv;
    /// <summary>スキルポイント</summary>
    int _sp;
    /// <summary>強化可能回数</summary>
    int _turn;

    int _random;
    public void SetValue(SaveData saveData)
    {
        //値をSaveDataからセット
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

    /// <summary>体力を強化</summary>
    public void HpUp()
    {
        _random = UnityEngine.Random.Range(0, 20);
        _hp += _random;
        Training();
    }

    /// <summary>魔力を強化</summary>
    public void MpUp()
    {
        _random = UnityEngine.Random.Range(0, 20);
        _mp += _random;
        Training();
    }

    /// <summary>攻撃力を強化</summary>
    public void StrUp()
    {
        _random = UnityEngine.Random.Range(0, 20);
        _str += _random;
        Training();
    }

    /// <summary>防御力を強化</summary>
    public void DefUp()
    {
        _random = UnityEngine.Random.Range(0, 20);
        _def += _random;
        Training();
    }

    /// <summary>素早さを強化</summary>
    public void AgiUp()
    {
        _random = UnityEngine.Random.Range(0, 20);
        _agi += _random;
        Training();
    }

    /// <summary>共通の命令</summary>
    public void Training()
    {
        _turn--;
        SaveController.I.OverWriteSaveData();
        CharStatus.I.Reload();
    }
}
