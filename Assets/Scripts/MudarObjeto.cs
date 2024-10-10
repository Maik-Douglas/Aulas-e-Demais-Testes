using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarObjeto : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] objetos; //obtém os objetos dentro do array.
    public GameObject objetoAtual; //obtém o único objeto atual de uma posição do array.
    public Transform posicaoObjeto; // posição do objeto dentro do array aonde será instanciado.
    public int indiceAtual = 0; //índice do objeto atualmente instanciado.
 
    
    void Start()
    {
        if (objetos.Length > 0)  //Verifica se existe objetos dentro do array.
        {
            objetoAtual = Instantiate(objetos[indiceAtual], posicaoObjeto.position, Quaternion.identity); //Instancia o objeto pelo índice atual, e referencia o posição e rotação do local a ser instanciado.
        }
    }

    // Update is called once per frame
    void Update()
    {
        TrocarObjeto(); //faz a troca de objetos em tempo real de cada frame.
    }

    void TrocarObjeto()
    {
        if (Input.GetKeyDown(KeyCode.X)) //verifica se a tecla 'X' foi pressionada.
        {
            if (objetoAtual != null) // verifica se tem algum objeto instanciado atualmente e o destrói.
            {
                Destroy(objetoAtual);
            }
            indiceAtual = (indiceAtual + 1) % objetos.Length;

            objetoAtual = Instantiate(objetos[indiceAtual], posicaoObjeto.position, Quaternion.identity);
        }
    }

}
