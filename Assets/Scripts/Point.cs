using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    [SerializeField] Text pointText;

    int points = 0;

    private void Awake()
    {
        UpdateHud();
    }
    public int Points
    {
        get { return points; }

        set
        {
            points = value;
            UpdateHud();
        }


    }

    private void UpdateHud()
    {
        pointText.text = points.ToString();
    }
}
