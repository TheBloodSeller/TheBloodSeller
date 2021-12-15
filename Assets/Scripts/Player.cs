using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int hp = 80;         //�⺻ ü��
    public int HP
    {
        get => hp;
        set
        {
            hp = value;
        }
    }

    [SerializeField]
    private int blood = 4420;    //���׷�
    public int Blood
    {
        get => blood;
        set
        {
            blood = value;
        }
    }

    [SerializeField]
    private int hunger = 4000;   //���
    public int Hunger
    {
        get => hunger;
        set
        {
            hunger = value;
        }
    }

                                 
   
    [SerializeField]
    private int money = 1040;    //��
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
        //�� ������ ���� �÷��̾��� ���¸� �Ѱ��ش�
        SystemManager.Instance.DialogueTrigger.PlayerImpormation(hp, blood, hunger,money);
    }



}
