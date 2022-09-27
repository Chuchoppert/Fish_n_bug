using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wiiner : MonoBehaviour
{
    public bool isReadyBug;
    public bool isReadyFish;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bug")
        {
            isReadyBug = true;
        }
        if(other.gameObject.tag == "Player")
        {
            isReadyFish = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Bug")
        {
            isReadyBug = false;
        }
        if (other.gameObject.tag == "Player")
        {
            isReadyFish = false;
        }
    }

    private void Update()
    {
        if(isReadyBug && isReadyFish)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
