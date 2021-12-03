using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int hp = 8;         //기본 체력
    public int blood = 0;      //피를 뺸 횟수
    public int dream = 0;      //꿈을 꾼 횟수
    void Start()
    {
        SystemManager.Instance.DialogueTrigger.PlayerImpormation(hp, blood, dream);
    }

    // Update is called once per frame
    void Update()
    {
        //매 프래임 마다 플레이어의 상태를 넘겨준다
        SystemManager.Instance.DialogueTrigger.PlayerImpormation(hp, blood, dream);
    }
}
