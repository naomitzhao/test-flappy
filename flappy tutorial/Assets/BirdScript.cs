using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength = 10;
    public GameLogic logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start() // runs once, when script is first enabled
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive){
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        
    }

    public void OnCollisionEnter2D(Collision2D collision){
        logic.gameOver();
        birdIsAlive = false;
    }
}
