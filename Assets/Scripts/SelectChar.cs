using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectChar : MonoBehaviour
{
    public static SelectChar I;

    public int Num => _num;
    public string CharName => _charName;

    [SerializeField]
    [Header("ƒV[ƒ“‚Ì–¼‘O")]
    string _sceneName;

    string _charName;

    int _num;

    private void Awake() => I = this;

    public void SceneLoader(string name)
    {
        _charName = name;
        SceneManager.LoadScene(_sceneName);
    }

    public void SelectLoader(int num) => _num = num;
}
