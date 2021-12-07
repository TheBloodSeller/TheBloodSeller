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

    Dictionary<int, Dialogue> dreamText;
    Dictionary<string, Dialogue> buttonText;

    void Start()
    {
        Generate();
        TriggerDialogue("Start");

    }

    void Generate()
    {

        buttonText.Add("����", new Dialogue("���̴���", new string[] { "2270�� �����",
                                                              "�¾�� ��Ȯ�� 10000�� �Ǵ� ���̴����� ���õ� ��� ���� �Ͼ��.", 
                                                              "�׳�� ������ �༺�� �����ִ�.",
                                                              "�׳�� �� �༺�� ������ ���� ���� ���� �Ѵ�.",
                                                              "�׳�� ���� �����ҿ� ���� ������ �� �� �̴�."
                                                               }));
                                                                
        buttonText.Add("����", new Dialogue(" ", new string[] { }));
        buttonText.Add("�ֹμ���", new Dialogue(" ", new string[] {"���忡 ���� ������� �ִ�", 
                                                                   "��� �м��� �߽ɿ� �������� �ִ�.",
                                                                   "������ �Ĵ� �� ������... �ѹ� �� ����?"}));
        buttonText.Add("����ä�밡��", new Dialogue(" ", new string[] { }));
        buttonText.Add("����ä��Ұ���", new Dialogue(" ", new string[] { }));
        buttonText.Add("�ױ�", new Dialogue(" ", new string[] { ""}));
        buttonText.Add("��", new Dialogue(" ", new string[] { }));
        buttonText.Add("����", new Dialogue(" ", new string[] { }));


    }

    void Awake()
    {
        dreamText = new Dictionary<int, Dialogue>();
        buttonText = new Dictionary<string, Dialogue>();
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
                dialogue = dreamText[1];
                break;
            case 2:
               
                dialogue = dreamText[2];
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
                dialogue = buttonText["����"];
                break;

            case "House":
                dialogue = buttonText["��"];
                break;

            case "Spaceport":
                dialogue = buttonText["�ױ�"];
                break;

            case "Community":
                dialogue = buttonText["�ֹμ���"];
                break;

            case "Park":
                dialogue = buttonText["����"];
                break;

            case "Market":
                dialogue = buttonText["����"];
                break;

            case "BloodShop":
                dialogue = buttonText["���װŷ���"];
                break;

            default:
                break;
        }
    }
}
