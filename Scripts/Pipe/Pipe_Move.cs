using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Move : MonoBehaviour
{
    public GameObject pipe;
    public float speed = 0f;
    public float deadzone = -10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pipe.transform.position -= new Vector3(1, 0, 0) * speed * Time.deltaTime;
        if (pipe.transform.position.x < deadzone) Destroy(pipe);
    }
}
