using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter_Logic : MonoBehaviour
{
    public GameObject score_label;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Increase_Score()
    {
        score++;
        score_label.GetComponent<Text>().text = score.ToString();
    }
}
