using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabAndDrag : MonoBehaviour
{
    public GameObject padre;
    public GameObject movedor;
    public GameObject bugGO;

    public bool IsGrabing = false;

    public bool isBugParent;

    private void OnTriggerStay(Collider other)
    {
        //if (other.gameObject.CompareTag("Player"))
        if (other.gameObject.tag =="Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (IsGrabing == false)
                {
                    Debug.Log("GOLA");
                    this.padre.transform.parent = movedor.transform;

                    IsGrabing = true;
                }
                else if (IsGrabing == true)
                {
                    Debug.Log("AGIOS");
                    this.padre.transform.parent = null;

                    IsGrabing = false;
                }
            }
        }      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bug"))
        {
            if (isBugParent == false)
            {
                this.bugGO.transform.parent = this.transform.parent;

                isBugParent = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Bug"))
        {
            if (isBugParent == true)
            {
                this.bugGO.transform.parent = null;

                isBugParent = false;
            }
        }
    }
}
