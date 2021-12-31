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

        //���� �ε��� ������ �ڵ����� �ҷ��� ������ �̵��� �������� �����ϴ� ��
        //1. ���ε��� �ʹ� ������� => ����ũ�ε�
        //2. ���¹��� = ���ҽ� �ε��� ������ ���� ������ ����
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
