using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DONTTTT : MonoBehaviour
{
 [SerializeField] public  AudioSource ass;
 public  Slider volslider;
 
static bool created = false;
 void Awake() {
    
     if (!created) {
         DontDestroyOnLoad (this.gameObject);
         created = true;
     } else {
         Destroy (this.gameObject);
     }
 }
     
}
