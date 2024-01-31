using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timeScoreText, timeText, scoreText;
    public int score = 0;
    int number;
    int pressedButton;
    bool start = false;
    float countdown;
    

    // Start is called before the first frame update
    void Start()
    {
        countdown = 1.5f;
        
        pressedButton = 0;
        number = -1;
        start = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start == false && Input.GetKeyDown(KeyCode.Keypad6))
        {
            PressTheButton();
            start = true;
            score = 0;
            countdown = 1.5f;
            
        }

        // Identify pressed Button ------------------ Start ----------------------------------------

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            pressedButton = 1;

            if (number != pressedButton)
            {
                GameEnd();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            pressedButton = 2;

            if (number != pressedButton)
            {
                GameEnd();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            pressedButton = 3;

            if (number != pressedButton)
            {
                GameEnd();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            pressedButton = 4;

            if (number != pressedButton)
            {
                GameEnd();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            pressedButton = 5;

            if (number != pressedButton)
            {
                GameEnd();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            pressedButton = 6;

            
        }

        if (pressedButton == number)
        {
           
            
            
            pressedButton = 0;
            Debug.Log("YES");
            score = score + 1;
            countdown = 1.5f - (0.05f * score);
            PressTheButton();
            scoreText.SetText(score.ToString());



        }

        
        


        // Identify pressed Button ------------------ End --------------------------------------


        timeText.SetText(countdown.ToString());

        if (start == true)
            countdown -= Time.deltaTime;



        void PressTheButton()
        {
            number = Random.Range(1, 7);
            timeScoreText.SetText(number.ToString());


        }



        if (countdown <= 0)
        {
            GameEnd();
        }
    }

    void GameEnd()
    {
        number = 0;
        pressedButton = -1;
        timeScoreText.SetText(score.ToString());
        start = false;
    }

   
    
}

