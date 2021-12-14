using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private int hp = 80;         //기본 체력
    private int blood = 4420;    //혈액량
    private int hungry = 4000;   //허기    
    private int money = 1040;    //돈
    void Start()
    {
        SystemManager.Instance.DialogueTrigger.PlayerImpormation(hp, blood,hungry,money);
    }

    // Update is called once per frame
    void Update()
    {
        //매 프래임 마다 플레이어의 상태를 넘겨준다
        SystemManager.Instance.DialogueTrigger.PlayerImpormation(hp, blood, hungry,money);
    }

    public void SetHp(int hp)
    {
        this.hp = hp;
    }
    public void SetBlood(int hp)
    {
        this.hp = hp;
    }
    public void SetHungry(int hp)
    {
        this.hp = hp;
    }
    public void SetMoney(int hp)
    {
        this.hp = hp;
    }
}
