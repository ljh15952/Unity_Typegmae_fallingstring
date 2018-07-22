using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour {


    public WordManager WM;

	void Update ()
    {
        if (WM.isgamestart)
        {
            foreach (char word in Input.inputString)
            {
                WM.Typeletter(word);
            }
        }
	}
}
