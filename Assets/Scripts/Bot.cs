using UnityEngine;

public class Bot : MonoBehaviour
{
    public float speed = 3;
    public GameObject ball;
    private Vector2 ballPos;

    void Update()

    {
        Move();
    }

    void Move()
    {
        ballPos = ball.transform.position;

        if (transform.position.y > ballPos.y)
        {
            transform.position += new Vector3(0, -speed * Time.deltaTime);
        }
        if (transform.position.y < ballPos.y)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime);
        }
        //if (transform.position.x > ballPos.x)
        //{
        //    transform.position += new Vector3(0, -speed * Time.deltaTime);
        //}
        //if (transform.position.x < ballPos.x)
        //{
        //    transform.position += new Vector3(0, speed * Time.deltaTime);
        //}


    }
}
