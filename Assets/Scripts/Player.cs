using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private int hp = 80;         //�⺻ ü��
    private int blood = 4420;    //���׷�
    private int hungry = 4000;   //���    
    private int money = 1040;    //��
    void Start()
    {
        SystemManager.Instance.DialogueTrigger.PlayerImpormation(hp, blood,hungry,money);
    }

    // Update is called once per frame
    void Update()
    {
        //�� ������ ���� �÷��̾��� ���¸� �Ѱ��ش�
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
