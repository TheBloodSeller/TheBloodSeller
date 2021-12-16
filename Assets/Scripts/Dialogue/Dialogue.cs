using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct Dialogue
{
    [Tooltip("대사 치는 캐릭터 이름")]
    public string[] names;
    [Tooltip("대사 내용")]
    [TextArea(3, 10)]
    public string[] sentences;
    public Sprite[] img;

    public Dialogue(string[] names, string[] sentences, Sprite[] img)
    {
        this.names = names;
        this.sentences = sentences;
        this.img = img;
    }
}