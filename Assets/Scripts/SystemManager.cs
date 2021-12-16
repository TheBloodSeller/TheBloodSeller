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
    ChangeMat changeMat;
    public ChangeMat ChangeMat
    {
        get
        {
            return changeMat;
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

}
