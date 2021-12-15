using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int hp = 80;         //기본 체력
    public int HP
    {
        get => hp;
        set
        {
            hp = value;
        }
    }

    [SerializeField]
    private int blood = 4420;    //혈액량
    public int Blood
    {
        get => blood;
        set
        {
            blood = value;
        }
    }

    [SerializeField]
    private int hunger = 4000;   //허기
    public int Hunger
    {
        get => hunger;
        set
        {
            hunger = value;
        }
    }

                                 
   
    [SerializeField]
    private int money = 1040;    //돈
    public int Money {
        get => money; 
        set 
        { 
            money = value; 
        }
    }


    void Start()
    {
        
        SystemManager.Instance.DialogueTrigger.PlayerImpormation(hp, blood, hunger ,money);
    }

    // Update is called once per frame
    void Update()
    {
        //매 프래임 마다 플레이어의 상태를 넘겨준다
        SystemManager.Instance.DialogueTrigger.PlayerImpormation(hp, blood, hunger,money);
    }



}
