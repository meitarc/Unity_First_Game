using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceManScript : MonoBehaviour
{
    public int playerSpeed;
    public float forwardMovementSpeed = 3.0f;
    private bool dead = false;


    /*
    public float jetpackForce = 75.0f;
    public float forwardMovementSpeed = 3.0f;
    public Transform groundCheckTransform;
    private bool grounded;
    public LayerMask groundCheckLayerMask;
    Animator animator;
    public ParticleSystem jetpack;
    private bool dead = false;
    private uint coins = 0;
    public Texture2D coinIconTexture;
    */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float amtToMove = playerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        //transform.Translate(Vector3.right*amtToMove);
        if (GetComponent<Transform>().position.x > 9)
            transform.position= new Vector3(-8.5f, transform.position.y, transform.position.z);
        else if (GetComponent<Transform>().position.x < -9)
            transform.position = new Vector3(8.5f, transform.position.y, transform.position.z);
        else
            GetComponent<Transform>().Translate(Vector3.right * amtToMove);

        if (!dead)
        {
            Vector2 newVelocity = GetComponent<Rigidbody2D>().velocity;
            newVelocity.y = forwardMovementSpeed;
            GetComponent<Rigidbody2D>().velocity = newVelocity;
        }
        /*
                bool jetpackActive = Input.GetButton("Fire1");

                jetpackActive = jetpackActive && !dead;

                if (jetpackActive)
                {
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jetpackForce));
                }

                if (!dead)
                {
                    Vector2 newVelocity = GetComponent<Rigidbody2D>().velocity;
                    newVelocity.x = forwardMovementSpeed;
                    GetComponent<Rigidbody2D>().velocity = newVelocity;
                }

                UpdateGroundedStatus();

                AdjustJetpack(jetpackActive);

                //AdjustFootstepsAndJetpackSound(jetpackActive);

                //parallax.offset = transform.position.x;
                */
    }


    /*
        void UpdateGroundedStatus()
        {
            //1
            grounded = Physics2D.OverlapCircle(groundCheckTransform.position, 0.1f, groundCheckLayerMask);

            //2
            //animator.SetBool("grounded", grounded);
        }

        void AdjustJetpack(bool jetpackActive)
        {
            jetpack.enableEmission = !grounded;
            jetpack.emissionRate = jetpackActive ? 300.0f : 75.0f;
        }
        */
}
