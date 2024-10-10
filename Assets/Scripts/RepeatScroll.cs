using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatScroll : MonoBehaviour
{
    private InfiniteScroll infiniteScroll; // para acessar o script que cont�m o prefab;
    public bool instantiatedGround = false;

    void Start()
    {
        infiniteScroll = FindObjectOfType(typeof(InfiniteScroll)) as InfiniteScroll;  // para ter acesso a todas informa��es do Script InifiteScroll;
    } 

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && instantiatedGround == false) // Instancia apenas um prefab por vez se o player colidir no triger;
        {
            instantiatedGround = true; // transforma para verdadeiro para manter 1 instancia do prefab por vez
            GameObject Objetotemp = Instantiate(infiniteScroll.chaoPrefab); 
            Objetotemp.transform.position = new Vector3(transform.position.x + 20f, transform.position.y, transform.position.z); //transform.position.x + 20f no caso � a posi��o do 1 prefab em rela��o aonde o pr�ximo da exatamente 20 metros � frente;
        }
    }

    private void OnTriggerExit(Collider other) // ap�s o jogador sair do trigger o prefab anterior � destru�do;
    {
        if(other.CompareTag("Player"))
        {
            Destroy(this.gameObject); // destr�i o objeto com o trigger;
        }
    }
}
