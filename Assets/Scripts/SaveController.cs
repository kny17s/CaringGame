using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveController : MonoBehaviour
{
    /// <summary>�ۑ�������Json�̃p�X��</summary>
    public string[] SaveDataPath => _saveDataPath;

    /// <summary>�L����No.</summary>
    public int Num => _num;

    public static SaveController I;

    [SerializeField]
    [Header("�����X�e�[�^�X")]
    StatusData _StatusData;

    /// <summary>�ۑ�������Json�̃p�X��</summary>
    [SerializeField]
    string[] _saveDataPath;

    /// <summary>�L����No.</summary>
    int _num;

    private void Start()
    {
        I = this;

        _num = SelectChar.I.Num;
        //_saveDataPath[_num] = SelectChar.I.SaveData;

        Debug.Log(_num);
        Debug.Log(_saveDataPath[_num]);

        //�Z�[�u�f�[�^�̓ǂݍ���
        SaveData saveData = JsonSaveManager<SaveData>.Load(_saveDataPath[_num]);

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
                _sp = _StatusData.StatusDatas[_num].Sp,
                _turn = _StatusData.StatusDatas[_num].Turn, 
            };
        }

        SaveClass.I.SetValue(saveData);
    }


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
            _sp = SaveClass.I.Sp,
            _turn = SaveClass.I.Turn,
        };

        //�����̃Z�[�u�f�[�^���㏑��
        JsonSaveManager<SaveData>.Save(saveData, _saveDataPath[_num]);
    }
}