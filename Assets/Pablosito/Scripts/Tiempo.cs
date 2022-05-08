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

    private void Awake()
    {
        tiempoInicialA = 2;
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
