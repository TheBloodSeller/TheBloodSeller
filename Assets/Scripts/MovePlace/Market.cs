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
        //������ ������ ���� ��ǰ �� ������
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
