using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarObjeto : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] objetos; //obt�m os objetos dentro do array.
    public GameObject objetoAtual; //obt�m o �nico objeto atual de uma posi��o do array.
    public Transform posicaoObjeto; // posi��o do objeto dentro do array aonde ser� instanciado.
    public int indiceAtual = 0; //�ndice do objeto atualmente instanciado.
 
    
    void Start()
    {
        if (objetos.Length > 0)  //Verifica se existe objetos dentro do array.
        {
            objetoAtual = Instantiate(objetos[indiceAtual], posicaoObjeto.position, Quaternion.identity); //Instancia o objeto pelo �ndice atual, e referencia o posi��o e rota��o do local a ser instanciado.
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
            if (objetoAtual != null) // verifica se tem algum objeto instanciado atualmente e o destr�i.
            {
                Destroy(objetoAtual);
            }
            indiceAtual = (indiceAtual + 1) % objetos.Length;

            objetoAtual = Instantiate(objetos[indiceAtual], posicaoObjeto.position, Quaternion.identity);
        }
    }

}
