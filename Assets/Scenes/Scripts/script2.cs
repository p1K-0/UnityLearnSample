using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2 : SampleScript
{
    [SerializeField]
    private float RotationSpeed;
    [SerializeField]
    private Quaternion RotationAngle;

    private Quaternion defaultState;
    // Start is called before the first frame update
    void Start()
    {
        defaultState = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {

    }

    [ContextMenu("Запустить")]
    public override void Use()
    {
        StopAllCoroutines();
        StartCoroutine(RotateCoroutine());
    }

    private IEnumerator RotateCoroutine()
    {
        Quaternion start = transform.rotation;
        var time = RotationSpeed / System.Math.Max(System.Math.Max(RotationAngle.eulerAngles.x, RotationAngle.eulerAngles.y), RotationAngle.eulerAngles.z);

        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime * time;
            transform.rotation = Quaternion.Lerp(start, start * RotationAngle, t);
            yield return null;
        }
        transform.rotation = start * RotationAngle;
    }

    [ContextMenu("Восстановить")]
    public void Reset()
    {
        StopAllCoroutines();
        transform.rotation = defaultState;
    }
}
