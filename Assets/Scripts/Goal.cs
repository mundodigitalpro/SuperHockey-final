using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool goal;
    public GameObject gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if (goal)
            {
                gameManager.GetComponent<GameManager>().Player1Scored();
               
            }
            else
            {
                gameManager.GetComponent<GameManager>().Player2Scored();
            }
        }
    }
}
