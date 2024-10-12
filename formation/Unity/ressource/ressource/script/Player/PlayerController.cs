using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    /*=====================================================================================================================================================*/

    private bool canMove = true ;

    // Variables pour la gestion du mouvement
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private bool isGrounded = true;  // Vérifie si le joueur est au sol
    private bool isJumping = true ;


    private Rigidbody2D rb;
    private Animator animator;  // Pour gérer les animations
    private bool isAttacking = false;

    // Pour les couches avec lesquelles le joueur interagit
    public Transform groundCheck;
    public LayerMask groundLayer;

    /*=====================================================================================================================================================*/

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); // Si tu as des animations
    }

    void Update()
    {
        Move();
        Jump();
    }

    /*=====================================================================================================================================================*/

    void Move()
    {
        if( !canMove )
        {
            return ;
        }

        // Déplacement horizontal
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Flip du personnage (face à gauche/droite)
        if (moveInput > 0)
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z); // Face à droite
        else if (moveInput < 0)
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z); // Face à gauche

        // Mettre à jour l'animation si tu as un Animator
        if (animator != null)
        {
            animator.SetFloat("Speed", Mathf.Abs(moveInput));
        }
    }

    /*=====================================================================================================================================================*/

    void Jump()
    {
        // Vérifie si le joueur est au sol avant de sauter
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        // Si le joueur appuie sur le bouton de saut et est au sol
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            // Appliquer une force vers le haut pour faire sauter le joueur
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);

            // Si un Animator est attaché, lancer l'animation de saut
            if (animator != null)
            {
                animator.SetTrigger("Jump");
            }
        }
    }

    /*=====================================================================================================================================================*/

    // Coroutine pour activer canMove après un délai donné
    public IEnumerator EnableMovementAfterDelay(float delay)
    {
        canMove = false ;
        rb.velocity = new Vector2(0,0);

        // Attend le délai spécifié (ici 1 seconde)
        yield return new WaitForSeconds(delay);

        // Place canMove à true après le délai
        canMove = true;
    }

    void OnDrawGizmos()
    {
        if (groundCheck != null)
        {
        // Définir la couleur des Gizmos à rouge
        Gizmos.color = Color.red;

        // Dessiner un cercle au point de vérification du sol
        Gizmos.DrawWireSphere(groundCheck.position, 0.2f);
        }
    }

    /*=====================================================================================================================================================*/

}
