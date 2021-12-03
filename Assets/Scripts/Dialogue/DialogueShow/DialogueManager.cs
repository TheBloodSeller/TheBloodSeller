using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    [SerializeField]
    Text nameText;
    [SerializeField]
    Text dialogueText;

    public Animator anim;
    void Start()
    {
        sentences = new Queue<string>();

    }
    public void StartDialogue(Dialogue dialogue)
    {
        anim.SetBool("isOpen",true);
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentance in dialogue.sentences)
        {
            Debug.Log("³Ä¿Ë");
            sentences.Enqueue(sentance);
        }

        DisplayNextSentence();
        
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentance = sentences.Dequeue();
        dialogueText.text = sentance;

    }

    void EndDialogue()
    {
        anim.SetBool("isOpen", false);
        Debug.Log("End of conversion");
        SystemManager.Instance.ChangeMat.ShowBtnCollection();
    }
}
