using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform playerTransform;   // Le Transform du joueur à suivre
    public Vector3 offset;              // Décalage entre la caméra et le joueur
    public float smoothSpeed = 0.125f;  // Vitesse de lissage du mouvement de la caméra

    void LateUpdate()
    {
        // Position cible de la caméra avec un décalage par rapport au joueur
        Vector3 targetPosition = playerTransform.position + offset;

        // Mouvement lissé de la caméra entre sa position actuelle et la position cible
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);

        // Applique la nouvelle position lissée à la caméra
        transform.position = smoothedPosition;
    }
}
