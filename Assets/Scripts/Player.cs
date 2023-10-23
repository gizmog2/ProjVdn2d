using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] Health health;
    [SerializeField] int ForcePover;
    public float Force; // Add force amount
    public Rigidbody2D PlayerObject; // Player Object

    private void FixedUpdate()
    {
        
    }

    private void Update()
    {
        // Check keyboard keys
        
        if (Input.GetKey(KeyCode.Space))
        {
            AddForceToPlayer(new Vector2(0, Force * ForcePover)); // Move to up
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            AddForceToPlayer(new Vector2(-Force, 0)); // Move to left
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            AddForceToPlayer(new Vector2(Force, 0)); // Move to right
        }

    }
    
    private void AddForceToPlayer(Vector2 force)
    {
        if(health.GetHealth() <= 0)
        {
            return;
        }
        PlayerObject.AddForce(force); // Add force to player
        health.DecreaseHealth();
    }
}
