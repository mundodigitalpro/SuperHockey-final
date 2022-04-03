using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public bool player1;
    public float speed = 3;
    public Rigidbody2D rb;
    private float movex;
    private float movey;
    private Vector2 startPos; // guarda la posicion inicial


    void Start()
    {
        
        startPos = transform.position; //Posición Inicial de Players

    }


    void Update()
    {
        
        if (player1) // Si es el player1 utilizamos un tipo de Input
        {
            movex = Input.GetAxisRaw("Horizontal");
            movey = Input.GetAxisRaw("Vertical");
        }
        else // Si no será el player2 y utilizamos otro tipo de Input
        {
            movex = Input.GetAxisRaw("Horizontal2");
            movey = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movex * speed);//Modificamos la velocidad a su RigidBody en el eje X
        rb.velocity = new Vector2(rb.velocity.y, movey * speed);//Modificamos la velocidad a su RigidBody en el eje Y

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero; //Velocidad del RigidBody de nuestros Players se pone a cero
        transform.position = startPos;// Ponemos nuestra posicion inicial
    }
}
