using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ETiempo : MonoBehaviour
{
    public bool espada;
    public bool escudo;
    public bool botas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Tiempo.espadaTiempo)
        {
            if(espada)
            {
                this.gameObject.SetActive(false);
            }
            
        }
        if (Tiempo.escudoTiempo)
        {
            if (escudo)
            {
                this.gameObject.SetActive(false);
            }

        }
        if (Tiempo.botasTiempo)
        {
            if (botas)
            {
                this.gameObject.SetActive(false);
            }

        }
    }
}
