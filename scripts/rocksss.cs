using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocksss : MonoBehaviour
{
    public float rate;

    // Update is called once per frame
    void Update()
    { /*deltime+=Time.deltaTime;
        if (deltime>rate)
        {
           deltime=0;
            Debug.Log("time"+deltime);
            own.SetActive(false);
        }*/
        Destroy(gameObject, rate);
    }

    void OnCollisionEnter2D(Collision2D col)
    {   
       if(col.gameObject.tag=="Player")
       { 
       col.gameObject.GetComponent<health>().dechealth((int)Mathf.Ceil(col.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude ));
       }
    }
}
