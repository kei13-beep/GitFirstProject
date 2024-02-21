using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHandler : MonoBehaviour
{
    public Animator charAnimator;
    void Start()
    {
        print("start jalan!");
        charAnimator = GetComponent<Animator>();
    }

    void AttackNow()
    {
        charAnimator.SetTrigger("goAttack");
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print ("spasi kepencet!");
            AttackNow();
        }
    }
}
