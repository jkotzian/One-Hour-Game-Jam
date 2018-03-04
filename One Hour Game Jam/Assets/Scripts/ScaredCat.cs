using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaredCat : MonoBehaviour {
    public Transform target;
    float speed = 3.0f;
    Vector2 mouse_pos;
    public Transform move_to_obj;
    public Transform mouse_obj;
	// Use this for initialization
	void Start () {
        //Instantiate(mouse_obj, new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition)));
	}
	
	// Update is called once per frame
	void Update () {
        // Mouse stuff
        mouse_obj.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
        float step = speed * Time.deltaTime;
        mouse_pos = Input.mousePosition;
        
        // Get the vector between the mouse and the cat
        Vector2 mouse_cat_vec = (Vector2) transform.position - (Vector2) mouse_obj.position;
        float mouse_cat_distance = mouse_cat_vec.magnitude;
        float mag = mouse_cat_vec.magnitude;
        Vector2 move_to_position = (Vector2) transform.position + mouse_cat_vec;
        move_to_obj.position = new Vector3(move_to_position.x, move_to_position.y, -.1f);
        transform.position = Vector3.MoveTowards(transform.position, move_to_obj.position, step);
    }


}
