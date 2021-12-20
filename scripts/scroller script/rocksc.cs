using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocksc : MonoBehaviour
{
    public float rate;
    public float rate2;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector2.Lerp(gameObject.transform.position,new Vector2(gameObject.transform.position.x,-49f) , 0.0001f*rate);
    }

    void OnCollisionEnter2D(Collision2D col)
    {   
       if(col.gameObject.tag=="Player")
       { 
       col.gameObject.GetComponent<health>().dechealth((int)(Mathf.Ceil(col.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude )*rate2));
       }
    }
}
