using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text button1Text;  bool button1Pressed;
    public TMP_Text button2Text;  bool button2Pressed;
    public TMP_Text button3Text;  bool button3Pressed;
    public TMP_Text button4Text;  bool button4Pressed;
    public TMP_Text button5Text;  bool button5Pressed;
    public TMP_Text button6Text;  bool button6Pressed;
    public TMP_Text button7Text;  bool button7Pressed;
    public TMP_Text button8Text;  bool button8Pressed;
    public TMP_Text button9Text;  bool button9Pressed;


    public bool isPlayerTurn = false;
    public GameObject player1Turntext, player2Turntext, GamePlayPanel,resultPanel;
    public TMP_Text playerWinnerText;


    private void Update()
    {
        ChecktheWinner();
    }




    #region  ButtonsFunctions
    public void Button1Click()    // Button 1 Function
    {
        if(!button1Pressed)
        {
            if (!isPlayerTurn)
            {
                button1Text.SetText("X");
                isPlayerTurn = true;
                button1Pressed = true;
                player1Turntext.SetActive(true);
                player2Turntext.SetActive(false);
            }
            else
            {
                button1Text.SetText("O");
                isPlayerTurn = false;
                button1Pressed = true;
                player1Turntext.SetActive(false);
                player2Turntext.SetActive(true);
            }
        }
       
    }
    public void Button2Click()         // Button 2 Function
    {
        if(!button2Pressed)
        {
            if (!isPlayerTurn)
            {
                button2Text.SetText("X");
                isPlayerTurn = true;
                button2Pressed = true;
                player1Turntext.SetActive(true);
                player2Turntext.SetActive(false);
            }
            else
            {
                button2Text.SetText("O");
                isPlayerTurn = false;
                button2Pressed = true;
                player2Turntext.SetActive(true);
                player1Turntext.SetActive(false);
            }
        }
       
    }

    public void Button3Click()           // Button 3 Function
    {
        if(!button3Pressed)
        {
            if (!isPlayerTurn)
            {
                button3Text.SetText("X");
                isPlayerTurn = true;
                button3Pressed = true;
                player1Turntext.SetActive(true);
                player2Turntext.SetActive(false);
            }
            else
            {
                button3Text.SetText("O");
                isPlayerTurn = false;
                button3Pressed = true;
                player2Turntext.SetActive(true);
                player1Turntext.SetActive(false);
            }
        }
       
    }

    public void Button4Click()           // Button 4 Function
    {
        if(!button4Pressed)
        {
            if (!isPlayerTurn)
            {
                button4Text.SetText("X");
                isPlayerTurn = true;
                button4Pressed = true;
                player1Turntext.SetActive(true);
                player2Turntext.SetActive(false);
            }
            else
            {
                button4Text.SetText("O");
                isPlayerTurn = false;
                button4Pressed = true;
                player2Turntext.SetActive(true);
                player1Turntext.SetActive(false);
            }
        }
        
    }

    public void Button5Click()         // Button 5 Function
    {
        if(!button5Pressed)
        {
            if (!isPlayerTurn)
            {
                button5Text.SetText("X");
                isPlayerTurn = true;
                button5Pressed = true;
                player1Turntext.SetActive(true);
                player2Turntext.SetActive(false);
            }
            else
            {
                button5Text.SetText("O");
                isPlayerTurn = false;
                button5Pressed = true;
                player2Turntext.SetActive(true);
                player1Turntext.SetActive(false);
            }
        }
        
    }

    public void Button6Click()                  // Button 6 Function
    {
        if(!button6Pressed)
        {
            if (!isPlayerTurn)
            {
                button6Text.SetText("X");
                isPlayerTurn = true;
                button6Pressed = true;
                player1Turntext.SetActive(true);
                player2Turntext.SetActive(false);
            }
            else
            {
                button6Text.SetText("O");
                isPlayerTurn = false;
                button6Pressed = true;
                player2Turntext.SetActive(true);
                player1Turntext.SetActive(false);
            }
        }
        
    }

    public void Button7Click()           // Button 7 Function
    {
        if(!button7Pressed)
        {
            if (!isPlayerTurn)
            {
                button7Text.SetText("X");
                isPlayerTurn = true;
                button7Pressed = true;
                player1Turntext.SetActive(true);
                player2Turntext.SetActive(false);
            }
            else
            {
                button7Text.SetText("O");
                isPlayerTurn = false;
                button7Pressed = true;
                player2Turntext.SetActive(true);
                player1Turntext.SetActive(false);
            }
        }
       
    }

    public void Button8Click()       // Button 8 Function
    {
        if(!button8Pressed)
        {
            if (!isPlayerTurn)
            {
                button8Text.SetText("X");
                isPlayerTurn = true;
                button8Pressed = true;
                player1Turntext.SetActive(true);
                player2Turntext.SetActive(false);
            }
            else
            {
                button8Text.SetText("O");
                isPlayerTurn = false;
                button8Pressed = true;
                player2Turntext.SetActive(true);
                player1Turntext.SetActive(false);
            }
        }    
    }

    public void Button9Click()       // Button 9 Function
    {
        if(!button9Pressed)
        {
            if (!isPlayerTurn)
            {
                button9Text.SetText("X");
                isPlayerTurn = true;
                button9Pressed = true;
                player1Turntext.SetActive(true);
                player2Turntext.SetActive(false);
            }
            else
            {
                button9Text.SetText("O");
                isPlayerTurn = false;
                button9Pressed = true;
                player2Turntext.SetActive(true);
                player1Turntext.SetActive(false);
            }
        }
    }


    public void ResetButton()
    {
        GamePlayPanel.SetActive(true);
        resultPanel.SetActive(false);
        isPlayerTurn = false;

        button1Text.SetText(" ");
        button2Text.SetText(" ");
        button3Text.SetText(" ");
        button4Text.SetText(" ");
        button5Text.SetText(" ");
        button6Text.SetText(" ");
        button7Text.SetText(" ");
        button8Text.SetText(" ");
        button1Text.SetText(" ");
     
    }
    #endregion


    public void ChecktheWinner()                 
    {
        if((button1Text.text == "X"  && button2Text.text == "X"  && button3Text.text == "X")||                   //WINNING CONDTION OF PLAYER 1 (X)
            (button4Text.text == "X" && button5Text.text == "X" && button6Text.text == "X") || 
            (button1Text.text == "X" && button2Text.text == "X" && button3Text.text == "X")  ||
            (button7Text.text == "X" && button8Text.text == "X" && button9Text.text == "X") ||
            (button1Text.text == "X" && button4Text.text == "X" && button7Text.text == "X") ||
            (button2Text.text == "X" && button5Text.text == "X" && button8Text.text == "X") ||
            (button3Text.text == "X" && button6Text.text == "X" && button9Text.text == "X") ||
            (button1Text.text == "X" && button5Text.text == "X" && button9Text.text == "X")
            )
        {
            StartCoroutine(WaitForSecondsPlayer1());
            
        }
         
        if ((button1Text.text == "O" && button2Text.text == "O" && button3Text.text == "O") ||                 //WINNING CONDTION OF PLAYER 2 (O)
          (button4Text.text == "O" && button5Text.text == "O" && button6Text.text == "O") ||
          (button1Text.text == "O" && button2Text.text == "O" && button3Text.text == "O") ||
          (button7Text.text == "O" && button8Text.text == "O" && button9Text.text == "O") ||
          (button1Text.text == "O" && button4Text.text == "O" && button7Text.text == "O") ||
          (button2Text.text == "O" && button5Text.text == "O" && button8Text.text == "O") ||
          (button3Text.text == "O" && button6Text.text == "O" && button9Text.text == "O") ||
          (button1Text.text == "O" && button5Text.text == "O" && button9Text.text == "O")
          )
        {
            StartCoroutine(WaitForSecondsPlayer1());
        }

        if(button1Pressed && button2Pressed && button3Pressed && button4Pressed && button5Pressed && button6Pressed && button7Pressed && button8Pressed  && button9Pressed )
        {
            GamePlayPanel.SetActive(false);
            resultPanel.SetActive(true);
            playerWinnerText.text = ("Its a draw");
        }
    }



    IEnumerator WaitForSecondsPlayer1()
    {
        yield return new WaitForSeconds(2);
        GamePlayPanel.SetActive(false);
        resultPanel.SetActive(true);
        if(isPlayerTurn)
            playerWinnerText.text = ("Player 1 with X Symbol");
        else
            playerWinnerText.text = ("Player 2 with O Symbol");

    }
}
