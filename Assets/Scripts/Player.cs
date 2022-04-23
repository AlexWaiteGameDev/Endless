using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D RB;
    public AudioSource JumpSound;
    

    private Vector3 startingPosition;


    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    public void Jump ()
    {
        Vector2 jumpForce = new Vector2(0.0f, 250.0f);
        RB.AddForce(jumpForce);

        JumpSound.Play();
    }

    public void Reset()
    {
        transform.position = startingPosition;
        RB.velocity = new Vector2(0f, 0f);
    }

}