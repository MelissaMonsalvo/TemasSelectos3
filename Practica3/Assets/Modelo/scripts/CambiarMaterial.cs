using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarMaterial : MonoBehaviour
{
     public GameObject esfera;
     public Material Material360;
     public Material Material3602;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int nummaterial=1;
        Renderer rend = esfera.GetComponent<Renderer>();

        foreach (Touch touch in Input.touches)
        {
            
            if(nummaterial ==1)
            {
                nummaterial=2;
            }else{
                nummaterial=1;
            }
        
            switch(nummaterial)
            {
                case 1:
                    rend.material = Material360;
                    break;
                case 2:
                    rend.material = Material3602;
                    break;
                default:
                    break;

            }
        }
    }
}
