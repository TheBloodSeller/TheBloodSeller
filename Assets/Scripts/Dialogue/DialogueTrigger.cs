using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    [SerializeField]
    SpriteRenderer bgMat;

    [SerializeField]
    int hp;
    [SerializeField]
    int blood;
    [SerializeField]
    int dream;

    Dictionary<int, Dialogue> testTxt;
    Dictionary<string, Dialogue> buttonText;

    

    void Generate()
    {
        testTxt.Add(1, new Dialogue ("새미누리",new string[] { "으으아아가","아어린ㅇㅎ"}));
        testTxt.Add(2, new Dialogue("해미누리", new string[] { "낑유유유육"}));


        buttonText.Add("공원", new Dialogue(" ", new string[] { }));
        buttonText.Add("주민센터", new Dialogue(" ", new string[] { }));
        buttonText.Add("혈액 거래소", new Dialogue(" ", new string[] { }));
        buttonText.Add("항구", new Dialogue(" ", new string[] { }));
        buttonText.Add("집", new Dialogue(" ", new string[] { }));
        buttonText.Add("상점", new Dialogue(" ", new string[] { }));


    }

    void Awake()
    {
        testTxt = new Dictionary<int, Dialogue>();
        buttonText = new Dictionary<string, Dialogue>();
    }
    void Start()
    {
        Generate();
        TriggerDialogue();

    }

    void Update()
    {
       
    }

    //매 프레임 마다 플레이어의 상태를 받는다
    public void PlayerImpormation(int hp, int blood, int dream)
    {
        this.hp = hp;
        this.blood = blood;
        this.dream = dream;
    }

    public void TriggerDialogue()
    {
        CheakDialogue(dream);

        if (dialogue == null)
            Debug.LogError("다이알로그가 없음");

        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
    }

    public void TriggerDialogue(string bgMatName)
    {
        CheakDialogue(bgMatName);

        if (dialogue == null)
            Debug.LogError("다이알로그가 없음");

        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
    }

    //대화 흐름 판단하기
    void CheakDialogue(int dream)
    {
        switch (dream)
        {
            case 1:
                dialogue = testTxt[1];
                break;
            case 2:
               
                dialogue = testTxt[2];
                break;

            default:
                break;
        }
        SystemManager.Instance.Hero.dream++;
    }   

    void CheakDialogue(string bgMatName)
    {
        switch (bgMatName)
        {
            case "House":
                dialogue = buttonText["집"];
                break;

            case "Spaceport":
                dialogue = buttonText["집"];
                break;

            case "Community":
                dialogue = buttonText["집"];
                break;

            case "Park":
                dialogue = buttonText["집"];
                break;

            case "Market":
                dialogue = buttonText["집"];
                break;

            case "BloodShop":
                dialogue = buttonText["집"];
                break;

            default:
                break;
        }
    }
}
