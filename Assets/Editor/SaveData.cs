using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SceneLoader))]//�g������N���X���w��
public class SaveData : Editor
{
    public override void OnInspectorGUI()
    {
        //����Inspector������\��
        base.OnInspectorGUI();

        //�{�^����\��
        if (GUILayout.Button("Button"))
        {
            Debug.Log("������!");
        }
    }
}