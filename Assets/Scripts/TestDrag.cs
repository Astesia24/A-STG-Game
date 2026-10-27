using UnityEngine;

public class TestDrag : MonoBehaviour
{
    [SerializeField] protected Transform playerTransform;

    void Awake()
    {
        if (playerTransform == null)
        {
            Debug.LogError("报错：你根本没把东西拖进去！");
            return;
        }

        // 打印出来，看看你到底拖了个什么神仙进来
        Debug.Log("拖进来的物体名叫：" + playerTransform.name);
        Debug.Log("它的坐标是：" + playerTransform.position);
    }
}