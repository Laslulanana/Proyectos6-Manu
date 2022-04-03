using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Tiempo : MonoBehaviour
{
    public static float tiempo;
    public float tiempoInicial;

    private void Awake()
    {
        tiempo = tiempoInicial;
    }

    void Update()
    {
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
