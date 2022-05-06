using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuShervin : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //hay que buildear esta escena como la primera de todas en el Index

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
