using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Button : MonoBehaviour
{
    public GameObject btn;
    public GameObject btn_base;

    public GameObject top_pipe;
    public GameObject bottom_pipe;
    public float pipe_offset = 1f;
    public float step = 0.001f;

    private bool opened = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //Physics.IgnoreCollision(btn.GetComponent<Collider>(), btn_base.GetComponent<Collider>());

            if (!opened)
            {
                StartCoroutine(Opener(top_pipe, 1)); StartCoroutine(Opener(bottom_pipe, 2));
            }
        }
    }
    IEnumerator Opener(GameObject pipe, int side)
    {
        float pipe_pos = pipe.transform.position.y;
        opened = true;

        //while (   ((pipe.transform.position.y < pipe_pos + pipe_offset) && side == 1) || ((pipe.transform.position.y > pipe_pos - pipe_offset) && side == 2)     )
        while ((pipe.transform.position.y > pipe_pos - pipe_offset) && side == 2)
        {
            pipe.transform.position = new Vector3(pipe.transform.position.x, pipe.transform.position.y - step, pipe.transform.position.z);
            yield return new WaitForSeconds(0.01f);
        }

        while ((pipe.transform.position.y < pipe_pos + pipe_offset) && side == 1)
        {
            pipe.transform.position = new Vector3(pipe.transform.position.x, pipe.transform.position.y + step, pipe.transform.position.z);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
