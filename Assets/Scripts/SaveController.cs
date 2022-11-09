using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveController : MonoBehaviour
{
    public static SaveController I { get; private set; }

    string saveDataPath = "SaveData";
    private void Awake()
    {
        I = this;
    }

    private void Start()
    {
        //セーブデータの読み込み
        SaveData saveData = JsonSaveManager<SaveData>.Load(saveDataPath);

        if (saveData == null)
        {
            //新たなセーブデータを作成
            saveData = new SaveData()
            {
                num = 3,
                str = "テスト",
            };
        }

        SaveClass.I.SetValue(saveData);
    }

    private void OnApplicationPause(bool isPaused)//アンドロイドスマホではこっちが必要だった
    {
        if (isPaused)
        {
            OverWriteSaveData();
        }
    }

    private void OnApplicationQuit()//エディタ上で確認するときはこっちが必要だった
    {
        OverWriteSaveData();
    }

    //セーブデータの上書き
    void OverWriteSaveData()
    {
        //新たなセーブデータを作成処理
        SaveData saveData = new SaveData()
        {
            num = SaveClass.I.num,
            str = SaveClass.I.str,
        };

        //既存のセーブデータを上書き
        JsonSaveManager<SaveData>.Save(saveData, saveDataPath);
    }
}