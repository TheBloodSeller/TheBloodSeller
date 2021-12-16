using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamDialogue : MonoBehaviour
{
    Dictionary<int, Dialogue[]> dreamDialogues;

    void Generate()
    {
        dreamDialogues.Add(1, new Dialogue[] { new Dialogue(" " ,new string[] {"새미누리가 태어난지 1160일 째",
                                                                              "새미누리와 해미누리는 남매다.",
                                                                              "그들은 홀로그램에 띄워진 글자들을 하나씩 읽었다."} ),
                                              new Dialogue("새미누리",new string[]{"가... 나... 다..." })});
    }

    void Awake()
    {
        dreamDialogues = new Dictionary<int, Dialogue[]>();
        Generate();
    }


    public void DreamStroy(int dream)
    {
        Dialogue[] dreamDialogue = dreamDialogues[dream];

        for (int i = 0; i < dreamDialogue.Length; i++)
        {
            SystemManager.Instance.DialogueManager.StartDialogue(dreamDialogue);
        }
    }

}
