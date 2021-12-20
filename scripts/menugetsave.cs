using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menugetsave : MonoBehaviour
{
    public Text score;
    public Text score1;
    public Text score2;
    void Start()
    {
       score.text="TIMER HISCORE: "+ Getint("timer");
       score1.text="MOVING HISCORE: "+ Getint("infinite");
       score2.text="INFINITE HISCORE: "+ Getint("buy");
    }
    public int Getint(string KeyName)
    {
        return PlayerPrefs.GetInt(KeyName);
    }

}
