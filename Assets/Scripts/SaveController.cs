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
        //�Z�[�u�f�[�^�̓ǂݍ���
        SaveData saveData = JsonSaveManager<SaveData>.Load(saveDataPath);

        if (saveData == null)
        {
            //�V���ȃZ�[�u�f�[�^���쐬
            saveData = new SaveData()
            {
                num = 3,
                str = "�e�X�g",
            };
        }

        SaveClass.I.SetValue(saveData);
    }

    private void OnApplicationPause(bool isPaused)//�A���h���C�h�X�}�z�ł͂��������K�v������
    {
        if (isPaused)
        {
            OverWriteSaveData();
        }
    }

    private void OnApplicationQuit()//�G�f�B�^��Ŋm�F����Ƃ��͂��������K�v������
    {
        OverWriteSaveData();
    }

    //�Z�[�u�f�[�^�̏㏑��
    void OverWriteSaveData()
    {
        //�V���ȃZ�[�u�f�[�^���쐬����
        SaveData saveData = new SaveData()
        {
            num = SaveClass.I.num,
            str = SaveClass.I.str,
        };

        //�����̃Z�[�u�f�[�^���㏑��
        JsonSaveManager<SaveData>.Save(saveData, saveDataPath);
    }
}