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
            case "새미누리":
                Img[0].gameObject.SetActive(true);
                break;
            case "해미누리":
                Img[1].gameObject.SetActive(true);
                break;
            default:
                break;
        }
    }
}
