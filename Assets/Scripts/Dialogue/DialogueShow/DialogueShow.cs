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
    

    

    int sentanceCount = 0;

    void Start()
    {
        dialogueBarAnim = dialogueBar.GetComponent<Animator>();
    }

    public void StartDialogue(string btnName)
    {
        //로드 다이알로그
        dialogue = SystemManager.Instance.XML_Parse.LoadXML(btnName);
        //다이알로그 바 애니메이션
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
            //다이알로그를 끝낸다
            EndDialogue();
            return;
        }
        
        ShowDialogue();
    }

    void EndDialogue()
    {
        dialogueBarAnim.SetBool("isOpen", false);
        sentanceCount = 0;
    }
}
