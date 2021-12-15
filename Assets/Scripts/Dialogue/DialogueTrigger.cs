using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    [SerializeField]
    SpriteRenderer bgMat;

    [SerializeField]
    int hp;
    [SerializeField]
    int blood;
    [SerializeField]
    int dream;
    [SerializeField]
    int hungry;
    [SerializeField]
    int money;



    void Start()
    {
        TriggerDialogue("Start");

    }

    

   
    

    void Update()
    {
       
    }

    //매 프레임 마다 플레이어의 상태를 받는다
    public void PlayerImpormation(int hp, int blood, int hungry,int money)
    {
        this.hp = hp;
        this.blood = blood;
        this.hungry = hungry;
        this.money = money;
    }

    public void TriggerDialogue(int dream)
    {
        CheakDialogue(dream);

        if (dialogue == null)
            Debug.LogError("다이알로그가 없음");

        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
    }

    public void TriggerDialogue(string bgMatName)
    {
        CheakDialogue(bgMatName);

        if (dialogue == null)
            Debug.LogError("다이알로그가 없음");

        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
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
                SystemManager.Instance.DialogueStory.Move_House(hp,hungry,blood);
                break;

            case "Spaceport":
                SystemManager.Instance.DialogueStory.Move_Spaceport();
                break;

            case "Park":
                SystemManager.Instance.DialogueStory.Move_Park();
                
                break;

            case "Market":
                SystemManager.Instance.DialogueStory.Move_Market(money);
                break;

            case "BloodShop":
                SystemManager.Instance.DialogueStory.Move_Bloodshop(blood,hp);
                break;

            default:
                break;
        }
    }
}
