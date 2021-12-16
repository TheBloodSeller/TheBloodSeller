using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialogueStory : MonoBehaviour
{
    [SerializeField]
    GameObject productsBar;

    Dialogue dialogue;

    Dictionary<int, Dialogue> dreamText;
    Dictionary<string, Dialogue> buttonText;

    [SerializeField]
    Player player => SystemManager.Instance.Player;

    void Generate()
    {

        buttonText.Add("시작", new Dialogue("", new string[] { "2270년 어느날",
                                                              "태어난지 정확히 10000일 되는 새미누리는 오늘도 기운 없이 일어났다.",
                                                              "그녀는 세레스 행성에 갇혀있다.",
                                                              "그녀는 이 행성을 떠나기 위해 돈을 벌려 한다.",
                                                              "그녀는 혈액 관리소에 가서 매혈을 할 것 이다."
                                                               }));

        buttonText.Add("공원", new Dialogue(" ", new string[] { "광장에 많은 사람들이 있다",
                                                                "가운데 분수를 중심에 노점상이 있다.",
                                                                "복권을 파는 것 같은데... 한번 사 볼까?"}));

        buttonText.Add("혈액관리소", new Dialogue(" ", new string[] { "새미누리는 간호기계에 안내에 따라 채혈실에 도착했다" ,
                                                                     "홀로그램으로 확인서가 띄워지자, 새미누리는 팔을 들어 올렸다.",
                                                                     "혈액 채취기가 새미누리의 왼 팔을 잡고 움직였다."}));

        buttonText.Add("혈액채취불가능", new Dialogue(" ", new string[] { "혈액채취기가 새미누리를 스캔하니, 모니터에 붉은색 창이 떴다.",
                                                                         "결국 새미누리는 빈손으로 나갈 수 밖에 없었다." }));

        buttonText.Add("혈액채취가능", new Dialogue(" ", new string[] { "혈액채취기가 새미누리를 스캔하니, 모니터에 초록색 창이 떴다.",
                                                                       "새미누리는 피를 500ml 뺐다.",
                                                                       "새미누리의 통장에 5000크레딧이 들어왔다"}));

        buttonText.Add("항구", new Dialogue(" ", new string[] {"새미누리는 승강기를 탔다.", 
                                                               "몸이 점점 가벼워졌다.",
                                                               "탑승구로 갈 수록 수직항력이 사라졌다.",
                                                               "새미누리는 난간을 잡으며 매표소 앞에 섰다."}));
                                                                    
        buttonText.Add("집", new Dialogue(" ", new string[] {"새미누리는 지친몸을 이끌고 정리를 한 뒤 침대에 누웠다.",
                                                             "창문 밖의 별자리를 보면서 스르르 잠이 든다.",
                                                             "잠을 자고 일어나니 몸이 가뿐하다"}));

        buttonText.Add("상점", new Dialogue(" ", new string[] {"새미누리는 생필품을 사러 상점으로 갔다."}));


        //꿈이야기
        


    }

    void Awake()
    {
        dreamText = new Dictionary<int, Dialogue>();
        buttonText = new Dictionary<string, Dialogue>();
        Generate();

    }
    void Start()
    {
        productsBar.SetActive(false);
    }


    public void Move_Start()
    {
        dialogue = buttonText["시작"];
        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
    }

    public void Move_Park()
    {
        dialogue = buttonText["공원"];
        //도박
        int a, b, c;
        a = Random.Range(1, 10);
        b = Random.Range(1, 10);
        c = Random.Range(1, 10);
        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
    }

    public void Move_Bloodshop(int blood,int HP)
    {
        dialogue = buttonText["혈액관리소"];
        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
        if (blood < 3600 || HP <= 3)
        {
            dialogue = new Dialogue("", new string[] { "새미누리는 몸이 안 좋아서 피를 뽑을 수 없다"});
            SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
            return;
        }
        
    }

    public void Move_Spaceport()
    {
        dialogue = buttonText["항구"];
        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
    }

    public void Move_House(int hp, int hungry,int blood,int dream)
    {
        
        player.HP = hungry >= 5 ? hp + 3 : hp + 1;
        player.Blood = hungry >= 5 ? blood + 3: blood + 1;
        dialogue = buttonText["집"];
        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);

        //꿈을 시작
        SystemManager.Instance.DreamDialogue.DreamStroy(1);

    }

    public void Move_Market()
    {
        dialogue = buttonText["상점"];
        SystemManager.Instance.DialogueManager.StartDialogue(dialogue);
        productsBar.SetActive(true);
    }
}
