using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashscroller : MonoBehaviour
{
    public float rate;
    public float randomss;
    public float time;
   public AudioClip clip;

       
    void Update()
    {   
        
        gameObject.transform.Rotate( 0,0 , 0.3f);
        gameObject.transform.position = Vector2.Lerp(gameObject.transform.position,new Vector2(gameObject.transform.position.x,-49f) , 0.0001f*rate);
        time += Time.deltaTime;
        if (time >= 0.5) {
         time = 0.0f;
         randomss=Random.Range(0.3f,0.5f);
         
         gameObject.transform.localScale=new Vector3(randomss,randomss,0);
        
    }
    }

    void OnTriggerEnter2D(Collider2D col)
    {   
        if(col.tag=="Player")
       { col.gameObject.GetComponent<pointpowerups>().pointup();
       AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1); 
       Destroy(gameObject);
       }

       if(col.tag=="last")
       { 
       Destroy(gameObject);
       }
    }
   
}


