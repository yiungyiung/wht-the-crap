using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWPUS : MonoBehaviour
{
    public AudioClip clip;
   void OnCollisionEnter2D(Collision2D col)
    {  
        if(col.gameObject.tag=="Player")
       { 
        Debug.Log("YO"+col.gameObject.GetComponent<Rigidbody2D>().velocity.x);
        if(col.gameObject.GetComponent<Rigidbody2D>().velocity.x<0)
        {
            Debug.Log("1");
        col.gameObject.GetComponent<Rigidbody2D>().AddForce(col.gameObject.transform.right*-850f);}
        if(col.gameObject.GetComponent<Rigidbody2D>().velocity.x>0)
        {   
            Debug.Log("2");
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(col.gameObject.transform.right*850f);}
        }
        AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);
       }
    }

