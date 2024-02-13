using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDuration : MonoBehaviour
{
    public int maxDuration = 5;
    private int currentDuration;

    // Start is called before the first frame update
    void Start()
    {
        currentDuration = maxDuration;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UseObject()
    {
        currentDuration--;

        if (currentDuration <= 0)
        {
            currentDuration = 0;
        }
    }
}
