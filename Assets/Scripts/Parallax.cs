using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        position.x -= Speed * Time.deltaTime;

        if (position.x <= -20.0f)
        {
            position.x += 40.0f;
        }

        transform.position = position;
    }
}
