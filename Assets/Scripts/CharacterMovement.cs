using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovement : MonoBehaviour
{
    
    private float Horizontal;
    private Rigidbody2D Rigidbody2D;
    public float speed;
    public float jumpForce;
    private bool grounded; 
    private Animator Animator;


    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        this.speed = CharacterStats.instance.speed;
        this.jumpForce = CharacterStats.instance.jump;
        Animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        bool animar = false;

        if(Horizontal < 0){
            transform.localScale = new Vector3(-1, 1, 1);
            animar = true;
        }else if(Horizontal>0){
            transform.localScale = new Vector3(1, 1, 1);
            animar = true;
        }else{
            animar = false;
        }



        Animator.SetBool("running", animar);   

        if(Input.GetKeyDown(KeyCode.W) && grounded){
            jump();
        }
        
    }


    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.CompareTag("Block")){
            grounded = true;
        }
        if(other.collider.CompareTag("KillLimit")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(other.collider.CompareTag("WinLimit")){
            SceneManager.LoadScene("WinningScene");
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if(other.collider.CompareTag("Block")){
            grounded = false;
        }
    }


    void jump(){
        Rigidbody2D.AddForce(Vector2.up * jumpForce);
    }


    private void FixedUpdate() {
        Rigidbody2D.velocity = new Vector2(Horizontal * speed, Rigidbody2D.velocity.y);    
    }
}
