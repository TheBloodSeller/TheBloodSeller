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
    public Player Hero
    {
        get
        {
            return player;
        }
    }

    [SerializeField]
    DialogueManager dialogueManager;
    public DialogueManager DialogueManager
    {
        get
        {
            return dialogueManager;
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
    ChangeMat changeMat;
    public ChangeMat ChangeMat
    {
        get
        {
            return changeMat;
        }
    
    }

    [SerializeField]
    DialogueStory dialogueStory;
    public DialogueStory DialogueStory
    {
        get
        {
            return dialogueStory;
        }
    }

}
