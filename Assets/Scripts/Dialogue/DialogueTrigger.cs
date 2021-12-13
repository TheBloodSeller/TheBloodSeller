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

    

    void Start()
    {
        TriggerDialogue("Start");

    }

    

   
    

    void Update()
    {
       
    }

    //매 프레임 마다 플레이어의 상태를 받는다
    public void PlayerImpormation(int hp, int blood, int dream)
    {
        this.hp = hp;
        this.blood = blood;
        this.dream = dream;
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
        SystemManager.Instance.Hero.dream++;
    }   

    void CheakDialogue(string bgMatName)
    {
        switch (bgMatName)
        {
            case "Start":
                SystemManager.Instance.DialogueStory.Move_Start();
                break;

            case "House":
                
                break;

            case "Spaceport":
                
                break;

            case "Park":
                SystemManager.Instance.DialogueStory.Move_Park();
                
                break;

            case "Market":
               
                break;

            case "BloodShop":
                
                break;

            default:
                break;
        }
    }
}
