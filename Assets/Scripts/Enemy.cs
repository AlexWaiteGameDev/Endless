using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    // VARS - Public *******************************
    public float Speed = 3.0f;
    public AudioSource DeathSound;
    public Text scoreText;
    public Player MainPlayer;
    public Enemy enemy1;
    public Enemy enemy2;

    // VARS - Private ******************************
    private static int score = 0;
    private Vector3 startingPosition;

    // VARS - END **********************************


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Welcome";

        startingPosition = transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        //1. Get the current position
        Vector3 currentPosition = transform.position;

        //2. Modify the position
        currentPosition.x -= Speed * Time.deltaTime;

        if (currentPosition.x < -10.5f)
        {
            currentPosition.x = 10.5f;

            score++;
            scoreText.text = "score: " + score;
        }

        //3. Re-apply position
        transform.position = currentPosition;

        //Debug.Log(Time.deltaTime);
    }


    // Reset Function
    public void Reset()
    {
        transform.position = startingPosition;

        enemy1.transform.position = enemy1.startingPosition;
        enemy2.transform.position = enemy2.startingPosition;

        score = 0;
        scoreText.text = "score: " + score;
    }


    // Trigger Funciton
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("TRIGGER ENTER");

        DeathSound.Play();

        Reset();
        MainPlayer.Reset();
    }


    // Collision Function
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("COLLISION ENTER");
    }

}   // END SCRIPT