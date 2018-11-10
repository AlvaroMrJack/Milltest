using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockMoveVar : MonoBehaviour {

    public GameObject lockValue;
    public GameObject millGUI;

    public void setValue()
    {
        lockValue.name = "False";
        millGUI.SetActive(false);
    }

}
