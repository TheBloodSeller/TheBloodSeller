using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    static SystemManager instance = null;

    public static SystemManager Instance
    {
        get
        {
            return instance;
        }
    }

    
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("SystemManager Error! Singleton error");
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    [SerializeField]
    Player player;
    public Player Player
    {
        get
        {
            return player;
        }
    }

    [SerializeField]
    DialogueTrigger dialogueTrigger;
    public DialogueTrigger DialogueTrigger 
    {
        get
        {
            return dialogueTrigger;
        }
    
    }

    [SerializeField]
    XML_Parse xml_Parse;
    public XML_Parse XML_Parse
    {
        get
        {
            return xml_Parse;
        }
    }

    [SerializeField]
    DialogueShow dialogueShow;
    public DialogueShow DialogueShow
    {
        get
        {
            return dialogueShow;
        }
    }

    [SerializeField]
    MainBtn mainBtn;
    public MainBtn MainBtn
    {
        get
        {
            return mainBtn;
        }
    }

    [SerializeField]
    Market market;
    public Market Market
    {
        get
        {
            return market;
        }
    }

    [SerializeField]
    Park park;
    public Park Park
    {
        get
        {
            return park;
        }
    }

    [SerializeField]
    Spaceport spaceport;
    public Spaceport Spaceport
    {
        get
        {
            return spaceport;
        }
    }
}
