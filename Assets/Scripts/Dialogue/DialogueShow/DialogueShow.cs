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

    [SerializeField] AudioSource textSound;

    [SerializeField] GameObject nextBtn;

    Player player => SystemManager.Instance.Player;

    public bool isEnding = false;    

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
        textSound.Play();
        nextBtn.SetActive(false);
        nameText.text = dialogue.names[sentanceCount];
        StartCoroutine(TypeSentance(dialogue.sentences[sentanceCount]));
        characterSprite.sprite = dialogue.img[sentanceCount];
    }

    IEnumerator TypeSentance(string sentance)
    {
        sentanceText.text = "";
        foreach (char letter in sentance.ToCharArray())
        {
            sentanceText.text += letter.ToString();
            yield return new WaitForSeconds(0.05f);
        }
        nextBtn.SetActive(true);
    }
 
    public void NextSentance()
    {

        StopAllCoroutines();

        sentanceText.text = "";
        nameText.text = "";

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
        textSound.Stop();

        if (isEnding)
        {
            SceneManager.LoadScene("StartScene");
            return;
        }

        if (player.HP <= 0 || player.Blood <= 0 || player.Hunger <= 0)
        {
            CheckEnding();
            return;
        }       

        #region Quater


        if (SystemManager.Instance.House.isHouse && SystemManager.Instance.Bloodshop.isDreaming)
        {
            SystemManager.Instance.House.DreamCheck();
            SystemManager.Instance.Bloodshop.isDreaming = false;
            return;
        }
        else if (SystemManager.Instance.Bloodshop.isBloodshop)
        {
            SystemManager.Instance.Bloodshop.BloodCheck();
            return;
        }
        #endregion

        mainButton.StartCoroutine(mainButton.FadeIN());
        
    }

    public void CheckEnding()
    {

        bool[] endingQuater = new bool[] { player.HP <= 0, player.Blood <= 0, player.Hunger <= 0 };
        for (int i = 0; i < endingQuater.Length; i++)
        {
            if (endingQuater[i])
            {
                EndingQuater(i);
                return;
            }
        }
    }

    public void EndingQuater(int num)
    {
        isEnding = true;
        string endingName = "DeadEnding";
        switch (num)
        {
            case 0:
                endingName += "_HP";
                break;
            case 1:
                endingName += "_Blood";
                break;
            case 2:
                endingName += "_Hunger";
                break;
            default:
                break;
        }
        SystemManager.Instance.Ending.EndingDialogue(endingName);
    }

}
