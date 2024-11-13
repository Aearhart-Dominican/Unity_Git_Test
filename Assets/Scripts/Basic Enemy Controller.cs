using UnityEngine;

public class BasicEnemyController : MonoBehaviour
{
    public Transform _target;

    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, _target.position, speed * Time.deltaTime);
    }
}
