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
            Debug.LogError("���̾˷αװ� ����");

    }

    public void TriggerDialogue(string bgMatName)
    {
        CheakDialogue(bgMatName);

        if (dialogue == null)
            Debug.LogError("���̾˷αװ� ����");
        
    }

    //��ȭ �帧 �Ǵ��ϱ�
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
