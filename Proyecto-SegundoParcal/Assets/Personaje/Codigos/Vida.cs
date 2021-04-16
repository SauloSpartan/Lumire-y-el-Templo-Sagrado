using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public float vida = 100;

    private CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);
        if (vida <= 0) ;
        {
            controller.enabled = false;
        }
    }
}
