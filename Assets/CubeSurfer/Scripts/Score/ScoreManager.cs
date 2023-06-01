using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public int cubeScore = 0;
    /*
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            cubeScore++;
            GetComponent<Text>().text = "Score: " + cubeScore;
        }
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            Debug.Log("Score arttýr");
            cubeScore++;
            GetComponent<Text>().text = "Score: " + cubeScore;
        }
    }
}
