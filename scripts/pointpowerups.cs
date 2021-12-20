using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pointpowerups : MonoBehaviour
{
    public int points;
    public int sc;
    public TMP_Text poitext;
    public GameObject gamana;
    public GameObject mag;
    public int magtime;
    public int score;
    public TMP_Text scoretext;
    public AudioClip clip;
    
    void Start(){
        points=0;
        score=0;
        gamana=GameObject.FindWithTag("gaman");
    }

    void Update()
    {
        sc=score;
 poitext.text="Point: "+points;
 scoretext.text="Score: "+score;
    }
    public void pointup()
    {
        points+=1;
        score+=1;
    }

    public void upspeed()
    {   
        AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);
        gameObject.GetComponent<movemnt>().maxspeed+=2;
    }
    public void upspeed2()
    {   
        AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);
        gameObject.GetComponent<movementscroller>().maxspeed+=3;
    }
    public void upspawn()
    {   
        AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);
        gamana.GetComponent<spawner>().rate-=0.05f;
    }
    public void upspawnsc()
    {   
        AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);
        gamana.GetComponent<spawnersc>().rate-=0.05f;
    }

    public void uphealth()
    {  
        AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);
       gameObject.GetComponent<health>().chhealht();
    }

    public void magnetic()
    {  
    AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);
       magtime+=5;
       Debug.Log("magtime"+magtime);
       mag.SetActive(true);
    }

    public void scrollerpowerup(int i)
    {
        if(i==1)
        {
            upspeed();
        }
        else if(i==2)
        {
            upspawnsc();
        }
        else if(i==3)
        {
            uphealth();
        }
        else if(i==4)
        {   
            
            magnetic();
             magtime=8;
        }
        else if(i==5)
        {   
            
            upspeed2();
        }


    }

   
}
