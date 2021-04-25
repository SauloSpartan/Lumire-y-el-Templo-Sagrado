﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipuladorVida : MonoBehaviour
{
    VidaPlayer playerVida;

    public int cantidad;
    public float damgeTime;
    float currentDamageTime;

    // Start is called before the first frame update
    void Start()
    {
        playerVida = GameObject.FindWithTag("Player").GetComponent<VidaPlayer>();
        
    }

    private void OnTriggerStay (Collider other)
    {
         currentDamageTime += Time.deltaTime;
         if (currentDamageTime > damgeTime)
         {
              playerVida.vida += cantidad;
              currentDamageTime = 0.0f;
         }
      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
