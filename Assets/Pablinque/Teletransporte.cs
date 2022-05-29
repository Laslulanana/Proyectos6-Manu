using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Teletransporte : MonoBehaviour
{
    public GameObject tp1;
    public bool esperar=false;
    public float tiempoEspera=1;

    // Start is called before the first frame update
    private void Update()
    {
        if(esperar==true)
        {
            tiempoEspera -= Time.deltaTime;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            esperar = true;

            if (tiempoEspera <= 0)
            {
                collision.transform.position = tp1.transform.position;
            }
        }
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            esperar = false;
            tiempoEspera = 1;
        }
    }

}
