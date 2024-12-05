using UnityEngine;
using System.Collections;

public class bulletController : MonoBehaviour
{
    [SerializeField] float speed = 15f;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(timerDelete());
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        deleteGameobj();
    }

    IEnumerator timerDelete()
    {
        yield return new WaitForSeconds(2f);
        deleteGameobj();
    }

    void deleteGameobj()
    {
        Destroy(gameObject);
    }
}