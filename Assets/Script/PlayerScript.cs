
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float JumpForce;
    float SCORE;
    [SerializeField]
    bool isGrounded = false;
    Rigidbody2D RB;
    bool isAlive = true;
    public Text ScoreText;
    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        SCORE = 0;   
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            if(isGrounded == true)
            {
                RB.AddForce(Vector2.up * JumpForce);
                isGrounded = false;
            }
        }
        if(isAlive)
        {
            SCORE += Time.deltaTime * 4;
            ScoreText.text = "SCORE : " + SCORE.ToString("0");
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            if(isGrounded == false)
            {
                isGrounded = true; 
            }
        }
        if (collision.gameObject.CompareTag("spike"))
        {
            isAlive = false;
            Time.timeScale = 0;
        }

    }
}
