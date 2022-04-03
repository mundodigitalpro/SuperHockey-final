using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limits : MonoBehaviour
{

    private Transform trans;
    public Vector2 rangoHorizontal = Vector2.zero;
    public Vector2 rangoVertical = Vector2.zero;


    private void LateUpdate()
    {
        trans.position = new Vector3(

            //Ponemos un limite

            Mathf.Clamp(transform.position.x, rangoVertical.x, rangoVertical.y),
            Mathf.Clamp(transform.position.y, rangoHorizontal.x, rangoHorizontal.y),
            transform.position.z


            );
    }

    void Start()
    {

        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
