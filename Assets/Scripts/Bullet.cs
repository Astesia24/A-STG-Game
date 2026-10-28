using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    public float SSpeed;
    public float CurSpeed;
    

    public float OriHp;
    public float CurHp;
    public float Sdamage;
    public float Curdamage;
    public Rigidbody2D rb;
    protected Vector2 StartDir;
    protected Vector2 CurrentDir;
    

    // Start is called before the first frame update
    public virtual void Awake()
    {
        
        rb = GetComponent<Rigidbody2D>();
        
    }
    
    
    
    public virtual void Start()
    {
        StartDir = -((Vector2)transform.position - (Vector2)Player.Instance.transform.position).normalized;
    }
    
    // Update is called once per frame
    public virtual void FixedUpdate()
    {
        CurrentDir = -((Vector2)transform.position - (Vector2)Player.Instance.transform.position).normalized;
    }
    public virtual void Spawn()
    {
        if (rb != null)
        {
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0f; // 防止子弹疯狂自转
        }
        CurHp = OriHp;
        CurSpeed = SSpeed;
        StartDir = -((Vector2)transform.position - (Vector2)Player.Instance.transform.position).normalized;
    }
    public virtual void Die()
    {
        
        ObjectPoolManager.Instance?.ReturnOne(gameObject);
        if (rb != null)
        {
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0f; // 防止子弹疯狂自转
        }
        gameObject.SetActive(false);
    }
    
    
}
