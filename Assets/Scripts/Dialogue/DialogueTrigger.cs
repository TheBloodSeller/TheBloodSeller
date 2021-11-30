using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    void Start()
    {
        dialogue.name = "���ڸ�";
        dialogue.sentences = new string[] {"ó��","��ӸӸӸӸظӸӸ���","�׷� �Ϳ� �̹������̤���"};
        TriggerDialogue();

    }

    public void TriggerDialogue()
    {
        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
    }
}
