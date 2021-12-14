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

    //�� ������ ���� �÷��̾��� ���¸� �޴´�
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
            Debug.LogError("���̾˷αװ� ����");

        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
    }

    public void TriggerDialogue(string bgMatName)
    {
        CheakDialogue(bgMatName);

        if (dialogue == null)
            Debug.LogError("���̾˷αװ� ����");

        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
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
                SystemManager.Instance.DialogueStory.Move_House();
                break;

            case "Spaceport":
                SystemManager.Instance.DialogueStory.Move_Spaceport();
                break;

            case "Park":
                SystemManager.Instance.DialogueStory.Move_Park();
                
                break;

            case "Market":
                SystemManager.Instance.DialogueStory.Move_Market();
                break;

            case "BloodShop":
                SystemManager.Instance.DialogueStory.Move_Bloodshop();
                break;

            default:
                break;
        }
    }
}
