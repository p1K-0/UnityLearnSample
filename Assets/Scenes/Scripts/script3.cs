using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script3 : SampleScript
{
    public GameObject gobj;
    [SerializeField]
    public int number;
    [SerializeField]
    public Vector3 step;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    [ContextMenu("Запустить")]
    public override void Use()
    {
        var gbjpos = gobj.transform.position;
        for (int i = 0; i < number; i++)
        {
            var step1 = new Vector3(gbjpos.x + step.x, gbjpos.y + step.y, gbjpos.z + step.z);
            gbjpos = Instantiate(gobj, step1, Quaternion.identity).transform.position;

        }
    }
}
