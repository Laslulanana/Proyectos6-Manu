using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager inst;
    public Text texto;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        if (inst == null)
        {
            inst = this;
        }
    }

    public void ScoreChange(int value)
    {
        score += value;
        texto.text = "coins:" + score.ToString();
    }
}
