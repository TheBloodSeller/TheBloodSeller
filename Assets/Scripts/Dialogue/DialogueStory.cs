using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStory : MonoBehaviour
{
    Dialogue dialogue => SystemManager.Instance.DialogueTrigger.dialogue;

    Dictionary<int, Dialogue> dreamText;
    Dictionary<string, Dialogue> buttonText;

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
        buttonText.Add("혈액 관리소", new Dialogue(" ", new string[] {"새미누리는 간호기계에 안내에 따라 채혈실에 도착했다" ,
                                                                     "홀로그램으로 확인서가 띄워지자, 새미누리는 팔을 들어 올렸다.",
                                                                     "혈액 채취기가 새미누리의 왼 팔을 잡고 움직였다."}));
        buttonText.Add("항구", new Dialogue(" ", new string[] { "" }));
        buttonText.Add("집", new Dialogue(" ", new string[] { }));
        buttonText.Add("상점", new Dialogue(" ", new string[] { }));


    }
    void Start()
    {
        Generate();
    }

    void Awake()
    {
        dreamText = new Dictionary<int, Dialogue>();
        buttonText = new Dictionary<string, Dialogue>();
    }

    public void Move_Start()
    {
        SystemManager.Instance.DialogueTrigger.dialogue = buttonText["시작"];
    }

    public void Move_Park()
    {
        SystemManager.Instance.DialogueTrigger.dialogue = buttonText["공원"];
    }
}
