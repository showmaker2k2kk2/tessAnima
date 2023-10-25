using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.AI;

public class plyer : MonoBehaviour
{
    public Transform point;
    public GameObject bulet;
    public float Force;

    Bulllet bu;

   NavMeshAgent agent;
    public float speed;
    public float speedRo;
    Animator anim;
    Rigidbody rb;
    CharacterController characterController;
    float ho;
    float ve;
   



    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        ho = Input.GetAxis("Horizontal");
        ve = Input.GetAxis("Vertical");
        Vector3 Movedir = new Vector3(ho, 0, ve);

        if (Movedir != Vector3.zero)
        {

            Move(Movedir);
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }    
        
    }
    void Move(Vector3 dir)
    {
        Rotation(dir);
       
        agent.Move(transform.forward* speed * Time.deltaTime);
       

    }    

    void Rotation(Vector3 huong)

    {
        Quaternion huongx = Quaternion.LookRotation(huong, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, huongx, speedRo * Time.deltaTime);

    }

}


