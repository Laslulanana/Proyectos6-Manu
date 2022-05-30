using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtenerAyudantes : MonoBehaviour
{
    public GameObject ayudante1;
    public GameObject ayudante2;

    public bool esEl1;
    // Start is called before the first frame update
    void Start()
    {
        ayudante1 = GameObject.Find("Player2 Stat");
        ayudante2 = GameObject.Find("Player3 Stat");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        
            if (esEl1 == true)
            {
                ayudante1.SetActive(true);
            }
            else
            {
                ayudante2.SetActive(true);
            }
        
    }
}

