
using UnityEngine;

public class Fox : MonoBehaviour
{

    public int speed = 50;
    public float jump = 50;
    public string foxName = "玩家";
    public bool pass = false;

    private Rigidbody2D r2d;
    private Transform tran;

    private void Start()
    {
        tran = GetComponent<Transform>();
        r2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) tran.eulerAngles = new Vector3(0, 0, 0);
        if (Input.GetKeyDown(KeyCode.A)) tran.eulerAngles = new Vector3(0, 180, 0);
    }

    private void FixedUpdate()
    {
        r2d.AddForce(new Vector2(speed * Input.GetAxis("Horizontal"), 0));
    }

}
