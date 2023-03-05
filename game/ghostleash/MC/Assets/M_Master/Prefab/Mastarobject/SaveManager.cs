﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//アクセス：Mater,JsonHelper
//セーブとロード
public class SaveManager : MonoBehaviour
{
    public void DetaSave()
    {
        string deta = JsonUtility.ToJson(Master.playerdeta);
        PlayerPrefs.SetString("PlayerDeta",deta);
        Master.formationdeta.Save();
    }

    public void DetaLoad()
    {
        //初ロード時は"NoDeta"が返されます
        if (PlayerPrefs.GetString("PlayerDeta", "NoDeta").Equals("NoDeta"))
        {
            Master.playerdeta = new PlayerDeta("first");
            string deta = JsonUtility.ToJson(Master.playerdeta);
            PlayerPrefs.SetString("PlayerDeta", deta);
        }
        else
        {
            Master.playerdeta = JsonUtility.FromJson<PlayerDeta>(PlayerPrefs.GetString("PlayerDeta"));
        }
        Master.formationdeta.Load();
    }
}
