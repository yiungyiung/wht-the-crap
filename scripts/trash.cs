using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trash : MonoBehaviour
{
    public float rate;
    public float randomss;
    public float time;
    float x;
    float y;
    public AudioClip clip;

    
    void Update()
    {   
        gameObject.transform.Rotate( 0,0 , 0.3f);
        time += Time.deltaTime;
        if (time >= 0.5) {
         time = 0.0f;
         randomss=Random.Range(0.2f,0.6f);
         gameObject.transform.localScale=new Vector3(randomss,randomss,0);
         Destroy(gameObject, rate);}
    }

    void OnTriggerEnter2D(Collider2D col)
    {   
    if(col.tag=="Player")
       { 
      
       col.gameObject.GetComponent<pointpowerups>().pointup(); 
       AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);
       Destroy(gameObject);
       }
    }
}
