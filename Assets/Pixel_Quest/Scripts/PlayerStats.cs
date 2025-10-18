using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaeyerStats : MonoBehaviour
{
    public string nextlevel = "Scene_2";

    private void OnTriggerEnter2D(Collider2D collision) {
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
}
