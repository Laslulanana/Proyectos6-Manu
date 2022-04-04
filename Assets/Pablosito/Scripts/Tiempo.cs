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

    private void Awake()
    {
        tiempoInicialA = 100;
        tiempo = tiempoInicialA;
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
        SceneManager.LoadScene("");
    }
}
