using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectChar : MonoBehaviour
{
    public static SelectChar I;
    public int Num => _num;
    public string SaveData => _saveData; 

    /// <summary>�L����No.</summary>
    int _num;

    /// <summary>�L������</summary>
    string _saveData;

    private void Awake() => I = this;

    public void SelectNum(int num) => _num = num;

    public void SelectName(string name) => _saveData = name;
}
