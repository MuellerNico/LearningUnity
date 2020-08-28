using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public Canvas gameOverScreen;
    public Text scoreText;
    public Text finalScoreText;
    public Transform player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle"){
            movement.enabled = false;
            gameOverScreen.enabled = true;
            scoreText.enabled = false;
            finalScoreText.text = "FINAL SCORE\n" + player.position.z.ToString("0");

        }
    }
}