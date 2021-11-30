using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    void Start()
    {
        dialogue.name = "감자몽";
        dialogue.sentences = new string[] {"처음","어머머머머멈머머마마","그럼 와우 이미제어이ㅏㄹ"};
        TriggerDialogue();

    }

    public void TriggerDialogue()
    {
        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
    }
}
