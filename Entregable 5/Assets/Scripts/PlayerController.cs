using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Speed = 10.0f;
    private float verticalInput;
    public float turnSpeed = 20.0f;
    public float zMax = 450f;


    void Start()
    {
        //Esto hace que el Player empiece si o si, en la posicion 0,0,0
        transform.position = new Vector3(0, 0, 0);
    }

    void Update()
    {
        //Con esto avanza hacia delante de forma automatica
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        //Con esto rotamos el avion hacia arriba y abajo
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime * verticalInput);

        //Esto hace que si supera el limite de zMax, se acaba el juego
        if (transform.position.z >= zMax)
        {
            Debug.Log("THE END");
            Time.timeScale = 0;
        }
    }
}
