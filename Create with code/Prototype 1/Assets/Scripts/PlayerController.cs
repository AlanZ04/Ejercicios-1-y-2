using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float velz = 40.0f;
    private float velx = 35.0f;
    private float horizontalInput;
    private float verticalInput;
    private string horizontalAxis = "Horizontal";
    private string verticalaxis = "Vertical";
    private int posfin = 105; //Variable del final de la calle
    private int posini = -95; //Variable del start de la calle



    // Start is called before the first frame update
    void Start()
    {
        //int x = 0;
        //int y = 0;
    }

    // Update is called once per frame
    void Update()
    {

        //Adelante autito
        verticalInput = Input.GetAxis(verticalaxis);
        transform.Translate(Vector3.forward * Time.deltaTime * velz * verticalInput);


        //Derecha-izquierda autito
        horizontalInput = Input.GetAxis(horizontalAxis);
        transform.Rotate(Vector3.up, Time.deltaTime * velx * horizontalInput);

        
    }

    private void LateUpdate()
    {
        if (transform.position.z > posfin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, posini);

        }
    }
}
