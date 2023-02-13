
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerClooission : MonoBehaviour
{
    public playerMovement movement;
    public SCORE score;
    public float restartdelay = 2f;
    public GameObject endScreen;
    public GameObject BOARD;


    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            score.enabled = false;
            endScreen.SetActive(true);
            BOARD.SetActive(false);




        }
    }
}
