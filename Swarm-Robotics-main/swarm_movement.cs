using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swarm_movement : MonoBehaviour
{  // Start is called before the first frame update
   
    public Transform robo1_pose, robo2_pose, robo3_pose, robo4_pose, robo5_pose,cam, goal, actual_goal,sl;
    public Transform ob1_pose, ob2_pose, ob3_pose, ob4_pose, ob5_pose, ob6_pose, ob7_pose;
    Vector3 f11, f12, f13, f14, f15, f16, f17;
    Vector3 f21, f22, f23, f24, f25, f26, f27;
    Vector3 f31, f32, f33, f34, f35, f36, f37;
    Vector3 f41, f42, f43, f44, f45, f46, f47;
    Vector3 f51, f52, f53, f54, f55, f56, f57;
    Vector3 offset = new Vector3(-4, 25, -8);
    Vector3 d1g, d2g, d3g, d4g, d5g;
    float alpha = 0.05f;
    float alpha1 = 2f;
    float t = 0f;
    float r = 5f;
    //float d0 = 42f;   float kr = 10000f;

    /*void Start()
    {
         rb = this.GetComponent<Rigidbody>();   
     }*/


    // Update is called once per frame
    void Update()
    {
        Vector3 d1g = actual_goal.position - robo1_pose.position;
        Vector3 d2g = actual_goal.position - robo2_pose.position;
        Vector3 d3g = actual_goal.position - robo3_pose.position;
        Vector4 d4g = actual_goal.position - robo4_pose.position;
        Vector3 d5g = actual_goal.position - robo5_pose.position;
        Vector3 d11 = ob1_pose.position - robo1_pose.position; Vector3 d12 = ob2_pose.position - robo1_pose.position; Vector3 d13 = ob3_pose.position - robo1_pose.position;
        Vector3 d14 = ob4_pose.position - robo1_pose.position; Vector3 d15 = ob5_pose.position - robo1_pose.position; Vector3 d16 = ob6_pose.position - robo1_pose.position; Vector3 d17 = ob7_pose.position - robo1_pose.position;
        Vector3 d21 = ob1_pose.position - robo2_pose.position; Vector3 d22 = ob2_pose.position - robo2_pose.position; Vector3 d23 = ob3_pose.position - robo2_pose.position;
        Vector3 d24 = ob4_pose.position - robo2_pose.position; Vector3 d25 = ob5_pose.position - robo2_pose.position; Vector3 d26 = ob6_pose.position - robo2_pose.position; Vector3 d27 = ob7_pose.position - robo2_pose.position;
        Vector3 d31 = ob1_pose.position - robo3_pose.position; Vector3 d32 = ob2_pose.position - robo3_pose.position; Vector3 d33 = ob3_pose.position - robo3_pose.position;
        Vector3 d34 = ob4_pose.position - robo3_pose.position; Vector3 d35 = ob5_pose.position - robo3_pose.position; Vector3 d36 = ob6_pose.position - robo3_pose.position; Vector3 d37 = ob7_pose.position - robo3_pose.position;
        Vector3 d41 = ob1_pose.position - robo4_pose.position; Vector3 d42 = ob2_pose.position - robo4_pose.position; Vector3 d43 = ob3_pose.position - robo4_pose.position;
        Vector3 d44 = ob4_pose.position - robo4_pose.position; Vector3 d45 = ob5_pose.position - robo4_pose.position; Vector3 d46 = ob6_pose.position - robo4_pose.position; Vector3 d47 = ob7_pose.position - robo4_pose.position;
        Vector3 d51 = ob1_pose.position - robo5_pose.position; Vector3 d52 = ob2_pose.position - robo5_pose.position; Vector3 d53 = ob3_pose.position - robo5_pose.position;
        Vector3 d54 = ob4_pose.position - robo5_pose.position; Vector3 d55 = ob5_pose.position - robo5_pose.position; Vector3 d56 = ob6_pose.position - robo5_pose.position; Vector3 d57 = ob7_pose.position - robo5_pose.position;

        
        Vector3 f1net = force(d11, d12, d13, d14, d15, d16, d17);
        Vector3 f2net = force(d21, d22, d23, d24, d25, d26, d27);
        Vector3 f3net = force(d31, d32, d33, d44, d35, d36, d37);
        Vector3 f4net = force(d41, d42, d43, d44, d45, d46, d47);
        Vector3 f5net = force(d51, d52, d53, d54, d55, d56, d57);

        
        if (d1g.magnitude>10 && d2g.magnitude > 10 && d3g.magnitude > 10 && d4g.magnitude > 10 && d5g.magnitude > 10)
        {
            alpha += 0.001f;
            r += 0.002f;
            t += 0.0005f;
            Vector3 goal_move = new Vector3(Mathf.Sin(t), 0, Mathf.Cos(t));
            goal.position = r * goal_move;
            Vector3 d = goal.position - robo1_pose.position;
            Vector3 d1 = robo1_pose.position - robo2_pose.position;
            Vector3 d2 = robo1_pose.position - robo4_pose.position;
            Vector3 d3 = robo2_pose.position - robo3_pose.position;
            Vector3 d4 = robo4_pose.position - robo5_pose.position;
            float angle = Mathf.Atan2(d.z, d.x);
            //float angle1 = Mathf.Atan(d1.z/ d1.x);
            //float angle2 = -Mathf.Atan(d2.z / d2.x);
            //float angle3 = Mathf.Atan(d3.z / d3.x);
            //float angle4 = -Mathf.Atan(d4.z / d4.x);
            Vector3 left_form = new Vector3(6f * Mathf.Cos(5f) + 0.0f * Random.value, 0, 6f * Mathf.Sin(5f) + 0.0f * Random.value);
            Vector3 right_form = new Vector3(6f * Mathf.Cos(10f) + 0.0f * Random.value, 0, 6f * Mathf.Sin(10f) + 0.0f * Random.value);
            Vector3 left_form1 = new Vector3(6f * Mathf.Cos(5f) + 0.0f * Random.value, 0, 6f * Mathf.Sin(5f) + 0.0f * Random.value);
            Vector3 right_form1 = new Vector3(6f * Mathf.Cos(10f) + 0.0f * Random.value, 0, 6f * Mathf.Sin(10f) + 0.0f * Random.value);
            robo2_pose.position = transform.position + left_form+alpha1*f2net;
            robo3_pose.position = robo2_pose.position + left_form1 + alpha1 * f3net;
            robo4_pose.position = transform.position + right_form + alpha1 * f4net;
            robo5_pose.position = robo4_pose.position + right_form1 + alpha1 * f5net;
            transform.position += Mathf.Min(alpha,0.1f) * (d.normalized+f1net);
            transform.forward = d;
            robo2_pose.forward = d;
            robo3_pose.forward = d;
            robo4_pose.forward = d;
            robo5_pose.forward = d;
            sl.position = transform.position + offset;
            //cam.position = transform.position + offset;
            Debug.Log(f1net);
        }
        else Debug.Log("Target found");

    }
    static Vector3 force(Vector3 d1, Vector3 d2, Vector3 d3, Vector3 d4, Vector3 d5, Vector3 d6, Vector3 d7)
    {
        float d0 = 30f;
        float kr = 10000f;
        Vector3 f1, f2, f3, f4, f5, f6, f7, fnet;
        if (d1.magnitude <= d0)
            f1 = kr * (1 / d1.sqrMagnitude) * (1 / d1.magnitude - 1 / d0) * (-d1.normalized);
        else f1 = Vector3.zero;
        if (d2.magnitude <= d0)
            f2 = kr * (1 / d2.sqrMagnitude) * (1 / d2.magnitude - 1 / d0) * (-d2.normalized);
        else f2 = Vector3.zero;
        if (d3.magnitude <= d0)
            f3 = kr * (1 / d3.sqrMagnitude) * (1 / d3.magnitude - 1 / d0) * (-d3.normalized);
        else f3 = Vector3.zero;
        if (d4.magnitude <= d0)
            f4 = kr * (1 / d4.sqrMagnitude) * (1 / d4.magnitude - 1 / d0) * (-d4.normalized);
        else f4 = Vector3.zero;
        if (d5.magnitude <= d0)
            f5 = kr * (1 / d5.sqrMagnitude) * (1 / d5.magnitude - 1 / d0) * (-d5.normalized);
        else f5 = Vector3.zero;
        if (d6.magnitude <= d0)
            f6 = kr * (1 / d6.sqrMagnitude) * (1 / d6.magnitude - 1 / d0) * (-d6.normalized);
        else f6 = Vector3.zero;
        if (d7.magnitude <= d0)
            f7 = kr * (1 / d7.sqrMagnitude) * (1 / d7.magnitude - 1 / d0) * (-d7.normalized);
        else f7 = Vector3.zero;
        return fnet = f1 + f2 + f3 + f4 + f5 + f6 + f7;
    }
    /*static bool found (Vector3 d1g, Vector3 d2g, Vector3 d3g, Vector3 d4g, Vector3 d5g)
    {
        if (d1g.magnitude < 5 || d2g.magnitude < 5 || d3g.magnitude < 5 || d4g.magnitude < 5 || d5g.magnitude < 5)
            return true;
        else return false;
    }*/
}

  

