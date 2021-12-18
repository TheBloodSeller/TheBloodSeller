using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueShow : MonoBehaviour
{
    Dialogue dialogue;

    [SerializeField] GameObject dialogueBar;
    Animator dialogueBarAnim;

    [SerializeField] Text nameText;
    [SerializeField] Text sentanceText;
    [SerializeField] SpriteRenderer characterSprite;
    [SerializeField] MainBtn mainButton => SystemManager.Instance.MainBtn;
    

    

    int sentanceCount = 0;
    public int SentanceCount
    {
        get
        {
            return sentanceCount;
        }
        set
        {
            sentanceCount = value;
        }
    }

    void Awake()
    {
       dialogueBarAnim = dialogueBar.GetComponent<Animator>();
    }

    public void StartDialogue(string btnName)
    {
        //���� ��ư ���ֱ�
        mainButton.Disapper();

        //�ε� ���̾˷α�
        dialogue = SystemManager.Instance.XML_Parse.LoadXML(btnName);
        //���̾˷α� �� �ִϸ��̼�
        dialogueBarAnim.SetBool("isOpen",true);

        ShowDialogue();

    }
    
    void ShowDialogue()
    {

        nameText.text = dialogue.names[sentanceCount];
        sentanceText.text = dialogue.sentences[sentanceCount];
        characterSprite.sprite = dialogue.img[sentanceCount];

        
    }
 
    public void NextSentance()
    {
        sentanceCount++;

        if (sentanceCount == dialogue.names.Length)
        {
            //���̾˷α׸� ������
            EndDialogue();
            return;
        }
        
        ShowDialogue();
    }

    void EndDialogue()
    {
        sentanceCount = 0;
        dialogueBarAnim.SetBool("isOpen", false);
        mainButton.StartCoroutine(mainButton.FadeIN());
        
    }
}
