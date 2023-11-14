using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform axis;
    [SerializeField] private Floor floorPrefab;

    [Header("Settings")]
    [SerializeField] private int defaultFloorAmount;
    [SerializeField] private float floorHeight;    
    [SerializeField] private int amountEmptySegment;
    [SerializeField] private int minTrapSegment;
    [SerializeField] private int maxTrapSegment;

    private float floorAmaunt = 0;
    public float FloorAmaunt => floorAmaunt;


    private float lastFloorY = 0;
    public float LastFloorY => lastFloorY;


    public void Generate(int level)
    {
        DestrouChild();

        floorAmaunt = defaultFloorAmount + level;

        axis.transform.localScale = new Vector3(1, floorAmaunt * floorHeight + floorHeight, 1);

        for(int i = 0; i < floorAmaunt; i++)
        {
            Floor floor = Instantiate(floorPrefab, transform);
            floor.transform.Translate(0, i * floorHeight, 0);
            floor.name = "Floor" + i;



            if(i == 0)
            {
                floor.SetFinishAllSegment();
            }

            if (i > 0 && i < floorAmaunt - 1)
            {
                floor.SetRandomRoration();
                floor.AddEmptySegment(amountEmptySegment);
                floor.AddRandomTrapSegment( Random.Range(minTrapSegment, maxTrapSegment + 1) );
            }

            if (i == floorAmaunt - 1)
            {
                floor.AddEmptySegment(amountEmptySegment);
                lastFloorY = floor.transform.position.y;
            }

        }
    }

    private void DestrouChild()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            if ( transform.GetChild(i) == axis ) continue;
            Destroy(transform.GetChild(i).gameObject);
        }
    }

}
