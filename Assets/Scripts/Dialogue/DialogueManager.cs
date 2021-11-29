using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue{

    public string name;
    [TextArea(3,10)]
    public string[] sentances;

}

public class DialogueManager: MonoBehaviour
{
    private Queue<string> sentances;

    void Start()
    {
        sentances = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);
        sentances.Clear();

        foreach(string sentances in dialogue.sentances)
        {
            this.sentances.Enqueue(sentances);
        }

        DisplayNextSentenxe();
    }

    public void DisplayNextSentenxe()
    {
        if (sentances.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentances.Dequeue();
        Debug.Log(sentence);
    }

    void EndDialogue()
    {
        Debug.Log("End of conversion!");
    }
}
