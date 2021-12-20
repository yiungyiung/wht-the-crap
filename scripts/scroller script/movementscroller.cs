using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementscroller : MonoBehaviour
{   
    public Rigidbody2D rb;
    float rotation;
    public float movespeed=15f;
    public float maxspeed =15f;
    public float turnspeed = 15f;
    public float accval =4.0f;
    
    public AudioSource audioSource;
    void FixedUpdate()
    {
        if(rb.velocity.magnitude!=0 && SimpleInput.GetAxis("Horizontal")!=0)
        {
            if (!audioSource.isPlaying)
            {
            audioSource.Play();
            audioSource.volume=0.3f;
            }
        }
        
        //Debug.Log("yash"+rb.velocity.x);
        if (SimpleInput.GetAxis("Horizontal")>0 )
        {
           rb.AddForce(transform.right* movespeed );
            
            movespeed +=accval;
            if (movespeed >=maxspeed)
            {
                movespeed=maxspeed;
            }
             
        
             
        }
        if (SimpleInput.GetAxis("Horizontal")<0 )
        {
           rb.AddForce(transform.right* -1*movespeed );
            
            movespeed +=accval;
            if (movespeed >=maxspeed)
            {
                movespeed=maxspeed;
            }
             
            
        }
    
    
    }
}
