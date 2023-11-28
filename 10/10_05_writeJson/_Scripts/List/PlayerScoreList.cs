using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PlayerScoreList
{
    public List<PlayerScore> list = new List<PlayerScore>();

    public string ToJson()
    {
        return JsonUtility.ToJson(this, true);
    }
}