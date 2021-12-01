using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMat : MonoBehaviour
{
    //0:Space
    //1.House
    [SerializeField]
    Material[] backMat;
    [SerializeField]
    MeshRenderer background;

    void Start()
    {
        ChangeBackground(0);
    }

    public void ChangeBackground(int back)
    {
        background.material = backMat[back];
    }
    
}
