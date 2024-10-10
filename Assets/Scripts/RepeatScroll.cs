using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatScroll : MonoBehaviour
{
    private InfiniteScroll infiniteScroll; // para acessar o script que contém o prefab;
    public bool instantiatedGround = false;

    void Start()
    {
        infiniteScroll = FindObjectOfType(typeof(InfiniteScroll)) as InfiniteScroll;  // para ter acesso a todas informações do Script InifiteScroll;
    } 

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && instantiatedGround == false) // Instancia apenas um prefab por vez se o player colidir no triger;
        {
            instantiatedGround = true; // transforma para verdadeiro para manter 1 instancia do prefab por vez
            GameObject Objetotemp = Instantiate(infiniteScroll.chaoPrefab); 
            Objetotemp.transform.position = new Vector3(transform.position.x + 20f, transform.position.y, transform.position.z); //transform.position.x + 20f no caso é a posição do 1 prefab em relação aonde o próximo da exatamente 20 metros à frente;
        }
    }

    private void OnTriggerExit(Collider other) // após o jogador sair do trigger o prefab anterior é destruído;
    {
        if(other.CompareTag("Player"))
        {
            Destroy(this.gameObject); // destrói o objeto com o trigger;
        }
    }
}
