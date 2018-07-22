using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldTimer : MonoBehaviour {

    public WordManager WM;
    public float wordDelay = 1.5f;
    private float nextWordTime = 0;

    private void Update()
    {
        if(Time.time >=nextWordTime)
        {
            WM.AddWord();
            nextWordTime = Time.time + wordDelay;
            wordDelay *= .99f;
        }
    }
}
