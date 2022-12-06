using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusUp : MonoBehaviour
{
    int _random;

    [SerializeField]
    [Header("Å‘åã¸’l")]
    int _randomMax = 15;

    /// <summary>‘Ì—Í‚ğ‹­‰»</summary>
    public void HpUp()
    {
        _random = Random.Range(0, _randomMax);
        SaveClass.I.HpUp(_random);
        SaveClass.I.Training();
    }

    /// <summary>–‚—Í‚ğ‹­‰»</summary>
    public void MpUp()
    {
        _random = Random.Range(0, _randomMax);
        SaveClass.I.MpUp(_random);
        SaveClass.I.Training();
    }

    /// <summary>UŒ‚—Í‚ğ‹­‰»</summary>
    public void StrUp()
    {
        _random = Random.Range(0, _randomMax);
        SaveClass.I.StrUp(_random);
        SaveClass.I.Training();
    }

    /// <summary>–hŒä—Í‚ğ‹­‰»</summary>
    public void DefUp()
    {
        _random = Random.Range(0, _randomMax);
        SaveClass.I.DefUp(_random);
        SaveClass.I.Training();
    }

    /// <summary>‘f‘‚³‚ğ‹­‰»</summary>
    public void AgiUp()
    {
        _random = Random.Range(0, _randomMax);
        SaveClass.I.AgiUp(_random);
        SaveClass.I.Training();
    }
}
