using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveController : MonoBehaviour
{
    /// <summary>保存したいJsonのパス名</summary>
    public string[] SaveDataPath => _saveDataPath;

    /// <summary>キャラNo.</summary>
    public int Num => _num;

    public static SaveController I;

    [SerializeField]
    [Header("初期ステータス")]
    StatusData _statusData;

    /// <summary>保存したいJsonのパス名</summary>
    [SerializeField]
    string[] _saveDataPath;

    /// <summary>キャラNo.</summary>
    int _num;

    private void Start()
    {
        I = this;

        _num = SelectChar.I.Num;
        //_saveDataPath[_num] = SelectChar.I.SaveData;

        Debug.Log(_num);
        Debug.Log(_saveDataPath[_num]);

        //セーブデータの読み込み
        SaveData saveData = JsonSaveManager<SaveData>.Load(_saveDataPath[_num]);

        if (saveData == null)//セーブデータが存在しない場合は値を初期化
        {
            //新たなセーブデータを作成
            saveData = new SaveData()
            {
                _name = _statusData.StatusDatas[_num].Name,
                _hp = _statusData.StatusDatas[_num].Hp,
                _mp = _statusData.StatusDatas[_num].Mp,
                _str = _statusData.StatusDatas[_num].Str,
                _def = _statusData.StatusDatas[_num].Def,
                _agi = _statusData.StatusDatas[_num].Agi,
                _sp = _statusData.StatusDatas[_num].Sp,
                _turn = _statusData.StatusDatas[_num].Turn, 
            };
        }

        SaveClass.I.SetValue(saveData);
    }


    private void OnApplicationQuit() => OverWriteSaveData();


    /// <summary>セーブデータの上書き</summary>
    public void OverWriteSaveData()
    {
        //新たなセーブデータを作成処理
        SaveData saveData = new SaveData()
        {
            _name = SaveClass.I.Name,
            _hp = SaveClass.I.Hp,
            _mp = SaveClass.I.Mp,
            _str = SaveClass.I.Str,
            _def = SaveClass.I.Def,
            _agi = SaveClass.I.Agi,
            _sp = SaveClass.I.Sp,
            _turn = SaveClass.I.Turn,
        };

        //既存のセーブデータを上書き
        JsonSaveManager<SaveData>.Save(saveData, _saveDataPath[_num]);
    }
}