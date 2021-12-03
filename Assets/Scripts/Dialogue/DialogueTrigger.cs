using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    [SerializeField]
    int hp;
    [SerializeField]
    int blood;
    [SerializeField]
    int dream;

    Dictionary<int, Dialogue> testTxt;


    

    void Generate()
    {
       
        testTxt.Add(1, new Dialogue ("새미누리",new string[] { "으으아아가","아어린ㅇㅎ"}));
        testTxt.Add(2, new Dialogue("해미누리", new string[] { "낑유유유육"}));
    }

    void Awake()
    {
        testTxt = new Dictionary<int, Dialogue>();
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
        {
            Debug.LogError("다이알로그가 없음");
        }
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
}
