using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    public GameObject Target;
    public float hidDistance = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if (!Target) gameObject.SetActive(false);
        else
        {
            var dir = Target.transform.position - transform.position;

            if (dir.magnitude < hidDistance)
            {
                SetChildrenActive(false);
            }
            else
            {
                SetChildrenActive(true);
                var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }
        }
    }

    void SetChildrenActive(bool value)
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(value);
        }
    }
}
