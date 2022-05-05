using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{
    public static float tiempo;
    public static float tiempoInicialA;
    public Text aTiempo;


    public static bool espadaTiempo;
    public static bool escudoTiempo;
    public static bool botasTiempo;
    public float tiempoEspada;
    public float tiempoEscudo;
    public float tiempoBotas;
    private void Awake()
    {
        if (botasTiempo)        
            Tiempo.tiempoInicialA += tiempoBotas;
        
        if (espadaTiempo)   
            Tiempo.tiempoInicialA += tiempoEspada;
        
        if (escudoTiempo)
            Tiempo.tiempoInicialA += tiempoEscudo;        
        tiempoInicialA = 100;
        tiempo = tiempoInicialA;
    }

    private void Start()
    {
        
    }

    void Update()
    {
        aTiempo.text = tiempo.ToString();
        tiempo -= Time.deltaTime;
        if(tiempo<=0)
        {
            Muerte();
        }
    }

    void Muerte()
    {
        SceneManager.LoadScene("DerrotaN");
    }
}
