using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class spawner : MonoBehaviour
{    public Vector2 spawnloc;
     public float changeloc;
     public float rate;
     public float rotations;
     public GameObject prefab1;
     public GameObject prefab2;
     public GameObject prefab3;
     public GameObject prefab4;
     public GameObject prefab5;
     public TMP_Text timertext;
     public GameObject ress;
     public float time;
     public bool gameover;
     public bool timeeryes;
     void Start()
     {
         time=60f;
         gameover=false;
     }
    void Update()
    {   //Debug.Log(Time.time>changeloc);
        
        if (timeeryes &&time<=0  && !gameover)
        {   
            
            
            Debug.Log("restart");
            (GameObject.FindWithTag("Player")).SetActive(false);
            ress.SetActive(true);
            timertext.text="over";
            gameover=true;
        }

        else if (!gameover){
            if(timeeryes)
            {
            time-=Time.deltaTime;
            timertext.text=""+(int)time;}
            else
            {
              timertext.text="";  
            }
        if (Time.time>changeloc)
        {   
            
            changeloc=Time.time+rate;
            spawnloc= new Vector2(Random.Range(-25f,25f),Random.Range(-24f,25f));
            
            
            switch (Random.Range(1,6))
            {
               
                

            case 1:{
            Instantiate(prefab1, spawnloc, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
            break;}
            case 2:{
            Instantiate(prefab2, spawnloc,Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
            break;}
            case 3:{
            Instantiate(prefab3, spawnloc, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
            break;}
            case 4:{
            Instantiate(prefab4, spawnloc, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
            break;}
            case 5:{
            Instantiate(prefab5, spawnloc,Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
            break;}
            }
            
        }
        }
    }
}

