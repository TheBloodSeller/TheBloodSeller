using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingSceneController : MonoBehaviour
{
    static string nextScene;

    [SerializeField]
    Image loadingBarImg;

    public static void LoadScene(string sceneName)
    {
        nextScene = sceneName;
        SceneManager.LoadScene("LoadingScene");
    }


    void Start()
    {
        StartCoroutine("LoadSceneProcess");
    }

    IEnumerator LoadSceneProcess()
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(nextScene);

        //씬의 로딩이 끝나면 자동으로 불러온 씬으로 이동할 것인지를 설정하는 것
        //1. 씬로딩이 너무 빠를까봐 => 페이크로딩
        //2. 에셋번들 = 리소스 로딩을 씬보다 먼저 끝내기 위해
        op.allowSceneActivation = false;

        float timer = 0f;
        while (!op.isDone)
        {
            yield return null;

            if (op.progress < 0.1f)
            {
                loadingBarImg.fillAmount = op.progress;
            }
            else
            {
                timer += Time.unscaledDeltaTime;
                loadingBarImg.fillAmount = Mathf.Lerp(0.1f, 1f, timer);
                if (loadingBarImg.fillAmount >= 1f)
                {
                    op.allowSceneActivation = true;
                    yield break;
                }
            }
        }
    }
}
