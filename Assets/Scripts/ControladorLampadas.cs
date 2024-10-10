using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorLampadas : MonoBehaviour
{
    [SerializeField] private Light lampada1;
    [SerializeField] private Light lampada2;
    [SerializeField] private Light lampada3;
  


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            lampada1.enabled = !lampada1.enabled;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            lampada2.enabled = !lampada2.enabled;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            lampada3.enabled = !lampada3.enabled;
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            lampada1.color = Random.ColorHSV();
            lampada2.color = Random.ColorHSV();
            lampada3.color = Random.ColorHSV();
        }
    }
}
