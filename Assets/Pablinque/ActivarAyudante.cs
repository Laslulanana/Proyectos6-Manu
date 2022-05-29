using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarAyudante : MonoBehaviour
{
    public GameObject ayudante1;
    public GameObject ayudante2;
    public bool dif;
    // Start is called before the first frame update
    void Start()
    {
        ayudante1 = GameObject.Find("Player2 Stat");
        ayudante2= GameObject.Find("Player3 Stat");
        ayudante1.SetActive(false);
        ayudante2.SetActive(false);
    }

    
}
