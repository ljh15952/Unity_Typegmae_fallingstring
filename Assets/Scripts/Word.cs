using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Word {

    public string word;
    int typeIndex;

    public Word_Display display;

    public Word(string _word,Word_Display _display)
    {
        typeIndex = 0;
        word = _word;

        display = _display;
        display.SetWord(_word);
    }

    public void TypeWord()
    {
        typeIndex++;
        display.RemoveLetter();
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public bool TypedWord()
    {
        bool istyped = (typeIndex >= word.Length);
        if(istyped)
        {
            display.RemoveWord();
        }
        return istyped;
    }

}
