using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;
using UnityEngine.Networking;

[System.Serializable]
public class User
{
    public string id;
    public string pw;
    
}


public class Test : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(WebRequest());
    }
    string url = "http://10.120.74.59:3000/sign_up";
    IEnumerator WebRequest()
    {
        UnityWebRequest request = new UnityWebRequest();


        WWWForm form = new WWWForm();
        form.AddField("id", "Kim");
        form.AddField("pw", "qqq");

        using (request = UnityWebRequest.Post(url, form))
        {
            yield return request.SendWebRequest();

            if (request.isNetworkError)
            {
                Debug.Log(request.error);
            }
            else
            {
                Debug.Log("<post>" + request.downloadHandler.text + "</post>");
            }
        }
    }
 }