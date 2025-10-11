using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Geo_Controller : MonoBehaviour
{
    int variable1 = 3;
    private Rigidbody2D rb;
    public int speed = 5;
    public string nextlevel = "Scene_2";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        {
            Debug.Log(collision.tag);
        }
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                { 
                    SceneManager.LoadScene(nextlevel);
                    break;
                }
        }
    }

    // Update is called once per frame

    void Update ()
    {

        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2 (xInput*speed,rb.velocity.y);
        }
        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        */
    }
