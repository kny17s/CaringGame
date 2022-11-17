using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharStatus : MonoBehaviour
{
    public static CharStatus I;

    [SerializeField]
    [Header("ステータステキスト")]
    List<Text> _statusText = new List<Text>();

    [SerializeField]
    [Header("ステータス")]
    StatusData _StatusData;

    private void Start()
    {
        I = this;
        ReSave();
    }

    /// <summary>変更をテキストに反映/summary>
    public void ReSave()
    {
        SaveData saveData = JsonSaveManager<SaveData>.Load(SaveController.I.SaveDataPath[SaveController.I.Num]);

        _statusText[0].text = saveData._name;
        _statusText[1].text = saveData._hp.ToString();
        _statusText[2].text = saveData._mp.ToString();
        _statusText[3].text = saveData._str.ToString();
        _statusText[4].text = saveData._def.ToString();
        _statusText[5].text = saveData._agi.ToString();
        _statusText[6].text = saveData._sp.ToString();
        _statusText[7].text = saveData._turn.ToString();

    }

    /// <summary>初期値に戻す</summary>
    public void ResetStatus()
    {
        SaveData saveData = new SaveData()
        {
            _name = _StatusData.StatusDatas[SaveController.I.Num].Name,
            _hp = _StatusData.StatusDatas[SaveController.I.Num].Hp,
            _mp = _StatusData.StatusDatas[SaveController.I.Num].Mp,
            _str = _StatusData.StatusDatas[SaveController.I.Num].Str,
            _def = _StatusData.StatusDatas[SaveController.I.Num].Def,
            _agi = _StatusData.StatusDatas[SaveController.I.Num].Agi,
            _sp = _StatusData.StatusDatas[SaveController.I.Num].Sp,
            _turn = _StatusData.StatusDatas[SaveController.I.Num].Turn,
        };

        SaveClass.I.SetValue(saveData);
        SaveController.I.OverWriteSaveData();
        ReSave();
    }
}

