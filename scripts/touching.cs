using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class touching : MonoBehaviour
{    public int prefrence;
     Toggle myToggle;  
    void Start()
    {   
        myToggle=GameObject.FindWithTag("toggle").GetComponent<Toggle>();
        prefrence=PlayerPrefs.GetInt("touch");
        Debug.Log("s"+prefrence+myToggle);
        if(prefrence==1){
            Debug.Log("choyes");
           myToggle.isOn=false;
           PlayerPrefs.SetInt("touch",1);
       }
       else if(prefrence==0){
           Debug.Log("chono");
           myToggle.isOn=true;
           PlayerPrefs.SetInt("touch",0);
       }

    }
   
   public  void chnagetouchprefrence()
   {    
       prefrence=PlayerPrefs.GetInt("touch");
       
       if(prefrence==0){
            PlayerPrefs.SetInt("touch",1);
            prefrence=1;
       }
      else if(prefrence==1){
            PlayerPrefs.SetInt("touch",0);
            prefrence=0;
       }
   }
}
