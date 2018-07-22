using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Word_Display : MonoBehaviour {

	
	public float fallspeed =1f;

    public Text text;

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }
    
    void Update ()
    {
       transform.Translate(0, -fallspeed*Time.deltaTime,0);
    }
}
