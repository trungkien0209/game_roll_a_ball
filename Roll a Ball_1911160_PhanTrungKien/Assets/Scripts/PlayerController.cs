using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public Text countText;
    public Text winText;
    private int count;
    public AudioSource audio;
    public AudioSource audioWin;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setText();
        winText.text = "";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            setText();
            audio.Play();
        }
    }

    void setText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 12)
        {
            winText.text = "You win!!";
            audioWin.Play();
        }
    }
}
