using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // The speed of the ball.
    public float Speed = 10;

    public TextMeshProUGUI countText;

    public GameObject winTextObject;

    // A reference to the ball's RigitBody component.
    private Rigidbody body;

    private int count;

    // Start is called before the first frame update.
    void Start()
    {
        body = GetComponent<Rigidbody>();
        count = 0;
        winTextObject.SetActive(false);
        SetCountText();
       
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winTextObject.SetActive(true);
        }
    }

    // FixedUpdate is called before each step in the physics engine.
    private void FixedUpdate()
    {
        float horizontalForce = Input.GetAxis("Horizontal") * Speed;
        float verticalForce = Input.GetAxis("Vertical") * Speed;
        body.AddForce(new Vector3(horizontalForce, 0, verticalForce));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }   
    }
}