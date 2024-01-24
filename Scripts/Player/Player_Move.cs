using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D myRB;
    public float strenght;
    public float acceleration = 0.01f;

    public float total_speed = 1.5f;

    void Start()
    {
        StartCoroutine(Speed_up());
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            myRB.velocity = Vector2.up * strenght;
        }
    }
    IEnumerator Speed_up()
    {
        while (true)
        {
            foreach (GameObject pipe in GameObject.FindGameObjectsWithTag("Pipe"))
            {
                pipe.GetComponent<Pipe_Move>().speed = total_speed;
            }
            total_speed += acceleration;

            yield return new WaitForSecondsRealtime(1);
        }
    }
}
