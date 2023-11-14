using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField] private List<Segment> defaultSegments;

    public void AddEmptySegment(int amoumt)
    {
        for(int i = 0; i < amoumt; i++)
        {
            defaultSegments[i].SetEmpty();
        }

        for (int i = amoumt; i >= 0; i--)
        {
            defaultSegments.RemoveAt(i);
        }
    }

    public void AddRandomTrapSegment(int amoumt)
    {
        for (int i = 0; i < amoumt; i++)
        {
            int index = Random.Range(0, defaultSegments.Count);

            defaultSegments[index].SetTrap();
            defaultSegments.RemoveAt(index);
        }
    }

    public void SetRandomRoration()
    {
        transform.eulerAngles = new Vector3(0, Random.Range(0, 360), 0);
    }

    public void SetFinishAllSegment()
    {
        for (int i = 0; i < defaultSegments.Count; i++)
        {
            defaultSegments[i].SetFinish();
        }
    }
}
