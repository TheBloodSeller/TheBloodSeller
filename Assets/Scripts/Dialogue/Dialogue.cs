using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [Tooltip("��� ġ�� ĳ���� �̸�")]
    public string name;
    [Tooltip("��� ����")]
    [TextArea(3,10)]
    public string[] sentences;
    public SpriteRenderer img;
}
[System.Serializable]
public class DialogueEvent
{
    //��� ��� ����Ҳ��� 
    public Vector2 line;
    public Dialogue[] dialogues;
}