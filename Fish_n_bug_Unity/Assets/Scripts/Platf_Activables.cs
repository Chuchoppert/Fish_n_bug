using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platf_Activables : MonoBehaviour
{
    [Header("Basic settings")]
    public HowToActivate _howToActivate; //No activable, Player, Objetos 
    public NameTags TagWhoCanActivate;  //Tag de quien lo pueda activar

    NameTags saveTag; //Para guardar el tag con el que se va a activar en caso de que se escoga alguno de los objetos

    [Header("Settings color Active/desactivate")]
    public Color colorOn;
    public Color colorOff;

    [Header("Settings for status Plat")]
    public TypeOfPlat _TypeOfPlat;
    public float TimeToDeactivePlat;
    public bool WasActivated = false;
    public Activaciones Activaciones_SC;

    [Header("Other Settings")]
    public Vector3[] Pos; //0 = no activado, 1 = activado
    public GameObject TriggerPlat_GO;


    private void Awake()
    {
        //if(_howToActivate == HowToActivate.ActivableByObject)
        //{
            saveTag = TagWhoCanActivate;
        //}

        //RefreshPlatfTags();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(WasActivated == false)
        {
            if (other.gameObject.tag == TagWhoCanActivate.ToString() || TagWhoCanActivate == NameTags.Everybody)
            {
                Debug.Log("Activado");
                RefreshPlatStatus(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(WasActivated == true)
        {
            if (other.gameObject.tag == TagWhoCanActivate.ToString() || TagWhoCanActivate == NameTags.Everybody)
            {
                Debug.Log("Desactivado");
                RefreshPlatStatus(false);
            }
        }
    }

    public void RefreshPlatStatus(bool status)
    {
        if (status == true)
        {
            //Anim
            TriggerPlat_GO.transform.localPosition = Pos[1];

            TriggerPlat_GO.GetComponent<MeshRenderer>().material.SetColor("Color_2d523c9e87ea411c87ba7d7b977b62e7", colorOn);
            //

            Activaciones_SC.DoAccion();
            WasActivated = true;
        }
        else if (status == false)
        {
            if (_TypeOfPlat != TypeOfPlat.OneTime)
            {             
                if (_TypeOfPlat == TypeOfPlat.ByTime)
                {
                    Invoke("DeactivatePlat", TimeToDeactivePlat);
                }
                else
                {
                    DeactivatePlat();
                }
            }            
        }
    }

    void DeactivatePlat()
    {
        //Anim
        TriggerPlat_GO.transform.localPosition = Pos[0];

        TriggerPlat_GO.GetComponent<MeshRenderer>().material.SetColor("Color_2d523c9e87ea411c87ba7d7b977b62e7", colorOff);
        //

        Activaciones_SC.DeshasAccion();

        WasActivated = false;
    }

    public void RefreshPlatfTags()
    {
        /*if (_howToActivate == HowToActivate.ActivableByPlayer)
        {
            TagWhoCanActivate = NameTags.Player;
        }
        else if (_howToActivate == HowToActivate.NoActivable)
        {
            TagWhoCanActivate = NameTags.NoOne;
        }
        else
        {*/
            TagWhoCanActivate = saveTag;
        //}
    }


}


