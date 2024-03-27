using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score = 0;
    public TextMeshProUGUI textMeshProUGUI;
    private void Awake()
    {
        Instance = this;
    }
    public void UpdateScore ()
    {
        score++;
        textMeshProUGUI.text = $"Hits: {score}";
    }
}
