using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class health : MonoBehaviour
{
    public int healthy;
    public TMP_Text heltext;
    public GameObject ress;
    public int  i; 
    
    void Start()
    {
        healthy=100;
    }
    void Update()
{   
   
    if (healthy<=0)
{   
    
    ress.SetActive(true);
    if (i==0)
    {
    (GameObject.FindWithTag("gaman")).GetComponent<spawner>().gameover=true;}
    else{
        (GameObject.FindWithTag("gaman")).GetComponent<spawnersc>().gameover=true;
    }
    gameObject.SetActive(false);
    heltext.text="Dead";
}
    heltext.text="Health: "+healthy;
}
   public void dechealth(int dam)
    {
        Debug.Log("dam" + dam);
        healthy=healthy-dam;
    }

    public void chhealht()
    {   

        healthy+=20;
        if(healthy>100)
        {
            healthy=100;
        }
    }
}
