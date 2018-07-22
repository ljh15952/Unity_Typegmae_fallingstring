using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {


     static string[] wordList = {"apple","banana","grape", "house", "wish", "whie", "for", "public", "string", "word", "fuck", "king", "korea", "array", "yellow", "red",
        "blue", "purple", "green", "tree", "book", "buy", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "first", "third", "second", "wife", "wine",
        "plus", "minus", "school", "game", "science", "star", "craft", "mine"};

    public static string GetRandomword()
    {
        int randnum = Random.Range(0, wordList.Length);
        return wordList[randnum];
    }
}
