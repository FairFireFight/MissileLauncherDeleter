using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class missileDelete : MonoBehaviour
{
    private GameObject launcherRight;
    private GameObject launcherLeft;
    void Start()
    {
        launcherRight = GameObject.Find("MissileLauncherRight");
        launcherLeft = GameObject.Find("MissileLauncherLeft");

        if (launcherRight != null) {
            Destroy(launcherRight);
        }
        else {
            Debug.Log("launcherRight does not exist already!");
        }

        if (launcherLeft != null) {
            Destroy(launcherLeft);
        }
        else {
            Debug.Log("launcherLeft does not exist already!");
        }
    }
}
