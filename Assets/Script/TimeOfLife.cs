using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOfLife : MonoBehaviour
{
    public float timeOfLife;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeOfLife);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
