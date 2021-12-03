using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [Tooltip("대사 치는 캐릭터 이름")]
    public string name;
    [Tooltip("대사 내용")]
    [TextArea(3, 10)]
    public string[] sentences;
    public SpriteRenderer img;

    public Dialogue(string name, string[] sentences)
    {
        this.name = name;
        this.sentences = sentences;
    }
}
[System.Serializable]
public class DialogueEvent
{
    //어디 대사 출력할껀지 
    public Vector2 line;
    public Dialogue[] dialogues;
}