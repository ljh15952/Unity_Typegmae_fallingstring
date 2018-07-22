using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour {

	public void PressStartButton()
    {
        SceneManager.LoadScene("ingame");
    }

    public void PressRretryBuutton()
    {
        SceneManager.LoadScene("ingame");
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("MainScene");
    }
}
