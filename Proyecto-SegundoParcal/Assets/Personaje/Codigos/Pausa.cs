using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    private bool pause = false;
    public GameObject panelPausa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause = !pause;
        }

        if (pause)
        {
            Time.timeScale = 0;
            panelPausa.SetActive(true);
        }

        if (!pause)
        {
            Time.timeScale = 1;
            panelPausa.SetActive(false);
        }
        
    }
}
