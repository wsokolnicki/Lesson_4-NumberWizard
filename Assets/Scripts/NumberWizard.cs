using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] Text guestText;

    int guess;

    void Start ()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void OnPressingHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressingLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max);
        guestText.text = guess.ToString();
    }
}
