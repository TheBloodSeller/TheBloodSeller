using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int hp = 8;         //�⺻ ü��
    public int blood = 0;      //�Ǹ� �A Ƚ��
    public int dream = 0;      //���� �� Ƚ��
    void Start()
    {
        SystemManager.Instance.DialogueTrigger.PlayerImpormation(hp, blood, dream);
    }

    // Update is called once per frame
    void Update()
    {
        //�� ������ ���� �÷��̾��� ���¸� �Ѱ��ش�
        SystemManager.Instance.DialogueTrigger.PlayerImpormation(hp, blood, dream);
    }
}
