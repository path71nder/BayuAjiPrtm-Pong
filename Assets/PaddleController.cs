using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        ObjectMovement(GetInput());
    }

    private Vector2 GetInput(){

        if (Input.GetKey(upKey)){
            // Ke Atas
            return Vector2.up * speed;
        }

        else if (Input.GetKey(downKey)){
            // Ke Bawah
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void ObjectMovement(Vector2 movement){
        // Menggerakkan Objek
        rig.velocity = movement;
    }
}
