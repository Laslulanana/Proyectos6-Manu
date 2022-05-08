using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMobs : MonoBehaviour
{
    public bool MobsActivo;
    float timer;
    float random;
    public int probabilidad;

    BattleStarter battleStarter;

    public static bool combateActivo;
    void Start()
    {
        timer = 0f;

        battleStarter =this.GetComponent<BattleStarter>(); 

    }

    // Update is called once per frame
    void Update()
    {
        if (MobsActivo && combateActivo)
        {
            timer += Time.deltaTime;

            if(timer >=1)
            {
                random = Random.Range(0, 10);

                if(random >= probabilidad)
                {
                    Combate();
                }else if(random <= probabilidad)
                {
                    timer = 0;
                }
            }
        }
    }

    void Combate()
    {
        combateActivo = false;
        StartCoroutine(battleStarter.StartBattleCo());

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MobsActivo = true;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MobsActivo = true;
        }
    }
}
