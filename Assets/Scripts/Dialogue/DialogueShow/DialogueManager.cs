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
    [SerializeField]
    GameObject[] images;
    [SerializeField]
    GameObject DialogueBar;
    [SerializeField]
    GameObject MoveBtn;

    GameObject go;

    public Animator anim;

    void Awake()
    {
        sentences = new Queue<string>();
    }
    void Start()
    {
        DialogueBar.SetActive(true);
        anim.SetBool("isOpen", true);


        for (int i = 0; i < images.Length; i++)
        {
            images[i].SetActive(false);
        }

    }
    public void StartDialogue(Dialogue dialogue)
    {
        anim.SetBool("isOpen", true);


        //화자의 이미지 불러오기
        go = CheckImage(dialogue.name);
        if (!go)
            ;
        else
            go.SetActive(true);
        
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach (string sentance in dialogue.sentences)
        {
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
        if (go)
        {
            go.SetActive(false);
        }
        
        Debug.Log("End of conversion");
        MoveBtn.SetActive(true);
    }

    GameObject CheckImage(string name)
    {
        switch (name)
        {
            case "새미누리":
                return images[0];
            case "해미누리":
                return images[1];
            default:
                return null;
        }
    }
}
