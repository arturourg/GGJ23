using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 100.0f;
    public bool isGround = true;
    public bool gameOver = false;
    private Rigidbody PlayerRb;
    public GameObject sprite;

    public GameManagement gameManagement;
    public float h;
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        sprite = GameObject.Find("sprite");
        gameManagement = GameObject.Find("GameManagement").GetComponent<GameManagement>();;
    }

    // Update is called once per frame
    void Update()
    {
        //Movement left & right
        h = Input.GetAxis("Horizontal") * speed;
        if(h > 0){
            sprite.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if(h < 0){
            sprite.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        PlayerRb.transform.Translate(h * Time.deltaTime, 0, 0);
        

        if (Input.GetKeyDown("space") && isGround){
            PlayerRb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
            isGround = false;
        }
        
    }

    void FixedUpdate() 
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Memory")){
            Player.Instance.AddMemory();
            PlayerLight.Instance.addSpotAngle(20.0f);
            Destroy(other.gameObject);
        }
        if(other.gameObject.CompareTag("Ground")){
            isGround = true;
        }
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Spike")){
            gameOver = true;
            Debug.Log("se murio");
            gameManagement.GameOver();
        }
    }

}
