using UnityEngine;

/// <summary>
/// Hace girar el objeto al que esta asignado (Siren_Pivot) alrededor del eje Y.
/// Como las luces roja y azul son hijas del pivote, giran con el en circulo.
/// </summary>
public class SirenRotation : MonoBehaviour
{
    // Velocidad de giro en grados por segundo. Al ser publica aparece en el Inspector.
    public float rotationSpeed = 360f;

    void Update()
    {
        // Time.deltaTime = segundos desde el ultimo fotograma.
        // Multiplicar por el hace que el giro sea de X grados POR SEGUNDO
        // y no por fotograma, asi no depende de los FPS del computador.
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
// Script de rotación para las sirenas de la patrulla
