using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SLIDERRR : MonoBehaviour
{
 public  Slider volslider;// Start is called before the first frame update
 public AudioSource aSource;
    void Awake()
    {
       aSource = GameObject.FindWithTag("music").GetComponentInChildren<AudioSource>();
       GameObject.FindWithTag("music").GetComponent<DONTTTT>().volslider=volslider;
        volslider.value=aSource.volume;
    }

    public void changevo()
    {
        GameObject.FindWithTag("music").GetComponentInChildren<AudioSource>().volume=volslider.value;
    }




}
