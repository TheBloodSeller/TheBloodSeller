using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueImg : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer[] Img;


    public void CheakImg(string name)
    {
        switch (name)
        {
            case "���̴���":
                Img[0].gameObject.SetActive(true);
                break;
            case "�ع̴���":
                Img[1].gameObject.SetActive(true);
                break;
            default:
                break;
        }
    }
}
