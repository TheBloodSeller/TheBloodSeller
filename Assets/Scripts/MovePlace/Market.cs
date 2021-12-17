using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : MovePlace
{
    [SerializeField]
    GameObject productsBar;
    void Start()
    {
        //������ ������ ���� ��ǰ �� ������
        productsBar.SetActive(false);
    }
    public override void Move()
    {
        base.Move();
        productsBar.SetActive(true);
    }
    
    public override void GoOut()
    {
        productsBar.SetActive(false);
    }

}
