using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
        //메인 버튼 없애기
        mainButton.Disapper();

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
        sentanceCount = 0;
        dialogueBarAnim.SetBool("isOpen", false);

        //피를 뽑고 잠을 자야 꿈을 꾼다
        if (SystemManager.Instance.House.isHouse && SystemManager.Instance.Bloodshop.isdreaming)
        {
            SystemManager.Instance.House.DreamCheck();
            SystemManager.Instance.Bloodshop.isdreaming = false;
            return;
        }
        else if (SystemManager.Instance.Bloodshop.isBloodshop)
        {
            SystemManager.Instance.Bloodshop.BloodCheck();
            return;
        }
        else if (SystemManager.Instance.Spaceport.isHappyEnding)
        {
            SceneManager.LoadScene("StartScene");
            return;
        }

        mainButton.StartCoroutine(mainButton.FadeIN());
        
    }

    void CheckQuater()
    {
        
    }
}
