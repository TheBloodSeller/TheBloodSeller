using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloodshop : MovePlace
{
    public bool isBloodshop;
    public bool isDreaming;

    [SerializeField] AudioSource moveBloodSound;
    public override void Move()
    {
        base.Move();
        moveBloodSound.Play();
        isBloodshop = true;
        SystemManager.Instance.House.isHouse = false;
    }
    public override void GoOut()
    {
        base.GoOut();
        moveBloodSound.Stop();
    }

    public void BloodCheck()
    {
        if (player.Blood >= 500 && player.HP >= 3)
        {
            player.Blood -= 500;
            player.Money += 5000;
            player.HP -= 2;
            SystemManager.Instance.DialogueShow.StartDialogue("GoodBlood");
            
        }
        else
        {
            SystemManager.Instance.DialogueShow.StartDialogue("BadBlood");
        }
        isBloodshop = false;
        isDreaming = true;
    }

}
