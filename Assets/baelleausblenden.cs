using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baelleausblenden : MonoBehaviour
{
	public GameObject anzeige;
    	public void OnEnable()
     {
         anzeige.SetActive(false);
     }
}
