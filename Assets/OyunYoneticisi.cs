using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunYoneticisi : MonoBehaviour
{

    GameObject donencember;
    GameObject anacember;
    public Animator animator;
    void Start()
    {
        anacember = GameObject.FindGameObjectWithTag("anacembertag");
        donencember = GameObject.FindGameObjectWithTag("donencembertag");
    }


    public void oyunbitti()
    {
        donencember.GetComponent<dondurme>().enabled = false;
        anacember.GetComponent<anacemberkod>().enabled = false;
        animator.SetTrigger("oyunbitti");
    }

}
