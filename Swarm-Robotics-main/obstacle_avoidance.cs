using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_avoidance : MonoBehaviour
{
    public Transform robo_pose,goal_pose, ob1, ob2, ob3,ob4,ob5,ob6,ob7,ob8,ob9,ob10,ob11,ob12,ob13;
    public Transform cam;
    Vector3 offset = new Vector3(0f, 10f, -20f);
    float ka = 0.03f;  float kr = 200000f;
    float d0 = 42f; float alpha = 0.03f; // d0 is the influence of radius
    Vector3 d, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13;
    Vector3 fnet, f, f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13;
    void Start()
    {
       // transform.position =[1, 1, 1];
        //goal_pose.position =[2, 2, 2];
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = robo_pose.position;
        cam.position = transform.position + offset;
        ob5.position += new Vector3(-Mathf.Sin(ob9.position.x/1200), 0, 0);
        ob4.position += new Vector3(Mathf.Sin(ob9.position.x / 1200), 0, 0);
        ob12.position += new Vector3(Mathf.Sin(ob9.position.x / 1200), 0, 0);
        d = (goal_pose.position - robo_pose.position);          d7 = (ob7.position - robo_pose.position);
        d1 = (ob1.position - robo_pose.position);               d8 = (ob8.position - robo_pose.position);
        d2 = (ob2.position - robo_pose.position);               d9 = (ob9.position - robo_pose.position);
        d3 = (ob3.position - robo_pose.position);               d10 = (ob10.position - robo_pose.position);
        d4 = (ob4.position - robo_pose.position);               d11 = (ob11.position - robo_pose.position);
        d5 = (ob5.position - robo_pose.position);               d12 = (ob12.position - robo_pose.position);
        d6 = (ob6.position - robo_pose.position);               d13 = (ob13.position - robo_pose.position);
        if (d1.magnitude <= d0)
            f1 = kr * (1 / d1.sqrMagnitude) * (1/d1.magnitude- 1/d0) * (robo_pose.position - ob1.position) / d1.magnitude;
        else f1 = Vector3.zero;
        if (d2.magnitude <= d0)
            f2 = kr * (1 / d2.sqrMagnitude) * (1 / d2.magnitude - 1 / d0) *(robo_pose.position - ob2.position) / d2.magnitude;
        else f2 = Vector3.zero; 
        if (d3.magnitude <= d0)
            f3 = kr * (1 / d3.sqrMagnitude) * (1 / d3.magnitude - 1 / d0) *(robo_pose.position - ob3.position) / d3.magnitude;
        if (d4.magnitude <= d0)
            f4 = kr * (1 / d4.sqrMagnitude) * (1 / d4.magnitude - 1 / d0) *(robo_pose.position - ob4.position) / d4.magnitude;
        else f4 = Vector3.zero; 
        if (d5.magnitude <= d0)
            f5 = kr * (1 / d5.sqrMagnitude) * (1 / d5.magnitude - 1 / d0) *(robo_pose.position - ob5.position) / d5.magnitude;
        else f5 = Vector3.zero; 
        if (d6.magnitude <= d0)
            f6 = kr * (1 / d6.sqrMagnitude) * (1 / d6.magnitude - 1 / d0) *(robo_pose.position - ob6.position) / d6.magnitude;
        else f6 = Vector3.zero;
        if (d7.magnitude <= d0)
            f7 = kr * (1 / d7.sqrMagnitude) * (1 / d7.magnitude - 1 / d0) *(robo_pose.position - ob7.position) / d7.magnitude;
        else f7 = Vector3.zero; 
        if (d8.magnitude <= d0)
            f8 = kr * (1 / d8.sqrMagnitude) * (1 / d8.magnitude - 1 / d0) *(robo_pose.position - ob8.position) / d8.magnitude;
        else f8 = Vector3.zero; 
        if (d9.magnitude <= d0)
            f9 = kr * (1 / d9.sqrMagnitude) * (1 / d9.magnitude - 1 / d0) *(robo_pose.position - ob9.position) / d9.magnitude;
        else f9 = Vector3.zero;
        if (d10.magnitude <= d0)
            f10 = kr * (1 / d10.sqrMagnitude) * (1 / d10.magnitude - 1 / d0) *(robo_pose.position - ob10.position) / d10.magnitude;
        else f10 = Vector3.zero;
        if (d11.magnitude <= d0)
            f11 = kr * (1 / d11.sqrMagnitude) * (1 / d11.magnitude - 1 / d0) *(robo_pose.position - ob11.position) / d11.magnitude;
        else f11 = Vector3.zero;
        if (d12.magnitude <= d0)
            f12 = kr * (1 / d12.sqrMagnitude) * (1 / d12.magnitude - 1 / d0) *(robo_pose.position - ob12.position) / d12.magnitude;
        else f12 = Vector3.zero;
        if (d13.magnitude <= d0)
            f13 = kr * (1 / d13.sqrMagnitude) * (1 / d13.magnitude - 1 / d0) *(robo_pose.position - ob13.position) / d13.magnitude;
        else f13 = Vector3.zero;
        f = ka * d;
        if (d.magnitude >= 25)
            fnet = f + f1 + f2 + f3 + f4 + f5 + f6 + f7 + f8 + f9 + f10 + f11 + f12 + f13 + new Vector3(0.9f*Random.value,0f,0.9f*Random.value);
        else fnet = f;
        if (fnet.magnitude >= 0.07)
            robo_pose.position += alpha * fnet / fnet.magnitude;
        else robo_pose.position += alpha * Vector3.right;
        
        //robo_pose.position.y =0;
        Debug.Log(d.magnitude);

    }
}
