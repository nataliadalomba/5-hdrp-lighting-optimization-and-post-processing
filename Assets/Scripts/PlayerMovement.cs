using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField] float speed = 10f;

    void Start() {
        
    }

    void Update() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        gameObject.transform.position = new Vector3(transform.position.x + (h * speed * Time.deltaTime), 0.5f, transform.position.z + (v * speed * Time.deltaTime));
    }
}
