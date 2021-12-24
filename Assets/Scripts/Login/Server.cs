using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;
using UnityEngine.Networking;

public class Server : MonoBehaviour
{
    string url = "http://10.120.74.59:3000/";

    [SerializeField] InputField idInput;
    [SerializeField] InputField pwInput;

    [SerializeField] GameObject logInImg;
    [SerializeField] GameObject successImg;
    [SerializeField] Text successText;
    

    private string id;
    private string pw;

    void Start()
    {
    }

    public void Login()
    {
        url += "login";
        Input(idInput.text,pwInput.text);
        StartCoroutine(WebRequest(id,pw));

    }

    public void Sign_Up()
    {
        url += "sign_up";
        Input(idInput.text, pwInput.text);
        StartCoroutine(WebRequest(id,pw));
        
    }

    public void Input(string id, string pw)
    {
        this.id = id;
        this.pw = pw;
    }
    IEnumerator WebRequest(string id, string pw)
    {
        UnityWebRequest request = new UnityWebRequest();


        WWWForm form = new WWWForm();
        form.AddField("id", id);
        form.AddField("pw", pw);

        using (request = UnityWebRequest.Post(url, form))
        {
            yield return request.SendWebRequest();

            if (request.isNetworkError)
            {
                successText.text = "실패 했습니다";
                Debug.Log(request.error);
            }
            else
            {
                successText.text = "성공했습니다";
                Debug.Log("<post>" + request.downloadHandler.text + "</post>");
            }
            successImg.SetActive(true);
        }

        endRequest();
    }

    public void OnClick()
    {
        successImg.SetActive(false);
        logInImg.SetActive(false);

    }

    public void ShowOnClick()
    {
        logInImg.SetActive(true);
    }

    void endRequest()
    {
        url = "http://10.120.74.59:3000/";
    }
 }