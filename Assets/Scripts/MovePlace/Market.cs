using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : MovePlace
{
    [SerializeField]
    GameObject productsBar;
    void Start()
    {
        //게임을 시작할 때는 상품 바 가리기
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
