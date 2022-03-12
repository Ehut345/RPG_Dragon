using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbarainCharacterController : MonoBehaviour
{
    public Animator anim;
    public float barbarbianSpeed;
    Vector3 movedirection = Vector3.zero;
    float horizontalX, verticalY;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    //anim.SetBool("walk", true);
        //}
        //else if (Input.GetKeyDown(KeyCode.R))
        //{
        //    //anim.SetBool("walk", false);
        //    //anim.SetBool("run", true);
        //}
    }
    void FixedUpdate()
    {
        horizontalX = Input.GetAxis("Horizontal");
        verticalY = Input.GetAxis("Vertical");
        barbarbianSpeed = new Vector2(horizontalX, verticalY).sqrMagnitude;
        anim.SetFloat("walk", barbarbianSpeed);//the cahracter need to walk if ther value is > 0 
        anim.SetFloat("Horizontal", horizontalX);//the character need to walk fast if the value is > 0.5
        anim.SetFloat("Vertical", verticalY);//the character need to run if the value is > 1
    }
}
