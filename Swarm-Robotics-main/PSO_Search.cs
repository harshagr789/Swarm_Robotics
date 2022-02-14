using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSO_Search : MonoBehaviour
{
    public Transform robo1_pose, robo2_pose, robo3_pose, robo4_pose, robo5_pose, robo6_pose, goal, actual_goal, ob1, ob2, ob3, ob4, ob5;
    Vector3 p1best = Vector3.positiveInfinity; Vector3 p2best = Vector3.positiveInfinity; Vector3 p3best = Vector3.positiveInfinity;
    Vector3 p4best = Vector3.positiveInfinity; Vector3 p5best = Vector3.positiveInfinity; Vector3 p6best = Vector3.positiveInfinity;
    float p1best_val = 1000f; float p2best_val = 1000f; float p3best_val = 1000f; float p4best_val = 1000f; float p5best_val = 1000f; float p6best_val = 1000f;
    float w = 0.8f; float c1 = 2f; float c2 = 2f;
    float a1 = 0f;  float a2 = 0f; float a3 = 0f; float a4 = 0f; float a5 = 0f; float a6 = 0f;
    float alpha = 0.0003f;
    float alpha1 = 0.1f;
    public GameObject g1,g2,g3,g4,g5;
    Renderer rend,rend1,rend2,rend3,rend4,rend5;
    //float t = 0f; float r = 60f;
    Vector3 v1 = Vector3.zero; Vector3 v2 = Vector3.zero; Vector3 v3 = Vector3.zero; Vector3 v4 = Vector3.zero; Vector3 v5 = Vector3.zero; Vector3 v6 = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend1=g1.GetComponent<Renderer>();
        rend2 = g2.GetComponent<Renderer>();
        rend3 = g3.GetComponent<Renderer>();
        rend4 = g4.GetComponent<Renderer>();
        rend5 = g5.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //t += 0.0005f;
        //r += 0.0005f;
        //goal.position = r * new Vector3(Mathf.Cos(t), 0, 0.5f*Mathf.Sin(t)+0.5f);
        Vector3 g = goal.position;
        Vector3 d1g = goal.position - robo1_pose.position; Vector3 d2g = goal.position - robo2_pose.position; Vector3 d3g = goal.position - robo3_pose.position;
        Vector3 d4g = goal.position - robo4_pose.position; Vector3 d5g = goal.position - robo5_pose.position; Vector3 d6g = goal.position - robo6_pose.position;
        Vector3 d1ag = actual_goal.position - robo1_pose.position; Vector3 d2ag = actual_goal.position - robo2_pose.position; Vector3 d3ag = actual_goal.position - robo3_pose.position;
        Vector3 d4ag = actual_goal.position - robo4_pose.position; Vector3 d5ag = actual_goal.position - robo5_pose.position; Vector3 d6ag = actual_goal.position - robo6_pose.position;
        
        Vector3 r11 = robo2_pose.position - robo1_pose.position;   Vector3 r12 = robo3_pose.position - robo1_pose.position;   Vector3 r13 = robo4_pose.position - robo1_pose.position;
        Vector3 r14 = robo5_pose.position - robo1_pose.position;   Vector3 r15 = robo6_pose.position - robo1_pose.position;   Vector3 r16 = ob1.position - robo1_pose.position;
        Vector3 r17 = ob2.position - robo1_pose.position;          Vector3 r18 = ob3.position - robo1_pose.position;          Vector3 r19 = ob4.position - robo1_pose.position;
        Vector3 r110 = ob5.position - robo1_pose.position;

        Vector3 r21 = robo1_pose.position - robo2_pose.position;   Vector3 r22 = robo3_pose.position - robo2_pose.position;   Vector3 r23 = robo4_pose.position - robo2_pose.position;
        Vector3 r24 = robo5_pose.position - robo2_pose.position;   Vector3 r25 = robo6_pose.position - robo2_pose.position;   Vector3 r26 = ob1.position - robo2_pose.position;
        Vector3 r27 = ob2.position - robo2_pose.position;          Vector3 r28 = ob3.position - robo2_pose.position;          Vector3 r29 = ob4.position - robo2_pose.position;
        Vector3 r210 = ob5.position - robo2_pose.position;

        Vector3 r31 = robo1_pose.position - robo3_pose.position;   Vector3 r32 = robo2_pose.position - robo3_pose.position;   Vector3 r33 = robo4_pose.position - robo3_pose.position;
        Vector3 r34 = robo5_pose.position - robo3_pose.position;   Vector3 r35 = robo6_pose.position - robo3_pose.position;   Vector3 r36 = ob1.position - robo3_pose.position;
        Vector3 r37 = ob2.position - robo3_pose.position;          Vector3 r38 = ob3.position - robo3_pose.position;          Vector3 r39 = ob4.position - robo3_pose.position;
        Vector3 r310 = ob5.position - robo1_pose.position;

        Vector3 r41 = robo1_pose.position - robo4_pose.position;   Vector3 r42 = robo2_pose.position - robo4_pose.position;   Vector3 r43 = robo3_pose.position - robo4_pose.position;
        Vector3 r44 = robo5_pose.position - robo4_pose.position;   Vector3 r45 = robo6_pose.position - robo4_pose.position;   Vector3 r46 = ob1.position - robo4_pose.position;
        Vector3 r47 = ob2.position - robo4_pose.position;          Vector3 r48 = ob3.position - robo4_pose.position;          Vector3 r49 = ob4.position - robo4_pose.position;
        Vector3 r410 = ob5.position - robo4_pose.position;

        Vector3 r51 = robo1_pose.position - robo5_pose.position;   Vector3 r52 = robo2_pose.position - robo5_pose.position;   Vector3 r53 = robo3_pose.position - robo5_pose.position;
        Vector3 r54 = robo4_pose.position - robo5_pose.position;   Vector3 r55 = robo6_pose.position - robo5_pose.position;   Vector3 r56 = ob1.position - robo5_pose.position;
        Vector3 r57 = ob2.position - robo5_pose.position;          Vector3 r58 = ob3.position - robo5_pose.position;          Vector3 r59 = ob4.position - robo5_pose.position;
        Vector3 r510 = ob5.position - robo5_pose.position;

        Vector3 r61 = robo1_pose.position - robo6_pose.position;   Vector3 r62 = robo2_pose.position - robo6_pose.position;   Vector3 r63 = robo3_pose.position - robo6_pose.position;
        Vector3 r64 = robo4_pose.position - robo6_pose.position;   Vector3 r65 = robo5_pose.position - robo6_pose.position;   Vector3 r66 = ob1.position - robo6_pose.position;
        Vector3 r67 = ob2.position - robo6_pose.position;          Vector3 r68 = ob3.position - robo6_pose.position;          Vector3 r69 = ob4.position - robo6_pose.position;
        Vector3 r610 = ob5.position - robo6_pose.position;

        Vector3 f1net = repulsion(r11, r12, r13, r14, r15, r16, r17, r18, r19, r110);
        Vector3 f2net = repulsion(r21, r22, r23, r24, r25, r26, r27, r28, r29, r210);
        Vector3 f3net = repulsion(r31, r32, r33, r34, r35, r36, r37, r38, r39, r310);
        Vector3 f4net = repulsion(r41, r42, r43, r44, r45, r46, r47, r48, r49, r410);
        Vector3 f5net = repulsion(r51, r52, r53, r54, r55, r56, r57, r58, r59, r510);
        Vector3 f6net = repulsion(r61, r62, r63, r64, r65, r66, r67, r68, r69, r610);

        if (d1ag.magnitude > 10 && d2ag.magnitude > 10 && d3ag.magnitude > 10 && d4ag.magnitude > 10 && d5ag.magnitude > 10 && d6ag.magnitude > 10)
        {
            p1best = find_pbest(d1g, p1best, p1best_val, g); p1best_val = find_pbestval(d1g, p1best_val);
            p2best = find_pbest(d2g, p2best, p2best_val, g); p2best_val = find_pbestval(d2g, p2best_val);
            p3best = find_pbest(d3g, p1best, p3best_val, g); p3best_val = find_pbestval(d3g, p3best_val);
            p4best = find_pbest(d4g, p1best, p4best_val, g); p4best_val = find_pbestval(d4g, p4best_val);
            p5best = find_pbest(d5g, p1best, p5best_val, g); p5best_val = find_pbestval(d5g, p5best_val);
            p6best = find_pbest(d6g, p1best, p6best_val, g); p6best_val = find_pbestval(d6g, p6best_val);
            Vector3 gbest = find_gbest(d1g, d2g, d3g, d4g, d5g, d6g, g);

            v1 = w * v1 + c1 * Random.value * (p1best - transform.position) + c2 * Random.value * (gbest - transform.position);
            transform.position += alpha * v1 + alpha1*f1net;
            a1 += alpha * v1.magnitude;

            v2 = w * v2 + c1 * Random.value * (p2best - robo2_pose.position) + c2 * Random.value * (gbest - robo2_pose.position);
            robo2_pose.position += alpha * v2 + alpha1 * f2net;
            a2 += alpha * v2.magnitude;

            v3 = w * v3 + c1 * Random.value * (p3best - robo3_pose.position) + c2 * Random.value * (gbest - robo3_pose.position);
            robo3_pose.position += alpha * v3 + alpha1 * f3net;
            a3 += alpha * v3.magnitude;

            v4 = w * v4 + c1 * Random.value * (p4best - robo4_pose.position) + c2 * Random.value * (gbest - robo4_pose.position);
            robo4_pose.position += alpha * v4 + alpha1 * f4net;
            a4 += alpha * v4.magnitude;

            v5 = w * v5 + c1 * Random.value * (p5best - robo5_pose.position) + c2 * Random.value * (gbest - robo5_pose.position);
            robo5_pose.position += alpha * v5 + alpha1 * f5net;
            a5 += alpha * v5.magnitude;

            v6 = w * v6 + c1 * Random.value * (p6best - robo6_pose.position) + c2 * Random.value * (gbest - robo6_pose.position);
            robo6_pose.position += alpha * v6 + alpha1 * f6net;
            a6 += alpha * v6.magnitude;
            Debug.Log(gbest);
        }
        else
        {
            Debug.Log("Target found");
            Debug.Log(a1 + a2 + a3 + a4 + a5 + a6);
            rend.material.color = Color.cyan;
            rend1.material.color = Color.blue;
            rend2.material.color = Color.black;
            rend3.material.color = Color.yellow;
            rend4.material.color = Color.red;
            rend5.material.color = Color.magenta;
        }
    }
    static float find_pbestval(Vector3 d, float pbest_val)
    {
        float temp;
        if (d.magnitude < pbest_val)
        {
            temp = d.magnitude;
        }
        else temp = pbest_val;
        return temp;
    }
    static Vector3 find_pbest(Vector3 d, Vector3 d1, float pbest_val, Vector3 g)
    {
        Vector3 temp;
        if (d.magnitude < pbest_val)
        {
            temp = g - d;
        }
        else temp = d1;
        return temp;
    }
    static Vector3 find_gbest(Vector3 d1, Vector3 d2, Vector3 d3, Vector3 d4, Vector3 d5, Vector3 d6, Vector3 g)
    {
        Vector3 d = Vector3.zero;
        float temp = Mathf.Min(d1.magnitude, d2.magnitude, d3.magnitude, d4.magnitude, d5.magnitude, d6.magnitude);
        if (d1.magnitude == temp)
        { d = g - d1; }
        else if (d2.magnitude == temp)
        { d = g - d2; }
        else if (d3.magnitude == temp)
        { d = g - d3; }
        else if (d4.magnitude == temp)
        { d = g - d4; }
        else if (d5.magnitude == temp)
        { d = g - d5; }
        else if (d6.magnitude == temp)
        { d = g - d6; }
        return d;
    }
    static Vector3 repulsion(Vector3 d1, Vector3 d2, Vector3 d3, Vector3 d4, Vector3 d5, Vector3 d6, Vector3 d7, Vector3 d8, Vector3 d9, Vector3 d10)
    {
        float d0 = 12f; float a0 = 6f;
        float kr = 10000f; float kr1 = 500f;
        Vector3 fnet, f1, f2, f3, f4, f5, f6, f7, f8, f9, f10;
        if (d1.magnitude <= a0)
            f1 = kr1 * (1 / d1.sqrMagnitude) * (1 / d1.magnitude - 1 / a0) * (-d1.normalized);
        else f1 = Vector3.zero;
        if (d2.magnitude <= a0)
            f2 = kr1 * (1 / d2.sqrMagnitude) * (1 / d2.magnitude - 1 / a0) * (-d2.normalized);
        else f2 = Vector3.zero;
        if (d3.magnitude <= a0)
            f3 = kr1 * (1 / d3.sqrMagnitude) * (1 / d3.magnitude - 1 / a0) * (-d3.normalized);
        else f3 = Vector3.zero;
        if (d4.magnitude <= a0)
            f4 = kr1 * (1 / d4.sqrMagnitude) * (1 / d4.magnitude - 1 / a0) * (-d4.normalized);
        else f4 = Vector3.zero;
        if (d5.magnitude <= a0)
            f5 = kr1 * (1 / d5.sqrMagnitude) * (1 / d5.magnitude - 1 / a0) * (-d5.normalized);
        else f5 = Vector3.zero;
        if (d6.magnitude <= d0)
            f6 = kr * (1 / d6.sqrMagnitude) * (1 / d6.magnitude - 1 / d0) * (-d6.normalized);
        else f6 = Vector3.zero;
        if (d7.magnitude <= d0)
            f7 = kr * (1 / d7.sqrMagnitude) * (1 / d7.magnitude - 1 / d0) * (-d7.normalized);
        else f7 = Vector3.zero;
        if (d8.magnitude <= d0)
            f8 = kr * (1 / d8.sqrMagnitude) * (1 / d8.magnitude - 1 / d0) * (-d8.normalized);
        else f8 = Vector3.zero;
        if (d9.magnitude <= d0)
            f9 = kr * (1 / d9.sqrMagnitude) * (1 / d9.magnitude - 1 / d0) * (-d9.normalized);
        else f9 = Vector3.zero;
        if (d10.magnitude <= d0)
            f10 = kr * (1 / d10.sqrMagnitude) * (1 / d10.magnitude - 1 / d0) * (-d10.normalized);
        else f10 = Vector3.zero;
        fnet = f1 + f2 + f3 + f4 + f5 + f6 + f7 + f8 + f9 + f10;
        return fnet;
    }
}
