using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bird : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float speed = 5f;
    bool isDead;
    [SerializeField]
    private float flapForce = 20f;
    // Start is called before the first frame update
    void Start()
    {
        

        Time.timeScale = 0;
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.right * speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) &&  !isDead)
        {
            rb2d.velocity = Vector2.right * speed * Time.deltaTime;
            rb2d.AddForce(Vector2.up * flapForce);
        }
    }
    public GameObject ReplayButton;
    void OnCollisionEnter2D(Collision2D col)
        {
            isDead = true;
            rb2d.velocity = Vector2.zero;
            ReplayButton.SetActive(true);
            GetComponent<Animator>().SetBool("isDead" , true);
            Debug.Log("collided");
        }
   public void Replay()
   {
          SceneManager.LoadScene(0);
   }
   public void UnFreeze()
   {
             Time.timeScale = 1;

   }

   
   
}
