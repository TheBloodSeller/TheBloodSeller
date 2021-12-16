using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    [SerializeField]
    SpriteRenderer bgMat;

    [SerializeField]
    Player player => SystemManager.Instance.Player;



    void Start()
    {
        TriggerDialogue("Start");

    }
    public void TriggerDialogue(int dream)
    {
        CheakDialogue(dream);

        if (dialogue == null)
            Debug.LogError("다이알로그가 없음");

    }

    public void TriggerDialogue(string bgMatName)
    {
        CheakDialogue(bgMatName);

        if (dialogue == null)
            Debug.LogError("다이알로그가 없음");
        
    }

    //대화 흐름 판단하기
    void CheakDialogue(int dream)
    {
        switch (dream)
        {
            case 1:
                
                break;
            case 2:
               
                break;

            default:
                break;
        }
        dream++;
    }   

    void CheakDialogue(string bgMatName)
    {
        switch (bgMatName)
        {
            case "Start":
                SystemManager.Instance.DialogueStory.Move_Start();
                break;

            case "House":
                SystemManager.Instance.DialogueStory.Move_House(HP,hunger,blood);
                break;

            case "Spaceport":
                SystemManager.Instance.DialogueStory.Move_Spaceport();
                break;

            case "Park":
                SystemManager.Instance.DialogueStory.Move_Park();
                
                break;

            case "Market":
                SystemManager.Instance.DialogueStory.Move_Market(money,hunger);
                break;

            case "BloodShop":
                SystemManager.Instance.DialogueStory.Move_Bloodshop(blood,HP);
                break;

            default:
                break;
        }
    }
}
