using UnityEngine;

public class Ball : MonoBehaviour
{
    private float velocityMultiplier = 1.1f;
    public float speed = 7;
    public Rigidbody2D ballRb;
    private Vector2 startPos;
    public AudioSource audioPlayer;

    void Start()
    {
        transform.position = startPos;
        Launch();
    }

    public void Reset()
    {
        transform.position = startPos;
        ballRb.velocity = Vector2.zero;
        Launch();
    }


    public void Launch() // Metodo que se encarga de lanzar la bola aleatoriamente
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;// Si el valor es 0 va a la izquierda o si no a la derecha
        float y = Random.Range(0, 2) == 0 ? -1 : 1;// Si el valor es 0 va hacia arriba o si no hacia abajo
        ballRb.velocity = new Vector2(speed * x, speed * y);// añadimos la velocidad a la pelota
    }

    //Metodo para aumentar la velocidad cada vez que colisiona con Player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audioPlayer.Play();
            ballRb.velocity *= velocityMultiplier;

        }
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, 20));
    }



}
