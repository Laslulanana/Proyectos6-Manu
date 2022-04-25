using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipamientoTiempo : MonoBehaviour
{
    public bool espadaTiempo;
    public bool escudoTiempo;
    public bool botasTiempo;
    public float tiempoEspada;
    public float tiempoEscudo;
    public float tiempoBotas;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (botasTiempo)
        {
            Tiempo.tiempoInicialA += tiempoBotas;
        }
        if (espadaTiempo)
        {
            Tiempo.tiempoInicialA += tiempoEspada;
        }
        if (escudoTiempo)
        {
            Tiempo.tiempoInicialA += tiempoEscudo;
        }
    }
}
