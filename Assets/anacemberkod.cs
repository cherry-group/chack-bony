using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anacemberkod : MonoBehaviour
{
    public GameObject kucukcember;
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            kucukcemberolustur();
        }
    }
    void kucukcemberolustur()
    {
        Instantiate(kucukcember, transform.position, transform.rotation);
    }
}
