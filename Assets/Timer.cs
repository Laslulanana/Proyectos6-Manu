using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static float tiempo;
    public float tiempoinicial;

    void Awake()
    {
        tiempo = tiempoinicial;
    }
    void Update()
    {
        tiempo -= Time.deltaTime;
        if (tiempo <= 0)
        {
            finJuego();
        }
    }
    void finJuego()
    {
        SceneManager.LoadScene("as");
    }
}
    

