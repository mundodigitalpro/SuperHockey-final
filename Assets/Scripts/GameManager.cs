
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public GameObject player1;
    public GameObject goal1;
    public GameObject player2;
    public GameObject goal2;
    public Text score1;
    public Text score2;
    private int player1Score;
    private int player2Score;
    public bool botGame;
    public int maxScore = 5;

    public void CheckVictory()
    {
        if (player1Score >= maxScore)
        {
            SceneManager.LoadScene("VictoryPlayer1");
        }
        if (player2Score >= maxScore)
        {
            SceneManager.LoadScene("VictoryPlayer2");
        }

    }

    public void Player1Scored()
    {
        player1Score++;
        score1.text = player1Score.ToString();
        CheckVictory();
        ResetPosition();

    }

    public void Player2Scored()
    {
        player2Score++;
        score2.text = player2Score.ToString();
        CheckVictory();
        ResetPosition();

    }

    private void ResetPosition()
    {

        if (botGame)
        {
            ball.GetComponent<Ball>().Reset();
            player1.GetComponent<Players>().Reset();
            //player2.GetComponent<Players>().Reset();

        }
        else
        {
            ball.GetComponent<Ball>().Reset();
            player1.GetComponent<Players>().Reset();
            player2.GetComponent<Players>().Reset();
        }
    }

}
