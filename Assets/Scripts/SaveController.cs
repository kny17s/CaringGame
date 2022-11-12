using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveController : MonoBehaviour
{
    public string SaveDataPath => _saveDataPath;
    public int Num => _num;

    public static SaveController I;

    [SerializeField]
    [Header("�����X�e�[�^�X")]
    StatusData _StatusData;

    /// <summary>�ۑ�����Json�̃p�X��</summary>
    [SerializeField]
    [Header("�ǂݍ��ރZ�[�u�f�[�^�̖��O")]
    string _saveDataPath;

    /// <summary>�L�����i���o�[</summary>
    int _num;

    private void Awake() => I = this;

    private void Start()
    {
        _saveDataPath = SelectChar.I.CharName;
        _num = SelectChar.I.Num;

        //�Z�[�u�f�[�^�̓ǂݍ���
        SaveData saveData = JsonSaveManager<SaveData>.Load(_saveDataPath);

        if (saveData == null)//�Z�[�u�f�[�^�����݂��Ȃ��ꍇ�͒l��������
        {
            //�V���ȃZ�[�u�f�[�^���쐬
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

    //�G�f�B�^��Ŋm�F����Ƃ��͂��������K�v������
    private void OnApplicationQuit() => OverWriteSaveData();


    /// <summary>�Z�[�u�f�[�^�̏㏑��</summary>
    public void OverWriteSaveData()
    {
        //�V���ȃZ�[�u�f�[�^���쐬����
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
        //�����̃Z�[�u�f�[�^���㏑��
        JsonSaveManager<SaveData>.Save(saveData, _saveDataPath);
    }
}