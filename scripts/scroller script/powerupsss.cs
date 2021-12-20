using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupsss : MonoBehaviour
{
    public float rate;
    public float randomss;
    public float time;
    public int index;

       
    void Update()
    {   
        
        gameObject.transform.Rotate( 0,0 , 0.3f);
        gameObject.transform.position = Vector2.Lerp(gameObject.transform.position,new Vector2(gameObject.transform.position.x,-49f) , 0.0001f*rate);
        time += Time.deltaTime;
        if (time >= 0.5) {
         time = 0.0f;
         randomss=Random.Range(0.3f,0.5f);
         Destroy(gameObject,4);
         
         //gameObject.transform.localScale=new Vector3(randomss,randomss,0);
        
    }
    }
     void OnTriggerEnter2D(Collider2D col)
    {   
        if(col.tag=="Player")
       { col.gameObject.GetComponent<pointpowerups>().scrollerpowerup(index);
       Destroy(gameObject);}
    }
}
