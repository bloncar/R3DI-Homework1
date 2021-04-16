using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CollectableType
{
    Silver, 
    Gold
}

public class CoinController : MonoBehaviour
{
    [SerializeField]
    private CollectableType type = CollectableType.Gold;

    [SerializeField]
    private float rotationSpeed = 60;

    private void Start()
    {
        GetComponent<Renderer>().material.color = GetColor();
    }

    private void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.World);
    }

    public int GetPoints()
    {
        switch (type)
        {
            case CollectableType.Silver:
                return 1;
            case CollectableType.Gold:
                return 5;
        }
        return 0;
    }

    public Color GetColor()
    {
        switch (type)
        {
            case CollectableType.Silver:
                return Color.gray;
            case CollectableType.Gold:
                return Color.yellow;
        }
        return Color.grey;
    }

}
