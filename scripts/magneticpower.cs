using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class magneticpower : MonoBehaviour
{
    public GameObject pla;
    public float timer;
    public int rate;
    public TMP_Text timetext;

    void Start()
    { 
        timer=0;
        
    }

    
    void Update()
    {   
        timer += Time.deltaTime;
        Debug.Log("rate|time"+timer+"|"+rate);
        if (timer >= rate) {
        Debug.Log("exec");
        timer=0;
        rate=pla.GetComponent<pointpowerups>().magtime;
        //Debug.Log("rate|time"+timer+"|"+rate);
        timetext.text="";
        gameObject.SetActive(false);
        }
        else{
         timetext.text=""+(int)(rate-timer);
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position,10);
        foreach (Collider2D nearbyObject in colliders)
        {   
            if(nearbyObject.gameObject.tag=="trash")
            {
                nearbyObject.gameObject.transform.position = Vector2.Lerp(nearbyObject.gameObject.transform.position, pla.transform.position , 0.1f);
            }
        }
        }
    }

     private void OnDrawGizmos() {
     Gizmos.color = Color.red;
     Gizmos.DrawWireSphere (transform.position , 10);
 }
}
