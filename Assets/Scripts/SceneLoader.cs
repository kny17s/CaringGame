using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader I;
    [SerializeField]
    [Header("‘JˆÚ‚µ‚½‚¢ƒV[ƒ“‚Ì–¼‘O")]
    string _sceneName;

    public void Awake() => I = this;
    public void SceneLoad() => SceneManager.LoadScene(_sceneName);
}
