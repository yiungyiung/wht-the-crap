using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushaway : MonoBehaviour
{   
    public AudioClip clip;
   void OnCollisionEnter2D(Collision2D col)
    {  
        if(col.gameObject.tag=="Player")
       { 
        
        col.gameObject.GetComponent<Rigidbody2D>().AddForce(col.gameObject.transform.up*-850f);
        AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);
       }
    }
}
