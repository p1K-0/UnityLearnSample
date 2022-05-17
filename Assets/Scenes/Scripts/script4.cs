using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script4 : SampleScript
{
    [SerializeField]
    private float changeSpeed;
    [SerializeField]
    private Transform myTransform;

    private IEnumerator ScaleCoroutine(Transform transform)
    {
        Vector3 start = transform.lossyScale;
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime * changeSpeed;
            transform.localScale = Vector3.Lerp(start, Vector3.zero, t);
            yield return null;
        }
        Destroy(transform.gameObject);
    }
    [ContextMenu("Запустить")]
    public override void Use()
    {
        StopAllCoroutines();
        for (int i = 0; i < myTransform.childCount; i++)
            StartCoroutine(ScaleCoroutine(myTransform.GetChild(i)));
    }
}
