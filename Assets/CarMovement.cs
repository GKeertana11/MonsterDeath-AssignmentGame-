using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CarMovement : MonoBehaviour
{
    public float playerSpeed;
    Rigidbody2D rb;
    public GameObject player;
    public float jumpForce;
    SpriteRenderer sprite;
    public GameObject Fireball;
    public int score;
    public Text scoreText;
    public Text GameWon;
    public Text GameOver;
    public bool istrue=false;

    // Start is called before the first frame update
    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
        sprite = player.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (istrue == false)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position = transform.position + Vector3.right * playerSpeed * Time.deltaTime;
                sprite.flipX = false;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                sprite.flipX = true;
                transform.position = transform.position + Vector3.left * playerSpeed * Time.deltaTime;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.AddForce(Vector3.up * jumpForce);
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Gem")
        {
            Destroy(collision.gameObject);
            score = score + 10;
            scoreText.text=score.ToString();
        }
        if (collision.gameObject.tag == "Potion")
        {
            Destroy(collision.gameObject);
            GameWon.GetComponent<Text>().enabled = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


        
        }
        if (collision.gameObject.tag == "Monster")
        {
            Destroy(collision.gameObject);
            GameOver.GetComponent<Text>().enabled = true;
            player.GetComponent<Animator>().enabled = false;
            istrue = true;

        }
    }
}
