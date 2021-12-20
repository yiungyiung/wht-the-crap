using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;
 

public class restart : MonoBehaviour
{
    public AudioClip clip;
   public void restarts ()
    {
    AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);   
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void menuback()
    {   
        AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);
        SceneManager.LoadScene("menu");
    }
}
