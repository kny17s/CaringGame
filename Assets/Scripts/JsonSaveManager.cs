using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonSaveManager<T>
{
    static string SavePath(string path) => $"C:/Unity/CaringGame/Assets/{path}.json";

    /// <summary>�f�[�^��Json�ŕۑ�</summary>
    /// <param name="data"></param>
    /// <param name="path"></param>
    public static void Save(T data, string path)
    {
        using (StreamWriter sw = new StreamWriter(SavePath(path), false))
        {
            string jsonstr = JsonUtility.ToJson(data, true);
            sw.Write(jsonstr);
            sw.Flush();
        }
    }

    /// <summary>�ۑ�����Json��ǂݍ���</summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static T Load(string path)
    {
        if (File.Exists(SavePath(path)))//�f�[�^�����݂���ꍇ�͕Ԃ�
        {
            using (StreamReader sr = new StreamReader(SavePath(path)))
            {
                string datastr = sr.ReadToEnd();
                return JsonUtility.FromJson<T>(datastr);
            }
        }
        //���݂��Ȃ��ꍇ��default��ԋp
        return default;
    }
}
