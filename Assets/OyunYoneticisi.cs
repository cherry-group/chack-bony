using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        StartCoroutine(cagrilanmet());
    }


    IEnumerator cagrilanmet()
    {
        donencember.GetComponent<dondurme>().enabled = false;
        anacember.GetComponent<anacemberkod>().enabled = false;
        animator.SetTrigger("oyunbitti");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("anamenu");
    }


}
