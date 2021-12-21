using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlace : MonoBehaviour
{
    public Player player => SystemManager.Instance.Player;

    public virtual void Move()
    {
        SystemManager.Instance.DialogueShow.SentanceCount = 0;
    }

    public virtual void GoOut()
    {

    }
}
