using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    private int score;
    private void OnTriggerEnter(Collider other)
    {
        //insert code that adds to counter
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (score > 3)
        {
            SceneManager.LoadScene(4);
        }
    }
}
