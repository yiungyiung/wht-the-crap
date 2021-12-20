using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemnt : MonoBehaviour
{   
    public Rigidbody2D rb;
    float rotation;
    public float movespeed=15f;
    public float maxspeed =15f;
    public float turnspeed = 15f;
    public float accval =4.0f;
    
    public AudioSource audioSource;
    // Start is called before the first frame update
 
    void FixedUpdate()
    {
        

        if (SimpleInput.GetAxis("Vertical")>0 )
        {
           rb.AddForce(transform.up* movespeed );
            rb.rotation = rotation - SimpleInput.GetAxis("Horizontal")*turnspeed*Time.deltaTime*10;
            movespeed +=accval;
            if (movespeed >=maxspeed)
            {
                movespeed=maxspeed;
            }
             audioSource.volume =SimpleInput.GetAxis("Vertical")/3F;
            if (!audioSource.isPlaying)
            {
            audioSource.Play();}
            Debug.Log("yash"+SimpleInput.GetAxis("Vertical")); 
        }
   
    else{
        rb.AddForce(transform.up*3);}
        if((int)rb.velocity.magnitude!=0)
         {
 
                 rb.rotation = rotation - SimpleInput.GetAxis("Horizontal")*turnspeed*Time.deltaTime*10;

         }
        rotation=Mathf.Deg2Rad* rotation;
        rotation = rb.rotation;
        
    }
}
