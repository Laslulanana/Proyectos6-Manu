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
    public float tiempoI;

    public static bool espadaTiempo;
    public static bool escudoTiempo;
    public static bool botasTiempo;

    public GameObject espada;
    public GameObject escudo;
    public GameObject botas;

    private void Awake()
    {
        espada = GameObject.Find("EspadaTiempo");
        escudo = GameObject.Find("EscudoTiempo");
        botas = GameObject.Find("BotasTiempo");
        tiempoInicialA = tiempoI;
        if (espadaTiempo)
        {
            tiempoInicialA += 60;
        }
        if (escudoTiempo)
        {
            tiempoInicialA += 60;
        }
        if (botasTiempo)
        {
            tiempoInicialA += 60;
        }
        
        tiempo = tiempoInicialA;
    }

    void Update()
    {
        
        tiempoI = tiempo;
        tiempo -= Time.deltaTime;
        
        if(tiempo<=0)
        {
            Debug.Log("si");
            Muerte();
        }

        DisplayTime(tiempo);

        if (espadaTiempo)
        {
            espada.SetActive(false);
        }
        if (escudoTiempo)
        {
            escudo.SetActive(false);
        }
        if (botasTiempo)
        {
            botas.SetActive(false);
        }

    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay <0)
        {
            timeToDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        aTiempo.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        //aTiempo.text = tiempo.ToString();
    }
    void Muerte()
    {
        Debug.Log("no");
        SceneManager.LoadScene("GameOver");
    }
}
