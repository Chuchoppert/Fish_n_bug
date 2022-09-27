using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activaciones : MonoBehaviour
{
    public Activadores WhatActivate; //Que va hacer la plataforma
    public GameObject Objuno;
    public GameObject Objdos;

    public Platf_Activables Plataforma_Secundaria;

    public void DoAccion()
    {
        switch (WhatActivate)
        {
            case Activadores.Blue: //Abierto
                Objuno.transform.localPosition = new Vector3(Objuno.transform.localPosition.x, Objuno.transform.localPosition.y, -0.791f);
                Objdos.transform.localPosition = new Vector3(Objdos.transform.localPosition.x, Objdos.transform.localPosition.y, 1.035f);
                break;
            case Activadores.Gold: //Abierto
                Objuno.transform.localPosition = new Vector3(Objuno.transform.localPosition.x, Objuno.transform.localPosition.y, -1.721f);
                Objdos.transform.localPosition = new Vector3(Objdos.transform.localPosition.x, Objdos.transform.localPosition.y, 1.787f);

                //Bloqueo plataforma azul
                if(Plataforma_Secundaria != null)
                {
                    Plataforma_Secundaria.TagWhoCanActivate = NameTags.NoOne;
                    Plataforma_Secundaria._howToActivate = HowToActivate.NoActivable;

                    Plataforma_Secundaria.RefreshPlatStatus(false);
                }
                break;
            case Activadores.Pink: //Levantado
                Objuno.transform.localScale = new Vector3(Objuno.transform.localScale.x, Objuno.transform.localScale.y, 406.188f);
                break;
            case Activadores.Green: //Abierto
                Objuno.transform.localPosition = new Vector3(Objuno.transform.localPosition.x, Objuno.transform.localPosition.y, 3.85f);
                Objdos.transform.localPosition = new Vector3(Objdos.transform.localPosition.x, Objdos.transform.localPosition.y, -3.488f);
                break;
            case Activadores.Orange: //Levantado
                Objuno.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
                break;
        }
    }

    public void DeshasAccion()
    {
        switch (WhatActivate)
        {
            case Activadores.Blue: //Cerrado
                Objuno.transform.localPosition = new Vector3(Objuno.transform.localPosition.x, Objuno.transform.localPosition.y, -0.537f);
                Objdos.transform.localPosition = new Vector3(Objdos.transform.localPosition.x, Objdos.transform.localPosition.y, 0.935f);
                break;
            case Activadores.Gold: //Cerrado
                Objuno.transform.localPosition = new Vector3(Objuno.transform.localPosition.x, Objuno.transform.localPosition.y, 0.74f);
                Objdos.transform.localPosition = new Vector3(Objdos.transform.localPosition.x, Objdos.transform.localPosition.y, -0.732f);
                break;
            case Activadores.Pink: //Bajado
                Objuno.transform.localScale = new Vector3(Objuno.transform.localScale.x, Objuno.transform.localScale.y, -1.91f);
                break;
            case Activadores.Green: //Cerrado
                Objuno.transform.localPosition = new Vector3(Objuno.transform.localPosition.x, Objuno.transform.localPosition.y, 1.2054f);
                Objdos.transform.localPosition = new Vector3(Objdos.transform.localPosition.x, Objdos.transform.localPosition.y, -1.2724f);
                break;
            case Activadores.Orange: //Bajado
                Objuno.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 332.829987f));
                break;
        }
    }
}

public enum Activadores
{
    Blue,
    Gold,
    Pink,
    Green,
    Orange
}
