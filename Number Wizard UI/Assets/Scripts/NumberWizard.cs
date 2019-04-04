using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    // Make int max and min serializedfield so it can be modified from the editor
   [SerializeField] int max;
   [SerializeField] int min;

    // Make guessText serializedfield so game object text field can be passed to it from editor
   [SerializeField] TextMeshProUGUI guessText;

    // Declare list to hold numbers already guessed
    List<int> list = new List<int>();

    // int variable to hold current guess number
    int guess;

   
    // This function does actual guessing of the number
     void division()
    {
        // guess is made randomly.Max+1 is used since max is exclusive and we need to represent value 1000
        guess = Random.Range(min,max+1);
        
        // to stop guess from going over 1000 we have to limit it
        if(guess > 1000)
        {
            guess = 1000;
        }


        // same way it cannot go below 1
        if(guess < 1)
        {
            guess = 1;
        }

        /* if list above contains the guess then we have to call this function again 
         * until unique number is guessed */
        if (list.Contains(guess))
        {
            division();

        }
        // if number is not guessed before than add it to the list above and display it to the user
        else
        {
            list.Add(guess);
            guessText.text = guess.ToString();
            
        }
    }

    // this start function runs once at the beginning of the script
    void Start()
    {
        StartGame();
    }

    // this runs the first guess
    void StartGame()
    {

        division();
      
    }

    /* when higher button is pressed set minimum to value 
     * that is one above the current guess and call next guess function */
    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    /* when lower button is pressed set maximum to value 
    * that is one below the current guess and call next guess function */
    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }
   
    // this function just calls guess function
    void NextGuess()
    {
        division();
    }
}