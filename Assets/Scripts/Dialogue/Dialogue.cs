using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueText
{
    [TextArea]
    public string text;
}

public class Dialogue : MonoBehaviour
{
    [SerializeField] private SpriteRenderer standingImg;
    [SerializeField] private GameObject dialogueImg;
    [SerializeField] private Text dialogue;

    private bool isDialogue = false;
    private int count = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
