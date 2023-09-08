using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public float Range;
    public Transform Target;
    bool Detected = false;
    Vector2 Direction;
    public GameObject Bow;
    public GameObject Arrow;
    public float FireRate;
    public string enemytag = "Enemy";
    float nextTimeToFire = 0;
    public Transform ShootPoint;
    public float Force;

    void Update()
    {
        Vector2 TargetPos = Target.position;

        Direction = TargetPos - (Vector2)transform.position;

        RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, Direction, Range);

        if(rayInfo)
        {
            if(rayInfo.collider.gameObject.tag == enemytag)
            {
                if(Detected == false)
                {
                    Detected = true;
                }
            }

            else
            {
                if(Detected == true)
                {
                    Detected = false;
                }
            }
        }

        if(Detected)
        {
            Bow.transform.up = Direction;
            if(Time.time > nextTimeToFire)
            {
                nextTimeToFire = Time.time+1/FireRate;
                shoot();
            }
        }
    }

    void shoot()
    {
        GameObject ArrowIns = Instantiate(Arrow, ShootPoint.position, Quaternion.identity);
        ArrowIns.GetComponent<Rigidbody2D>().AddForce(Direction * Force);
        ArrowIns.transform.Rotate(0.0f, 0.0f, Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, Range);
    }

}
