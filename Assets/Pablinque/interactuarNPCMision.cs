using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactuarNPCMision : MonoBehaviour
{
    public GameObject Enemigo;
    public GameObject exclamation;
    // Start is called before the first frame update
    void Start()
    {
        Enemigo.SetActive(false);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                
                Enemigo.SetActive(true);
                exclamation.SetActive(false);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Enemigo.SetActive(true);
            exclamation.SetActive(false);
        }
    }
}
