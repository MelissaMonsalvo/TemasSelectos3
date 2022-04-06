using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public static Timer inst;
    public Text UItexto;
    private TimeSpan tiempo;
    private bool t= false;
    private float tiempoTrans;
    public Button button;


    private void Awake()
    {
        inst=this;
    }

    void Start()
    {   
          UItexto.text="00:00:00";
          t=false;
    }

    // Update is called once per frame
    public void inicializarTiempo()
    {
        t=true;
        tiempoTrans=0.0F;
        StartCoroutine(AtUpdate());
    }

    public void Ini()
    {
        button.gameObject.SetActive(false);
        inicializarTiempo();
    }
    

    public void FinTiempo()
    {
        t=false;
    }

    private IEnumerator AtUpdate()
    {
        while(t)
        {
            tiempoTrans += Time.deltaTime;
            tiempo=TimeSpan.FromSeconds(tiempoTrans);
            String tiempostr= tiempo.ToString("mm':'ss':'ff");
            UItexto.text=tiempostr;
            yield return null;
        }
    }

}
