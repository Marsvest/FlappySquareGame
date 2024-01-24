using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_Logic : MonoBehaviour
{
    public bool game_state = false;
    public GameObject canvas;
    public GameObject score_label;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Start_level()
    {
        canvas.SetActive(false);
        player.SetActive(true);
        score_label.transform.localScale = new Vector3(1,1,0);

        game_state = true;
    }
}
