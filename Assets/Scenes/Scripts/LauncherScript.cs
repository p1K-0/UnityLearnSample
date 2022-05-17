using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    [ContextMenu("Запустить все")]
    void UseAll()
    {
        GameObject.Find("TestCube1").GetComponent<script1>().Use();
        GameObject.Find("TestCube2").GetComponent<script2>().Use();
        GameObject.Find("TestCube3").GetComponent<script3>().Use();
        GameObject.Find("TestCube4").GetComponent<script4>().Use();
    }
    [ContextMenu("Восстановить все")]
    void ResetAll()
    {
        //GameObject.Find("Sofa").GetComponent<zaxscdaScript>().Reset();
    }
}
