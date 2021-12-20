using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscrpt : MonoBehaviour
{
  public AudioClip clip;
    public void timer() { 
        AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1); 
        SceneManager.LoadScene("actualtimer");  
    } 
    public void infity() {  
        AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);
        SceneManager.LoadScene("infinite");}  
    public void infinity() { 
        AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1); 
        SceneManager.LoadScene("timer");} 
    public void menuback()
    {   
        AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);
        SceneManager.LoadScene("menu");
    } 
    public  void restart()
    {   
        AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public  void exitt()
    {   
        AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);
         Application.Quit();
    }
    public  void abot()
    {   
        AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);
         
    }
    public void teamseas()
    {
        AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);
        Application.OpenURL("https://teamseas.org/");
    }
}

