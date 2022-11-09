using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonSaveManager<T>
{
    static string SavePath(string path)
        => $"{Application.persistentDataPath}/{path}.json";

    public static void Save(T data, string path)
    {
        StreamWriter sw = new StreamWriter(SavePath(path), false);
        string jsonstr = JsonUtility.ToJson(data, true);
        sw.Write(jsonstr);
        sw.Flush();
    }

    public static T Load(string path)
    {
        if (File.Exists(SavePath(path)))//�f�[�^�����݂���ꍇ�͕Ԃ�
        {
            StreamReader sr = new StreamReader(SavePath(path));
            string datastr = sr.ReadToEnd();
            return JsonUtility.FromJson<T>(datastr);
        }
        //���݂��Ȃ��ꍇ��default��ԋp
        return default;
    }
}
