using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusUp : MonoBehaviour
{
    int _random;

    [SerializeField]
    [Header("最大上昇値")]
    int _randomMax = 15;

    /// <summary>体力を強化</summary>
    public void HpUp()
    {
        _random = Random.Range(0, _randomMax);
        SaveClass.I.HpUp(_random);
        SaveClass.I.Training();
    }

    /// <summary>魔力を強化</summary>
    public void MpUp()
    {
        _random = Random.Range(0, _randomMax);
        SaveClass.I.MpUp(_random);
        SaveClass.I.Training();
    }

    /// <summary>攻撃力を強化</summary>
    public void StrUp()
    {
        _random = Random.Range(0, _randomMax);
        SaveClass.I.StrUp(_random);
        SaveClass.I.Training();
    }

    /// <summary>防御力を強化</summary>
    public void DefUp()
    {
        _random = Random.Range(0, _randomMax);
        SaveClass.I.DefUp(_random);
        SaveClass.I.Training();
    }

    /// <summary>素早さを強化</summary>
    public void AgiUp()
    {
        _random = Random.Range(0, _randomMax);
        SaveClass.I.AgiUp(_random);
        SaveClass.I.Training();
    }
}
