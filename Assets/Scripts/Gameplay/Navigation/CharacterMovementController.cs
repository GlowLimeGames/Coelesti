using UnityEngine;

public class CharacterMovementController : MonoBehaviour 
{
    [SerializeField]
    KeyCode moveUpKey, moveDownKey, moveLeftKey, moveRightKey;

    [SerializeField]
    float speed = 1f;

	// Update is called once per frame
	void FixedUpdate() 
    {
        if(Input.GetKey(moveUpKey)) 
        {
            transform.position += Vector3.up * speed;
        }
        if(Input.GetKey(moveDownKey))
        {
            transform.position += Vector3.down * speed;
        }
        if(Input.GetKey(moveLeftKey))
        {
            transform.position += Vector3.left * speed;
        }
        if(Input.GetKey(moveRightKey))
        {
            transform.position += Vector3.right * speed;
        }
    }
}
