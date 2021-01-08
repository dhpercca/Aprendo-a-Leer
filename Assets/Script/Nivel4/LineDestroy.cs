using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDestroy : MonoBehaviour
{
    private GameObject LinesToDestroy;
    
    void Update()
    {
        LinesToDestroy = GameObject.FindWithTag("LineClone");
        Object.Destroy (LinesToDestroy);
    }        
}
