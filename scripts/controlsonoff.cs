using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlsonoff : MonoBehaviour
{   public int pre;
   void Start()
   {    pre=PlayerPrefs.GetInt("touch");
       Debug.Log("chininini"+pre);
       if(pre==0)
   {
       gameObject.SetActive(true);
   }
   else if(pre==1)
   {
       gameObject.SetActive(false);
   }
   }
}
