using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogActivator : MonoBehaviour
{   
    public string[] lines;
    private bool canActivate;
    public bool isPerson = true;

    public bool shouldActiveQuest;
    public string questToMark;
    public bool markComplete;

   
    void Update()
    {
        if(canActivate && Input.GetKeyDown(KeyCode.E) && !DialogManager.instance.dialogBox.activeInHierarchy)
        {
            DialogManager.instance.showDialog(lines, isPerson);
            DialogManager.instance.ShouldActiveQuestAtEnd(questToMark, markComplete);

        }
    }
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            canActivate = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player")
        {
            canActivate = false;
        }
    }
}
