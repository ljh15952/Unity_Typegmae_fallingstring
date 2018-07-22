using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

    public GameObject wordPrefab;
    public Transform wordCanvas;

    public Word_Display SpawnWord()
    {
        Vector3 randomPos = new Vector3(Random.Range(-2.5f, 2.5f), 7);

        GameObject wordObj = Instantiate(wordPrefab, wordCanvas);
        wordObj.transform.position = randomPos;
        Word_Display wordDIsPlay = wordObj.GetComponent<Word_Display>();

        return wordDIsPlay;
    }
}
