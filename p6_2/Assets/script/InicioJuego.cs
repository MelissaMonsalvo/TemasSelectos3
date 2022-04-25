using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioJuego : MonoBehaviour
{
    // Start is called before the first frame update
    public void InicioContador()
    {
        Timer.inst.inicializarTiempo();
    }
}
