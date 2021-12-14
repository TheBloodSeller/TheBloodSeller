using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int hp = 80;         //기본 체력
    public int blood = 4420;    //혈액량
    public int hungry = 4000;   //허기    
    public int money = 1040;    //돈
    void Start()
    {
        SystemManager.Instance.DialogueTrigger.PlayerImpormation(hp, blood,hungry);
    }

    // Update is called once per frame
    void Update()
    {
        //매 프래임 마다 플레이어의 상태를 넘겨준다
        SystemManager.Instance.DialogueTrigger.PlayerImpormation(hp, blood, hungry);
    }
}
