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
        if (espada)
        {
            if (Tiempo.espadaTiempo == true)
            {
                this.gameObject.SetActive(false);
            }
        }
        if (escudo)
        {
            if (Tiempo.escudoTiempo == true)
            {
                this.gameObject.SetActive(false);
            }
        }
        if (botas)
        {
            if (Tiempo.botasTiempo == true)
            {
                this.gameObject.SetActive(false);
            }
        }

    }
}
