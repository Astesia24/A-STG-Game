using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    [SerializeField]private float _hp;
    public float Hp
    {
        get
        { return _hp; }
        set
        {
            if(value<0)
            {
                value=0;
            }
            _hp = value;
        }
    }
    public float speed;
    StateMachine playermachine;
    public Rigidbody2D rb;
    public Animator animator;
    
    
    public NormalState normalState;
    public SlowState slowState;
    public BigState bigState;


    public Vector2 playerInput;
    public Vector2 direction;
    void Awake()
    {
         Instance = this;
        



        rb = GetComponent<Rigidbody2D>();
        if(rb==null)
        {
            Debug.Log("666不挂rigidbody的来了");
        }
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.Log("666我动画组件呢，没挂嘛");
        }
        playermachine = new StateMachine(this);
        
        playerInput = Vector2.zero;



        normalState = new NormalState(this, playermachine);
        slowState = new SlowState(this, playermachine);
        bigState = new BigState(this, playermachine);

    }
    void Start()
    {
        Hp = 100;
        //等会儿来改
        playermachine.Initialize(normalState);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        direction = Vector2.ClampMagnitude(playerInput, 1f);
       




        playermachine.Update();
     
        




    }
    
}
