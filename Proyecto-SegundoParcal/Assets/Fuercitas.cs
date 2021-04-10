using UnityEngine;

public class Fuercitas : MonoBehaviour
{
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(10f, 0f, 0f, ForceMode.Impulse);
    }
}
