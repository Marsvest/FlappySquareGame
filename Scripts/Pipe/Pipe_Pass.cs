using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Pass : MonoBehaviour
{
    private bool passed = false;
    private Counter_Logic counter_script;
    // Start is called before the first frame update
    void Start()
    {
        counter_script = GameObject.Find("Score_Label").GetComponent<Counter_Logic>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger && !passed)
        {
            counter_script.Increase_Score();
            passed = true;
        }

    }
}
