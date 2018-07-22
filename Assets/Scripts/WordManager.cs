using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{

    public List<Word> words;

    public GameObject Result;
    
    bool hasActiveword;
    Word activeword;

    public WordSpawner Wspawn;
    public bool isgamestart = true;

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomword(),Wspawn.SpawnWord());
        words.Add(word);
    }

    public void Typeletter(char letter)
    {
        if (hasActiveword)
        {
            if(activeword.GetNextLetter()==letter)
            {
                activeword.TypeWord();
            }
        }
        else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    word.TypeWord();
                    hasActiveword = true;
                    activeword = word;
                    break;
                }
            }
        }

        RemoveWordList();
     
    }

    public void RemoveWordList()
    {
        if (hasActiveword && activeword.TypedWord())
        {
            words.Remove(activeword);
            hasActiveword = false;
        }
    }

    private void Update()
    {
        foreach (Word word in words)
        {
            if (word.display.transform.position.y < -5)
            {
                Result.SetActive(true);
                isgamestart = false;
            }
        }
    }
}
