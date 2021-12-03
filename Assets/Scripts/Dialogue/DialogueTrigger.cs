using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    [SerializeField]
    int hp;
    [SerializeField]
    int blood;
    [SerializeField]
    int dream;

    Dictionary<int, Dialogue> testTxt;


    

    void Generate()
    {
       
        testTxt.Add(1, new Dialogue ("���̴���",new string[] { "�����ƾư�","�ƾ����"}));
        testTxt.Add(2, new Dialogue("�ع̴���", new string[] { "����������"}));
    }

    void Awake()
    {
        testTxt = new Dictionary<int, Dialogue>();
    }
    void Start()
    {
        Generate();
        TriggerDialogue();

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

    public void TriggerDialogue()
    {
        Debug.Log("TriggerDialogue");
        CheakDialogue(dream);
        
        if (dialogue == null)
        {
            Debug.LogError("���̾˷αװ� ����");
        }
        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
    }

    //��ȭ �帧 �Ǵ��ϱ�
    void CheakDialogue(int dream)
    {
        int d = 1;
        Debug.Log("CheakDialogue");
        switch (d)
        {
            case 1:
                Debug.Log("�޾ƿ���");
                dialogue = testTxt[1];
                Debug.Log(dialogue.sentences[0]);
                break;
            case 2:
               
                dialogue = testTxt[2];
                break;

            default:
                break;
        }
        d++;
    }   
}
