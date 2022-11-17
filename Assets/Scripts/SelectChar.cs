using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectChar : MonoBehaviour
{
    public static SelectChar I;

    public int Num => _num;

    public string SaveData => _saveData; 

    [SerializeField]
    [Header("シーンの名前")]
    string _sceneName;

    /// <summary>キャラNo.</summary>
    int _num;

    /// <summary>キャラ名</summary>
    string _saveData;

    private void Awake() => I = this;

    public void SelectNum(int num)
    {
        _num = num;
    }

    public void SelectName(string name)
    {
        _saveData = name;
        SceneManager.LoadScene(_sceneName);
    }
}
