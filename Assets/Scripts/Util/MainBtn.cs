using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainBtn : MonoBehaviour
{
    Image image;
    TMP_Text text;
    void Awake()
    {
        image = GetComponent<Image>();
        text = GetComponentInChildren<TMP_Text>();
    }

    public void Disapper()
    {
        Color color = new Vector4(1, 1, 1, 0);
        image.color = color;
        text.color = color;
    }

    public IEnumerator FadeOut()
    {
        for (float i = 1.0f; i >= 0; i -= 0.1f)
        {
            Color color = new Vector4(1,1,1,i);
            image.color = color;
            text.color = color;
            yield return new WaitForSeconds(0.1f);

        }
    }

    public IEnumerator FadeIN()
    {
        Debug.Log("코루틴 실행");
        for (float i = 0f; i <= 1; i += 0.1f)
        {
            Color color = new Vector4(1, 1, 1, i);
            image.color = color;
            text.color = color;
            yield return new WaitForSeconds(0.1f);

        }
    }

    public void OnClick() {
        
        StartCoroutine("FadeOut");
        SystemManager.Instance.DialogueTrigger.MainScene();
    }

    
}
