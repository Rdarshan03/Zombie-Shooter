using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public GameObject Target;
    public GameObject bulletprefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Target.transform.position = new Vector3(mousepos.x,mousepos.y);  

        var offset = mousepos - transform.position;

        var angle = Mathf.Atan2(offset.y,offset.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        if(Input.GetMouseButtonDown(0))
        {
            bullet(angle);
            
        }
    }

    void bullet(float angle)
    {
        Image[] bull = GameObject.FindGameObjectWithTag("Bull").GetComponentsInChildren<Image>();
        
        if (bull.Length > 0 )
        {
            Destroy(bull[bull.Length - 1]);
            //print("Bullet" + bull);

            var bullet = Instantiate(bulletprefab, transform.position, Quaternion.Euler(0f, 0f, angle + 90));

            var mousepos = Camera.main.WorldToScreenPoint(transform.position);
            var distance = (Input.mousePosition - mousepos).normalized;
            bullet.GetComponent<Rigidbody2D>().AddForce(distance * 400);

        }
    }
}
