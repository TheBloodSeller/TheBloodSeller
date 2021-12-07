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

    void Start()
    {
        Generate();
        TriggerDialogue("Start");

    }

    void Generate()
    {
        testTxt.Add(1, new Dialogue ("새미누리",new string[] { "으으아아가","아어린ㅇㅎ"}));
        testTxt.Add(2, new Dialogue("해미누리", new string[] { "낑유유유육"}));

        buttonText.Add("시작", new Dialogue(" ", new string[] { "2270년 어느날",
                                                              "태어난지 정확히 10000일 되는 새미누리는 오늘도 기운 없이 일어났다", 
                                                              "그녀는 세레스 행성에 갇혀있다",
                                                              "그녀는 이 행성을 떠나기 위해 돈을 벌려 한다",
                                                              "그녀는 혈액 관리소에 가서 매혈을 할 것 이다"
                                                               }));
                                                                
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

    public void TriggerDialogue(int dream)
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
            case "Start":
                dialogue = buttonText["시작"];
                break;

            case "House":
                dialogue = buttonText["집"];
                break;

            case "Spaceport":
                dialogue = buttonText["항구"];
                break;

            case "Community":
                dialogue = buttonText["주민센터"];
                break;

            case "Park":
                dialogue = buttonText["공원"];
                break;

            case "Market":
                dialogue = buttonText["상점"];
                break;

            case "BloodShop":
                dialogue = buttonText["혈액거래소"];
                break;

            default:
                break;
        }
    }
}
