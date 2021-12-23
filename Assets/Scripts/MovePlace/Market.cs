using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : MovePlace
{
    [SerializeField]
    GameObject productsBar;

    [SerializeField] AudioSource marketSound;

    void Start()
    {
        //게임을 시작할 때는 상품 바 가리기
        productsBar.SetActive(false);
    }
    public override void Move()
    {
        base.Move();
        marketSound.Play();
        SystemManager.Instance.Bloodshop.isDreaming = false;
        productsBar.SetActive(true);
    }
    
    public override void GoOut()
    {
        productsBar.SetActive(false);
        marketSound.Stop();
    }

}
