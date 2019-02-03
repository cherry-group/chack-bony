﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukcemberkod : MonoBehaviour
{

    Rigidbody2D fizik;
    public float hiz;
    bool hareketkontrol = false;
    GameObject oyunyoneticisi;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        oyunyoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisitag");
    }

   
    void FixedUpdate()
    {   if (!hareketkontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);

        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag=="donencembertag")
        {
            transform.SetParent(col.transform);
            hareketkontrol = true;
        }
        if (col.tag=="kucukcembertag")
        {
            oyunyoneticisi.GetComponent<OyunYoneticisi>().oyunbitti();
        }
    }


}
