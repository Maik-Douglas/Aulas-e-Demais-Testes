using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarObjeto : MonoBehaviour
{
    [SerializeField] private int rotacaoPorSegundo = 30;

    [SerializeField] private bool girar;

    [SerializeField] private Vector3 posicaoDoObjeto;

    float eixoX;
    float eixoY;

    private MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        posicaoDoObjeto = transform.position;

        

        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            girar = !girar;
            meshRenderer.material.color = Random.ColorHSV(); // cor aleatória;

            eixoX = Random.Range(-2f, 2f);
            eixoY = Random.Range(-2f, 2f);


        }
        Girar();
    }

    private void Girar()
    {
        if (girar == true)
        {
            transform.Rotate(0, 0, rotacaoPorSegundo * Time.deltaTime);
            transform.position = posicaoDoObjeto;
        }
        else
        {
            transform.position = new Vector3(posicaoDoObjeto.x + eixoX, posicaoDoObjeto.y + eixoY, posicaoDoObjeto.z);
        }
    }
}
