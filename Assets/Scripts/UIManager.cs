using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text pointsText;

    public void UpdatePoints(int points)
    {
        pointsText.text = $"Points: {points.ToString()}";
    }

}
