using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCajas : MonoBehaviour
{
    // Start is called before the first frame update
    public Quaternion rotacion;
    public Vector3 poscaj;
    public GameObject player;
    private int posfin = 104;
    void Start()
    {
        rotacion = transform.rotation;
        poscaj = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z > posfin)
        {
            transform.rotation = rotacion;
            transform.position = poscaj;
        }
    }
}
