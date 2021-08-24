using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{

    Rigidbody2D birdRB;
    [SerializeField]
    float birdSpeed;

    int angle;
    int minAngle=-90;
    int maxAngle=20;
    Score scorer;
    bool touchedGround;
    public GameManager1 gameManager;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        birdRB = GetComponent<Rigidbody2D>();
        scorer = GameObject.Find("ScoreManager").GetComponent<Score>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameManager1.gameOver==false && GameManager1.gameIsPaused==false)
        {
            birdRB.velocity = Vector2.zero;
            birdRB.velocity = new Vector2(birdRB.velocity.x, birdSpeed);
        }
        BirdRotation();  
    }

    void BirdRotation()
    {
        if (birdRB.velocity.y > 0)
        {
            if (angle <= maxAngle)
            {
                angle = angle + 5;
            }
        }
        else if (birdRB.velocity.y < 0)
        {
            if (angle >= minAngle)
            {
                angle = angle - 5;
            }
        }
        if(touchedGround==false)
        {
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
        

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            scorer.ScoreIncrement();
        }
        else if(collision.gameObject.CompareTag("Pipe"))
        {
            Debug.Log("PIPE");
            gameManager.GameOver();
            BirdDied();

        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            if(GameManager1.gameOver==false)
            {
                // game over
                Debug.Log("GROUND");
                gameManager.GameOver();
                BirdDied();

            }
            else 
            {
                BirdDied();
               
            }
        }
    }

    void   BirdDied()
    {
        touchedGround = true;
        anim.enabled = false;
    }
}
