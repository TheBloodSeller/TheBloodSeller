using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    [SerializeField] Text nameText; 
    [SerializeField] Text dialogueText;
    [SerializeField] GameObject[] images;
    [SerializeField] GameObject DialogueBar;
    [SerializeField] GameObject MoveBtns;
    [SerializeField] GameObject MainBtn;
    [SerializeField] GameObject productsBar;

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
            anim.SetBool("isOpen", false);
            MainBtn.SetActive(true);
            return;
        }

        string sentance = sentences.Dequeue();
        dialogueText.text = sentance;

    }

    public void EndDialogue()
    {
        

        if (go)
        {
            go.SetActive(false);
        }

        if (productsBar.activeSelf)
            productsBar.SetActive(false);
        
        Debug.Log("End of conversion");
        SystemManager.Instance.ChangeMat.MainScene();
        MainBtn.SetActive(false);
        MoveBtns.SetActive(true);
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
