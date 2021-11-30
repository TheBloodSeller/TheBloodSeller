using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    int hp = 8;         //기본 체력
    [SerializeField]
    int blood = 0;      //피를 뺸 횟수
    [SerializeField]
    int dream = 0;      //꿈을 꾼 횟수
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //매 프래임 마다 플레이어의 상태를 넘겨준다
        SystemManager.Instance.DialogueTrigger.PlayerImpormation(hp, blood, dream);
    }
}
