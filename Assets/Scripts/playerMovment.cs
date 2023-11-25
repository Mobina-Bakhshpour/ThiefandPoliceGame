
using UnityEngine;

public class playerMovment : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotationSpeed;
    bool gameover = false;
    Rigidbody2D rb;
    Camera cam;
    Transform thief ;

    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent <Rigidbody2D> ();
    cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
     if (!gameover) {
            if (Input.GetKey (KeyCode.RightArrow))
            {
                 //transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime);
                 transform.Translate((transform.position + new Vector3(1f, 0f, 0f)) *  Time.deltaTime);


            }
             else if (Input.GetKey (KeyCode.LeftArrow))
             {
                 //transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
                   transform.Translate((-transform.position + new Vector3(1f, 0f, 0f)) *  Time.deltaTime);
             }
             
   }   
    }
     void FixedUpdate() {
//Due to the use of background scrolling, there is no need to code the player's movement in the X-axis and follow the player with the camera
//     if (!gameover)
//     rb.AddRelativeForce(new Vector3(moveSpeed*Time.FixedDeltaTime,0f,0f));
 }
 void LateUpdate() {
//Due to the use of background scrolling, there is no need to code the player's movement in the X-axis and follow the player with the camera
//     if(!gameover) {
//         cam.transform.position = new Vector3(transform.position.x,transform.position.y,cam.transform.position.z);
//     }
 }
}
