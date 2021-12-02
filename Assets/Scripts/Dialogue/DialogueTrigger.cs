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

    Dictionary<string, string[]> testTxt;

    void Start()
    {
        dialogue.name = "���ڸ�";
        dialogue.sentences = new string[] {"ó��","��ӸӸӸӸظӸӸ���","�׷� �Ϳ� �̹������̤���"};
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
        CheakDialogue();
        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
    }

    //��ȭ �帧 �Ǵ��ϱ�
    void CheakDialogue()
    {

    }   
}
