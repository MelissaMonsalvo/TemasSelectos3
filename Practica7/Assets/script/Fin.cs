using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fin : MonoBehaviour
{
    private Timer t;

     void Start()
    {
        t = GetComponent<Timer>();

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //t.FinTiempo();
		Timer.inst.FinTiempo();
        }
    }
}
