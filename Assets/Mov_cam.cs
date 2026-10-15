using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_cam : MonoBehaviour
{
    public GameObject follow;
    public Vector2 min_cam_pos, max_cam_pos;
    public float smoothTime;
    private Vector2 velocity;

    void Start()
    {
    }
    
    void FixedUpdate()
    {
        float pos_x = Mathf.SmoothDamp(transform.position.x,
            follow.transform.position.x,
            ref velocity.x, smoothTime);

        transform.position = new Vector3(
            Mathf.Clamp(pos_x, min_cam_pos.x, max_cam_pos.x),
            transform.position.y, transform.position.z);
    }
}
