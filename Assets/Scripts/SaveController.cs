using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveController : MonoBehaviour
{
    public string SaveDataPath => _saveDataPath;
    public int Num => _num;

    public static SaveController I;

    [SerializeField]
    [Header("初期ステータス")]
    StatusData _StatusData;

    /// <summary>保存したJsonのパス名</summary>
    [SerializeField]
    [Header("読み込むセーブデータの名前")]
    string _saveDataPath;

    /// <summary>キャラナンバー</summary>
    int _num;

    private void Awake() => I = this;

    private void Start()
    {
        _saveDataPath = SelectChar.I.CharName;
        _num = SelectChar.I.Num;

        //セーブデータの読み込み
        SaveData saveData = JsonSaveManager<SaveData>.Load(_saveDataPath);

        if (saveData == null)//セーブデータが存在しない場合は値を初期化
        {
            //新たなセーブデータを作成
            saveData = new SaveData()
            {
                _name = _StatusData.StatusDatas[_num].Name,
                _hp = _StatusData.StatusDatas[_num].Hp,
                _mp = _StatusData.StatusDatas[_num].Mp,
                _str = _StatusData.StatusDatas[_num].Str,
                _def = _StatusData.StatusDatas[_num].Def,
                _agi = _StatusData.StatusDatas[_num].Agi,
                _lv = _StatusData.StatusDatas[_num].Lv,
                _sp = _StatusData.StatusDatas[_num].Sp,
                _turn = _StatusData.StatusDatas[_num].Turn, 
            };
        }

        SaveClass.I.SetValue(saveData);
    }

    //エディタ上で確認するときはこっちが必要だった
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
            _lv = SaveClass.I.Lv,
            _sp = SaveClass.I.Sp,
            _turn = SaveClass.I.Turn,
        };
        //既存のセーブデータを上書き
        JsonSaveManager<SaveData>.Save(saveData, _saveDataPath);
    }
}