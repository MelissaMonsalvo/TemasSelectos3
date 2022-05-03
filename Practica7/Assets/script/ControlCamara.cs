using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    public GameObject jugador;
    public GameObject referencia;
    private Vector3 posRelativa;
    // Start is called before the first frame update
    void Start()
    {
        posRelativa=transform.position - jugador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        posRelativa=Quaternion.AngleAxis(Input.GetAxis("Mouse X")*6 , Vector3.up)*posRelativa;
        transform.position=jugador.transform.position + posRelativa;
        transform.LookAt(jugador.transform.position);

        Vector3 copiaRotacion = new Vector3(0, transform.eulerAngles.y,0);
        referencia.transform.eulerAngles=copiaRotacion;
        

    }
}
