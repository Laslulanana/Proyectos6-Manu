using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMobs : MonoBehaviour
{
    public bool MobsActivo;
    float timer;
    float random;

    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (MobsActivo)
        {
            timer += Time.deltaTime;

            if(timer >=1)
            {
                random = Random.Range(0, 10);

                if(random >=7)
                {
                    Combate();
                }else if(random <=7)
                {
                    timer = 0;
                }
            }
        }
    }

    void Combate()
    {

    }
}
