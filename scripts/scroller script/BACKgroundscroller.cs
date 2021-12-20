using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BACKgroundscroller : MonoBehaviour
{

    Vector2 offset;
    public float scrollspeed=2f;
    Material material;

 void Awake()
 {
    material=GetComponent<Renderer>().material;
 }
    // Update is called once per frame
    void Update()
    {
      offset =new Vector2(0,scrollspeed*Time.time);
      material.mainTextureOffset=offset;
   
    }
}


