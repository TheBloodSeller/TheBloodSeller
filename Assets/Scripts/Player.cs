using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int hp = 80;         //�⺻ ü��
    public int blood = 4420;    //���׷�
    public int hungry = 4000;   //���    
    public int money = 1040;    //��
    void Start()
    {
        SystemManager.Instance.DialogueTrigger.PlayerImpormation(hp, blood,hungry);
    }

    // Update is called once per frame
    void Update()
    {
        //�� ������ ���� �÷��̾��� ���¸� �Ѱ��ش�
        SystemManager.Instance.DialogueTrigger.PlayerImpormation(hp, blood, hungry);
    }
}
