using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pointcash : MonoBehaviour
{
    public int points;
    public int increment;
    public GameObject pla;
    public Button buttonn;
    public TMP_Text poineeded;
    public AudioClip clip;
    void Start()
    {
        pla=GameObject.FindWithTag("Player");
        poineeded.text=""+points;
    }

   
    void Update()
    {
        if (pla.GetComponent<pointpowerups>().points>=points)
        {
            buttonn.interactable=true;
            

        }
        if (pla.GetComponent<pointpowerups>().points<points)
        {
            buttonn.interactable=false;
            

        }
    }

     public void changepointcas()
    {   
        pla.GetComponent<pointpowerups>().points-=points;
        points+=increment;
        poineeded.text=""+points;
        AudioSource.PlayClipAtPoint(clip, new Vector3(0,0,0), 1);
    }
}
