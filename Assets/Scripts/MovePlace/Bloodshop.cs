using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloodshop : MovePlace
{
    public bool isBloodshop;
    public bool isDreaming;

    [SerializeField] AudioSource bloodSource;
    public override void Move()
    {
        base.Move();
        isBloodshop = true;
        SystemManager.Instance.House.isHouse = false;
    }
    public override void GoOut()
    {
        base.GoOut();
    }

    public void BloodCheck()
    {
        bloodSource.Play();
        if (player.Blood >= 500 && player.HP >= 3)
        {
            SystemManager.Instance.DialogueShow.StartDialogue("GoodBlood");
            player.Blood -= 500;
            player.Money += 5000;
            player.HP -= 2;
        }
        else
        {
            SystemManager.Instance.DialogueShow.StartDialogue("BadBlood");
        }
        isBloodshop = false;
        isDreaming = true;
    }

}
