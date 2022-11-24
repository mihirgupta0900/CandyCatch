using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyBallOnCollision : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        GameStatus.score += 1;
        scoreText.text = GameStatus.score.ToString();
    }

    private void Start()
    {
        GameStatus.score = 0;
    }
}
