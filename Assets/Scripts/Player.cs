using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField]
    private int hp = 80;         //±âº» Ã¼·Â
    public int HP
    {
        get => hp;
        set
        {
            hp = value;
        }
    }

    [SerializeField]
    private int blood = 4420;    //Ç÷¾×·®
    public int Blood
    {
        get => blood;
        set
        {
            blood = value;
        }
    }

    [SerializeField]
    private int hunger = 4000;   //Çã±â
    public int Hunger
    {
        get => hunger;
        set
        {
            hunger = value;
        }
    }

    [SerializeField]
    private int dream = 0;
    public int Dream
    {
        get => dream;
        set
        {
            dream = value;
        }
    }
                                 
   
    [SerializeField]
    private int money = 1040;    //µ·
    public int Money {
        get => money; 
        set 
        { 
            money = value; 
        }
    }



}
