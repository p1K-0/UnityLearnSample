using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : SampleScript
{
    [SerializeField]
    private Vector3 end;
    public float speed;

    [ContextMenu("Запустить")]
    public override void Use()
    {
        StopAllCoroutines();
        StartCoroutine(ScaleCoroutine());
    }
    private IEnumerator ScaleCoroutine()
    {
        while (gameObject.transform.position != end)
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, end, speed * Time.deltaTime);
            yield return null;
        }
    }
}