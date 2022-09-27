using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject followPrefab;

    private void Update()
    {
        this.gameObject.transform.position = followPrefab.transform.position;
        this.gameObject.transform.rotation = followPrefab.transform.rotation;
    }
}
