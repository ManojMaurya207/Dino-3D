
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    void Update()
    {
        scoreText.text = player.position.z.ToString("0");

    }
}

