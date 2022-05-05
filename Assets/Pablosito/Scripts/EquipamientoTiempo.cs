using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipamientoTiempo : MonoBehaviour
{
    public GameObject espada;
    public GameObject escudo;
    public GameObject botas;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Tiempo.espadaTiempo)
        {
            espada.SetActive(false);
        }
        if (Tiempo.escudoTiempo)
        {
            escudo.SetActive(false);
        }
        if (Tiempo.botasTiempo)
        {
            botas.SetActive(false);
        }

    }
}
