using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    void Update()
    {
        if (score >= 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void ScoreChange(int value)
    {
        score += value;
        texto.text = "coins:" + score.ToString();
    }
}
