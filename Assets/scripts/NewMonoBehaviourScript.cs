using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour

{
    [SerializeField] private Vector3 intialVelocity = new Vector3(0f, 8f, 0f);
    private Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        rb.linearVelocity = intialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
