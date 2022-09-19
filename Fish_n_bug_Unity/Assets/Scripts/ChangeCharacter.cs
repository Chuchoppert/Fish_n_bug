using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacter : MonoBehaviour
{
    [SerializeField] GameObject BigCharacter;
    [SerializeField] GameObject SmallCharacter;
    [SerializeField] Camera BigCharCam;
    [SerializeField] Camera SmallCharCam;

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (BigCharCam == Camera.main)
            {
                BigCharacter.GetComponent<TestMoving>().enabled = false;
                BigCharacter.GetComponentInChildren<Camera>().enabled = false;
                BigCharacter.GetComponentInChildren<AudioListener>().enabled = false;

                SmallCharacter.GetComponent<TestMoving>().enabled = true;
                SmallCharacter.GetComponentInChildren<Camera>().enabled = true;
                SmallCharacter.GetComponentInChildren<AudioListener>().enabled = true;

                SmallCharCam = Camera.main;
            
            }
            else
            {
                BigCharacter.GetComponent<TestMoving>().enabled = true;
                BigCharacter.GetComponentInChildren<Camera>().enabled = true;
                BigCharacter.GetComponentInChildren<AudioListener>().enabled = true;

                SmallCharacter.GetComponent<TestMoving>().enabled = false;
                SmallCharacter.GetComponentInChildren<Camera>().enabled = false;
                SmallCharacter.GetComponentInChildren<AudioListener>().enabled = false;


                BigCharCam = Camera.main;
                
            }
        }
    }
}
