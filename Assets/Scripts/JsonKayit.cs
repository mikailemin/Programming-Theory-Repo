using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JsonKayit : MonoBehaviour
{
    public TMP_InputField uname;
    public TMP_InputField health;
    public TMP_InputField damage;
    public TextMeshProUGUI textname;
    
    public string names;
    public float healths;
    public float damages;


    public void Save()
    {
       names=uname.text;
        healths = Convert.ToInt32(health.text);
        damages = Convert.ToInt32(damage.text);
        JsonVerisi jsonVerisi=new JsonVerisi(names,healths,damages);
        string jsonString=JsonUtility.ToJson(jsonVerisi);
        File.WriteAllText(Application.dataPath + "/Saves/JsonVerisiJson.json",jsonString);

    }
    public void Load()
    {
      JsonVerisi veri= JsonUtility.FromJson<JsonVerisi>(File.ReadAllText(Application.dataPath + "/Saves/JsonVerisiJson.json"));

        textname.text = veri.Name;
    }
}
