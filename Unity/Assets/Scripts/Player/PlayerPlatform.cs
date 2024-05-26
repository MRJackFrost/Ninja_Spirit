using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPlatform : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Walk();
        Die();
    }


    private void Die()
    {
        if (GameManager.Instance.life <= 0)
        {
            Destroy(this);
            SceneManager.LoadScene("Menu");
        }
    }

    private void Walk()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        
        Vector2 direction = new Vector2(hor, ver).normalized;
        rb.velocity = new Vector2(direction.x*speed, direction.y*speed);

        animator.SetFloat("hor", Mathf.Abs(hor));

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Right", false);
            animator.SetBool("Left", true);
            animator.SetBool("Foward", false);
            animator.SetBool("Backward", false);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("Left", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("Right", true);
            animator.SetBool("Left", false);
            animator.SetBool("Foward", false);
            animator.SetBool("Backward", false);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("Right", false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("Right", false);
            animator.SetBool("Left", false);
            animator.SetBool("Foward", false);
            animator.SetBool("Backward", true);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("Backward", false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("Right", false);
            animator.SetBool("Left", false);
            animator.SetBool("Foward", true);
            animator.SetBool("Backward", false);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("Foward", false);
        }
    }
}
