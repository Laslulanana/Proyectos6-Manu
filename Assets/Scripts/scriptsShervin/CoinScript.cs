using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    public int points = 1;
   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("points: " + points);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag.Equals("Monedo"))
        {
            ScoreManager.inst.ScoreChange(points);
            //points++;
            //Debug.Log("points: " + points);
            Destroy(coll.gameObject);
        }
    }
}
