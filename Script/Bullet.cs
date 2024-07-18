using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    //public GameObject bullet;
    //Rigidbody2D rb;
    //Vector3 lastVelocity;

    
    
    // Start is called before the first frame update
    void Start()
    {
        //rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //lastVelocity= rb.velocity;  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //print("OnTriggerEnter2D   ---->  " + collision.gameObject.tag);

        

        /*if (collision.gameObject.tag == "Finish") return;

        collision.gameObject.tag = "Finish";*/

       /* Animator anim = collision.gameObject.GetComponent<Animator>();
        anim.SetTrigger("ZombieKilled");*/

        //Destroy(collision.gameObject,2);

       /* GameObject[] respawns = GameObject.FindGameObjectsWithTag("Player");
        print("length --->" + respawns.Length);
        if (respawns.Length <= 0 )
        {
            Invoke("gameover",3);
        }*/

    }

    /*private void gameover()
    {
        int level = PlayerPrefs.GetInt("level");
        PlayerPrefs.SetInt("level", level + 1);
        SceneManager.LoadScene("Gameover");
    }*/
    //int ctn = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {

       /* print("OnCollisionEnter2D   ---->  " + collision.gameObject.tag);

        Vector2 reflact = Vector2.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
        var angle = Mathf.Atan2(reflact.y, reflact.x) * Mathf.Rad2Deg;
        rb.rotation = angle + 90;

        var bulletspeed = lastVelocity.magnitude;
        rb.velocity = reflact * bulletspeed;

        rb.freezeRotation = true;

        ctn++;
        if (ctn == 5)
        {
            Destroy(gameObject);


            {
                SceneManager.LoadScene("Retry");
            }

        }*/

    }
}
