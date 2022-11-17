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
    /// <summary>スキルポイント</summary>
    int _sp;
    /// <summary>強化可能回数</summary>
    int _turn;

    int _random;

    [SerializeField]
    [Header("上昇倍率")]
    float[] _magnification;

    /// <summary>値をセット</summary>
    public void SetValue(SaveData saveData)
    {
        _name = saveData._name;
        _hp = saveData._hp;
        _mp = saveData._mp;
        _str = saveData._str;
        _def = saveData._def;
        _agi = saveData._agi;
        _sp = saveData._sp;
        _turn = saveData._turn;
    }

    private void Awake() => I = this;

    /// <summary>体力を強化</summary>
    public void HpUp() => RandomResult(_hp);

    /// <summary>魔力を強化</summary>
    public void MpUp() => RandomResult(_mp);

    /// <summary>攻撃力を強化</summary>
    public void StrUp() => RandomResult(_str);

    /// <summary>防御力を強化</summary>
    public void DefUp() => RandomResult(_def);

    /// <summary>素早さを強化</summary>
    public void AgiUp() => RandomResult(_agi);

    /// <summary>共通の命令</summary>
    public void Training()
    {
        _turn--;
        SaveController.I.OverWriteSaveData();
        CharStatus.I.ReSave();
    }

    public void RandomResult(float data)
    {
        _random = UnityEngine.Random.Range(0, 20);

        if (_random >= 18)
        {
            Debug.Log("大成功！");
            data += _random * _magnification[0];
            Training();
        }
        else if (_random <= 17 && _random >= 6)
        {
            Debug.Log("成功");
            data += _random * _magnification[1];
            Training();
        }
        else
        {
            data -= _random * _magnification[2];
            Debug.Log("失敗");
            Training();
        }
    }
}
