using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibraryObjects : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("library loaded");
    }
}

public enum HowToActivate
{
    NoActivable,
    ActivableByPlayer,
    ActivableByObject
}

public enum NameTags
{
    NoOne,
    Everybody,
    Player,
    Bug,
    Red_Ob
}

public enum TypeOfPlat
{
    OneTime,
    Switcheable,
    ByTime
}
