using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class temporizador : MonoBehaviour
{
    public Text tiempoText;
    public float tiempoS = 59;
    public float tiempoM = 5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        tiempoS -=Time.deltaTime;

        if(tiempoS<=0)
        {
            tiempoM--;
            tiempoS += 59;
        }

        if(tiempoS>=60)
        {
            tiempoM++;
            tiempoS -=60;
        }

        string textoAparecer= "Temporizador " +tiempoM.ToString("f0")+" : "+ tiempoS.ToString("f0");
        tiempoText.text = textoAparecer;
    }
}
