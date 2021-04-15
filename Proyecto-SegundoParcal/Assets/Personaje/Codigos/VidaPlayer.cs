using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public float vida = 100;

    public Image barraDeVida;

    private Animator anim;


    // Start is called before the first frame update
    void Start ()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);

        barraDeVida.fillAmount = vida / 100;

        if (vida <= 0)
        {
            anim.enabled = false;
            
        }
    }
}
