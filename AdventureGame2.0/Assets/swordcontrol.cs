using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordcontrol : MonoBehaviour
{
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("hit", true);
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("hit", false);
                StartCoroutine(swordtime());
            }
     
    }

    IEnumerator swordtime()
    {
        yield return new WaitForSeconds(0.20F);
        animator.SetBool("hit", true);
    }
    
}
