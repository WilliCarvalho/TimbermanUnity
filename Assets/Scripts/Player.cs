using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //private float xStart;
    //private float xEnd;
    //private string currentSide;
    private Animator _animator;
    private SpriteRenderer sprite;
    private float positionX;
    private bool canAnimate;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        positionX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        Swipe();
    }

    void Swipe()
    {
        

        if (Input.GetButtonDown("Fire1"))
        {
            if(Input.mousePosition.x > Screen.width / 2)
            {
                //right
                transform.position = new Vector2(-positionX, transform.position.y);
                sprite.flipX = true;
            }
            else if(Input.mousePosition.x < Screen.width / 2)
            {
                //left
                transform.position = new Vector2(positionX, transform.position.y);
                sprite.flipX = false;
            }

            //Animation
            StartCoroutine(Animate());
        }

        //Another way to detect the position of the character
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    xStart = Input.mousePosition.x;            
        //}
        //else if (Input.GetButtonUp("Fire1"))
        //{
        //    xEnd = Input.mousePosition.x;

        //    if(xStart < xEnd)
        //    {
        //        transform.position = new Vector2(3f, transform.position.y);
        //    }
        //    else
        //    {
        //        transform.position = new Vector2(-3f, transform.position.y);
        //    }
        //}
    }


    IEnumerator Animate()
    {
        _animator.SetBool("pCutting", true);
        yield return new WaitForSeconds(0.35f);
        _animator.SetBool("pCutting", false);
    }
}
