using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wall : MonoBehaviour
{
    // VARS - Public *******************************
    public AudioSource DeathSound;
    public Player MainPlayer;
    public Enemy enemy1;
    public Enemy enemy2;
    public Enemy enemy3;



    // VARS - Private ******************************
    private static int score = 0;

    // VARS - END **********************************


    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }

    // Trigger Funciton
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("TRIGGER ENTER");
    }


    // Collision Function
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("COLLISION ENTER");

        DeathSound.Play();

        MainPlayer.Reset();        
        enemy1.Reset();
        enemy2.Reset();
        enemy3.Reset();
    }

}   // END SCRIPT