
using UnityEngine;

public class Fox : MonoBehaviour
{

    public int speed = 50;
    public float jump = 50;
    public string foxName = "玩家";
    public bool pass = false;
    public bool isGround;

    private Rigidbody2D r2d;
    private Transform tran;

    private void Start()
    {
        tran = GetComponent<Transform>();
        r2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) Turn(0);
        if (Input.GetKeyDown(KeyCode.A)) Turn(180);
    }

    private void FixedUpdate()
    {
        Walk();
        Jump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = true;
        Debug.Log("碰到東西" + collision.gameObject);
    }

    /// <summary>
    /// 走路
    /// </summary>
    private void Walk()
    {
        r2d.AddForce(new Vector2(speed * Input.GetAxis("Horizontal"), 0));
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            isGround = false;
            r2d.AddForce(new Vector2(0, jump));
        }
    }

    /// <summary>
    /// 轉彎
    /// </summary>
    /// <param name="direction">轉彎:左 180,右 0 </param>
    private void Turn( int direction)
    {
        tran.eulerAngles = new Vector3(0, direction, 0);
    }
}
