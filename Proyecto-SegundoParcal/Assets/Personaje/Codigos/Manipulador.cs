using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manipulador : MonoBehaviour
{
    Vida playerVida;

    public int cantidad;
    public float damgeTime;
    float currentDamageTime;

    // Start is called before the first frame update
    void Start()
    {
        
        playerVida = GameObject.FindWithTag("Player2").GetComponent<Vida>();

    }

    private void OnTriggerStay(Collider other)
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
