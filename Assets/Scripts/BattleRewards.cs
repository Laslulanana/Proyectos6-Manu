using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BattleRewards : MonoBehaviour
{
    public static BattleRewards instance;

    public Text xpText, itemText,tiempoText;
    public GameObject rewardScreen;

    public string[] rewardItems;
    public int xpEarned;
    public int rewardT;

    public bool markQuestComplete;
    public string questToMark;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Y))
        {
             OpenRewardScreen(54 , new string[] { "Iron Sword", "Iron Armor"},10);
        }
    }

    public void OpenRewardScreen(int xp, string[] rewards,int Tempo)
    {
        xpEarned = xp;
        rewardItems = rewards;
        rewardT = Tempo;
        Debug.Log("1");

        Tiempo.tiempo += rewardT;

        xpText.text = "Everyone earned " + xpEarned + " exp!";
        itemText.text = "";
        tiempoText.text = "You gain " + rewardT + " seconds!";

        


        




        for (int i = 0; i < rewardItems.Length; i++)
        {
            itemText.text += rewards[i] + "\n";
        }
        rewardScreen.SetActive(true);
    }

    public void CloseRewardScreen()
    {
        SpawnMobs.combateActivo = false;
        

        for (int i = 0; i < GameManager.instance.playerStats.Length; i++)
        {
            if(GameManager.instance.playerStats[i].gameObject.activeInHierarchy)
            {
                GameManager.instance.playerStats[i].AddExp(xpEarned);
                

            }
        }

        for(int i = 0 ; i < rewardItems.Length; i++)
        {
            GameManager.instance.AddItem(rewardItems[i]);
        }

        rewardScreen.SetActive(false);
        GameManager.instance.battleActive = false;

        if(markQuestComplete)
        {
            QuestManager.instance.MarkQuestComplete(questToMark);
        }

       
    }
}
