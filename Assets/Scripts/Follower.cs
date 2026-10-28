using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Follower : MonoBehaviour
{
    //环绕旋转相关参数
    [SerializeField]protected float theta;
    [SerializeField]protected float w;
    protected Vector2 offset = Vector2.zero;
    [SerializeField]protected float radius;
    protected Rigidbody2D rb;
    
    //旋转中心
    protected Transform center;
    protected Rigidbody2D centerRb;
    // Start is called before the first frame update
    protected virtual void Awake()
    {
        
    }
    
    
    
    protected virtual void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        
        
        
        centerRb = center.GetComponent<Rigidbody2D>();
        
        theta = theta *Mathf.Deg2Rad;
    }

    // Update is called once per frame
    protected virtual void FixedUpdate()
    {
        //旋转逻辑
        theta += Time.deltaTime * w;
        offset = new Vector2(radius * Mathf.Cos(theta), radius * Mathf.Sin(theta));
        
        rb.MovePosition((Vector2)center.position+offset);
        


    }
    
}
