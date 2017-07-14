using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {
    private Vector3 target;
    private GameObject[] GameOverMenu;

    // Use this for initialization
    void Start()
    {    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.Find("ThirdPersonController").transform.position;
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, .1f);
        }
        
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ThirdPersonController")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
