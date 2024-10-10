using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Referência ao transform do jogador
    public Vector3 offset; // Offset da câmera em relação ao jogador
    public float smoothSpeed = 0.125f; // Velocidade de suavização da câmera

    private void LateUpdate()
    {
        // Calcula a nova posição da câmera
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Se quiser que a câmera sempre olhe para o jogador
        transform.LookAt(player);
    }
}
