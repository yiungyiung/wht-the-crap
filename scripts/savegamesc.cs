using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class savegamesc : MonoBehaviour
{
 public Text hiscore;
 public Text score;
 public int hi;
 public int sc;
 public string KyName;
 public GameObject pla;
 void Start()
 {
     hi=Getint(KyName);
     sc=pla.GetComponent<pointpowerups>().sc;
     score.text="YOUR SCORE IS: "+sc;
     hiscore.text="HISCORE IS: "+hi;
     if(sc>hi)
     {
         SetInt( KyName, sc);
         score.text="NEW HISCORE : "+sc;
     }

 }

public void SetInt(string KeyName, int Value)
    {
        PlayerPrefs.SetInt(KeyName, Value);
    }

    public int Getint(string KeyName)
    {
        return PlayerPrefs.GetInt(KeyName);
    }
}
