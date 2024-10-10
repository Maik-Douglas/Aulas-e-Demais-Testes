using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Refer�ncia ao transform do jogador
    public Vector3 offset; // Offset da c�mera em rela��o ao jogador
    public float smoothSpeed = 0.125f; // Velocidade de suaviza��o da c�mera

    private void LateUpdate()
    {
        // Calcula a nova posi��o da c�mera
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Se quiser que a c�mera sempre olhe para o jogador
        transform.LookAt(player);
    }
}
