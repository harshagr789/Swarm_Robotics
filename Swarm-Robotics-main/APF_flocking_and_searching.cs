using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APF_flocking_and_searching : MonoBehaviour
{
    public Transform robo1, robo2, robo3, robo4, robo5, robo6, cam, goal1, goal2, goal3, actual_goal;
    public Rigidbody att1, att2, att3, att4, att5, att6;
    public Transform ob1, ob2, ob3, ob4, ob5, ob6;
    Vector3 offset = new Vector3(0, 20, -40);
    // Start is called before the first frame update
    float t = 0f;   float count = 0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        count += 0.01f;
        t += 0.0003f;
        goal1.position = 80f * new Vector3(Mathf.Cos(t), 0, 0.15f*Mathf.Sin(t)-0.15f);
        goal2.position = 80f * new Vector3(Mathf.Cos(t), 0, 0.15f * Mathf.Sin(t) + 0.2f);
        goal3.position = 80f * new Vector3(Mathf.Cos(t), 0, 0.15f * Mathf.Sin(t) + 0.6f);
        Vector3 a11 = robo2.position - robo1.position; Vector3 a12 = robo3.position - robo1.position; Vector3 a13 = robo4.position - robo1.position;
        Vector3 a14 = robo5.position - robo1.position; Vector3 a15 = robo6.position - robo1.position;
        Vector3 a21 = robo1.position - robo2.position; Vector3 a22 = robo3.position - robo2.position; Vector3 a23 = robo4.position - robo2.position;
        Vector3 a24 = robo5.position - robo2.position; Vector3 a25 = robo6.position - robo2.position;
        Vector3 a31 = robo1.position - robo3.position; Vector3 a32 = robo2.position - robo3.position; Vector3 a33 = robo4.position - robo3.position;
        Vector3 a34 = robo5.position - robo3.position; Vector3 a35 = robo6.position - robo3.position;
        Vector3 a41 = robo1.position - robo4.position; Vector3 a42 = robo2.position - robo4.position; Vector3 a43 = robo3.position - robo4.position;
        Vector3 a44 = robo5.position - robo4.position; Vector3 a45 = robo6.position - robo4.position;
        Vector3 a51 = robo1.position - robo5.position; Vector3 a52 = robo2.position - robo5.position; Vector3 a53 = robo3.position - robo5.position;
        Vector3 a54 = robo4.position - robo5.position; Vector3 a55 = robo6.position - robo5.position;
        Vector3 a61 = robo1.position - robo6.position; Vector3 a62 = robo2.position - robo6.position; Vector3 a63 = robo3.position - robo6.position;
        Vector3 a64 = robo4.position - robo6.position; Vector3 a65 = robo5.position - robo6.position;

        float ang11 = Mathf.Atan2(a11.z, a11.x); float ang12 = Mathf.Atan2(a12.z, a12.x); float ang13 = Mathf.Atan2(a13.z, a13.x);
        float ang14 = Mathf.Atan2(a14.z, a14.x); float ang15 = Mathf.Atan2(a15.z, a15.x);
        float ang21 = Mathf.Atan2(a21.z, a21.x); float ang22 = Mathf.Atan2(a22.z, a22.x); float ang23 = Mathf.Atan2(a23.z, a23.x);
        float ang24 = Mathf.Atan2(a24.z, a24.x); float ang25 = Mathf.Atan2(a25.z, a25.x);
        float ang31 = Mathf.Atan2(a31.z, a31.x); float ang32 = Mathf.Atan2(a32.z, a32.x); float ang33 = Mathf.Atan2(a33.z, a33.x);
        float ang34 = Mathf.Atan2(a34.z, a34.x); float ang35 = Mathf.Atan2(a35.z, a35.x);
        float ang41 = Mathf.Atan2(a41.z, a41.x); float ang42 = Mathf.Atan2(a42.z, a42.x); float ang43 = Mathf.Atan2(a43.z, a43.x);
        float ang44 = Mathf.Atan2(a44.z, a44.x); float ang45 = Mathf.Atan2(a45.z, a45.x);
        float ang51 = Mathf.Atan2(a51.z, a51.x); float ang52 = Mathf.Atan2(a52.z, a52.x); float ang53 = Mathf.Atan2(a53.z, a53.x);
        float ang54 = Mathf.Atan2(a54.z, a54.x); float ang55 = Mathf.Atan2(a55.z, a55.x);
        float ang61 = Mathf.Atan2(a61.z, a61.x); float ang62 = Mathf.Atan2(a62.z, a62.x); float ang63 = Mathf.Atan2(a63.z, a63.x);
        float ang64 = Mathf.Atan2(a64.z, a64.x); float ang65 = Mathf.Atan2(a65.z, a65.x);

        Vector3 aob11 = ob1.position - robo1.position; Vector3 aob12 = ob2.position - robo1.position; Vector3 aob13 = ob3.position - robo1.position;
        Vector3 aob14 = ob4.position - robo1.position; Vector3 aob15 = ob5.position - robo1.position; Vector3 aob16 = ob6.position - robo1.position;
        Vector3 aob21 = ob1.position - robo2.position; Vector3 aob22 = ob2.position - robo2.position; Vector3 aob23 = ob3.position - robo2.position;
        Vector3 aob24 = ob4.position - robo2.position; Vector3 aob25 = ob5.position - robo2.position; Vector3 aob26 = ob6.position - robo3.position;
        Vector3 aob31 = ob1.position - robo3.position; Vector3 aob32 = ob2.position - robo3.position; Vector3 aob33 = ob3.position - robo3.position;
        Vector3 aob34 = ob4.position - robo3.position; Vector3 aob35 = ob5.position - robo3.position; Vector3 aob36 = ob6.position - robo3.position;
        Vector3 aob41 = ob1.position - robo4.position; Vector3 aob42 = ob2.position - robo4.position; Vector3 aob43 = ob3.position - robo4.position;
        Vector3 aob44 = ob4.position - robo4.position; Vector3 aob45 = ob5.position - robo4.position; Vector3 aob46 = ob6.position - robo4.position;
        Vector3 aob51 = ob1.position - robo5.position; Vector3 aob52 = ob2.position - robo5.position; Vector3 aob53 = ob3.position - robo5.position;
        Vector3 aob54 = ob4.position - robo5.position; Vector3 aob55 = ob5.position - robo5.position; Vector3 aob56 = ob6.position - robo5.position;
        Vector3 aob61 = ob1.position - robo6.position; Vector3 aob62 = ob2.position - robo6.position; Vector3 aob63 = ob3.position - robo6.position;
        Vector3 aob64 = ob4.position - robo6.position; Vector3 aob65 = ob5.position - robo6.position; Vector3 aob66 = ob6.position - robo6.position;

        Vector3 ag1 = goal1.position - robo1.position;             Vector3 ag2 = goal2.position - robo3.position;            Vector3 ag3 = goal3.position - robo5.position;
        Vector3 at1 = actual_goal.position - robo1.position;       Vector3 at2 = actual_goal.position - robo2.position;      Vector3 at3 = actual_goal.position - robo3.position;
        Vector3 at4 = actual_goal.position - robo4.position;       Vector3 at5 = actual_goal.position - robo5.position;      Vector3 at6 = actual_goal.position - robo6.position;
        if(at1.magnitude<=7 || at2.magnitude<=7 || at3.magnitude<=7 || at4.magnitude<=7 || at5.magnitude<=7 || at6.magnitude <= 7)
        {
            Debug.Log("Target Found");
            att1.velocity = Vector3.zero; att2.velocity = Vector3.zero; att3.velocity = Vector3.zero;
            att4.velocity = Vector3.zero; att5.velocity = Vector3.zero; att6.velocity = Vector3.zero;
        }
        else
        {
            if (count < 100)
            {
                att1.velocity = self_force(a11, a12, a13, a14, a15, ang11, ang12, ang13, ang14, ang15) + mutual_repulsion(aob11, aob12, aob13, aob14, aob15, aob16) + mutual_attraction(ag1);
                att2.velocity = self_force(a21, a22, a23, a24, a25, ang21, ang22, ang23, ang24, ang25) + mutual_repulsion(aob21, aob22, aob23, aob24, aob25, aob26);
                att3.velocity = self_force(a31, a32, a33, a34, a35, ang31, ang32, ang33, ang34, ang35) + mutual_repulsion(aob31, aob32, aob33, aob34, aob35, aob36);
                att4.velocity = self_force(a41, a42, a43, a44, a45, ang41, ang42, ang43, ang44, ang45) + mutual_repulsion(aob41, aob42, aob43, aob44, aob45, aob46);
                att5.velocity = self_force(a51, a52, a53, a54, a55, ang51, ang52, ang53, ang54, ang55) + mutual_repulsion(aob51, aob52, aob53, aob54, aob55, aob56);
                att6.velocity = self_force(a61, a62, a63, a64, a65, ang61, ang62, ang63, ang64, ang65) + mutual_repulsion(aob61, aob62, aob63, aob64, aob65, aob66);
            }
            if (count >= 100 && count < 200)
            {
                att1.velocity = self_force(a11, a12, a13, a14, a15, ang11, ang12, ang13, ang14, ang15) + mutual_repulsion(aob11, aob12, aob13, aob14, aob15, aob16);
                att2.velocity = self_force(a21, a22, a23, a24, a25, ang21, ang22, ang23, ang24, ang25) + mutual_repulsion(aob21, aob22, aob23, aob24, aob25, aob26);
                att3.velocity = self_force(a31, a32, a33, a34, a35, ang31, ang32, ang33, ang34, ang35) + mutual_repulsion(aob31, aob32, aob33, aob34, aob35, aob36) + mutual_attraction(ag2);
                att4.velocity = self_force(a41, a42, a43, a44, a45, ang41, ang42, ang43, ang44, ang45) + mutual_repulsion(aob41, aob42, aob43, aob44, aob45, aob46);
                att5.velocity = self_force(a51, a52, a53, a54, a55, ang51, ang52, ang53, ang54, ang55) + mutual_repulsion(aob51, aob52, aob53, aob54, aob55, aob56);
                att6.velocity = self_force(a61, a62, a63, a64, a65, ang61, ang62, ang63, ang64, ang65) + mutual_repulsion(aob61, aob62, aob63, aob64, aob65, aob66);
            }
            if (count >= 200)
            {
                att1.velocity = self_force(a11, a12, a13, a14, a15, ang11, ang12, ang13, ang14, ang15) + mutual_repulsion(aob11, aob12, aob13, aob14, aob15, aob16);
                att2.velocity = self_force(a21, a22, a23, a24, a25, ang21, ang22, ang23, ang24, ang25) + mutual_repulsion(aob21, aob22, aob23, aob24, aob25, aob26);
                att3.velocity = self_force(a31, a32, a33, a34, a35, ang31, ang32, ang33, ang34, ang35) + mutual_repulsion(aob31, aob32, aob33, aob34, aob35, aob36);
                att4.velocity = self_force(a41, a42, a43, a44, a45, ang41, ang42, ang43, ang44, ang45) + mutual_repulsion(aob41, aob42, aob43, aob44, aob45, aob46);
                att5.velocity = self_force(a51, a52, a53, a54, a55, ang51, ang52, ang53, ang54, ang55) + mutual_repulsion(aob51, aob52, aob53, aob54, aob55, aob56) + mutual_attraction(ag3);
                att6.velocity = self_force(a61, a62, a63, a64, a65, ang61, ang62, ang63, ang64, ang65) + mutual_repulsion(aob61, aob62, aob63, aob64, aob65, aob66);
            }

        }
        

        //cam.position = transform.position + offset;
    }
    static Vector3 repulsion(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, Vector3 p5, float a1, float a2, float a3, float a4, float a5)
    {
        float r0 = 5f;
        float vmax = 300f;
        Vector3 vnet, v1, v2, v3, v4, v5;
        if (p1.magnitude <= r0)
        {
            v1 = -(r0 - p1.magnitude) / r0 * vmax * new Vector3(Mathf.Cos(a1), 0, Mathf.Sin(a1));
        }
        else v1 = Vector3.zero;
        if (p2.magnitude <= r0)
        {
            v2 = -(r0 - p2.magnitude) / r0 * vmax * new Vector3(Mathf.Cos(a2), 0, Mathf.Sin(a2));
        }
        else v2 = Vector3.zero;
        if (p3.magnitude <= r0)
        {
            v3 = -(r0 - p3.magnitude) / r0 * vmax * new Vector3(Mathf.Cos(a3), 0, Mathf.Sin(a3));
        }
        else v3 = Vector3.zero;
        if (p4.magnitude <= r0)
        {
            v4 = -(r0 - p4.magnitude) / r0 * vmax * new Vector3(Mathf.Cos(a4), 0, Mathf.Sin(a4));
        }
        else v4 = Vector3.zero;
        if (p5.magnitude <= r0)
        {
            v5 = -(r0 - p5.magnitude) / r0 * vmax * new Vector3(Mathf.Cos(a5), 0, Mathf.Sin(a5));
        }
        else v5 = Vector3.zero;
        vnet = v1 + v2 + v3 + v4 + v5;
        return vnet;
    }
    static Vector3 attraction(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, Vector3 p5, float a1, float a2, float a3, float a4, float a5)
    {
        float r1 = 6.5f; float r2 = 12f;
        float vmax = 250f;
        Vector3 vnet, v1, v2, v3, v4, v5;
        if (p1.magnitude >= r1 && p1.magnitude <= r2)
        {
            v1 = (p1.magnitude - r1) / (r2 - r1) * vmax * new Vector3(Mathf.Cos(a1), 0, Mathf.Sin(a1));
        }
        else v1 = Vector3.zero;
        if (p2.magnitude >= r1 && p2.magnitude <= r2)
        {
            v2 = (p2.magnitude - r1) / (r2 - r1) * vmax * new Vector3(Mathf.Cos(a2), 0, Mathf.Sin(a2));
        }
        else v2 = Vector3.zero;
        if (p3.magnitude >= r1 && p3.magnitude <= r2)
        {
            v3 = (p3.magnitude - r1) / (r2 - r1) * vmax * new Vector3(Mathf.Cos(a3), 0, Mathf.Sin(a3));
        }
        else v3 = Vector3.zero;
        if (p4.magnitude >= r1 && p4.magnitude <= r2)
        {
            v4 = (p4.magnitude - r1) / (r2 - r1) * vmax * new Vector3(Mathf.Cos(a4), 0, Mathf.Sin(a4));
        }
        else v4 = Vector3.zero;
        if (p5.magnitude >= r1 && p5.magnitude <= r2)
        {
            v5 = (p5.magnitude - r1) / (r2 - r1) * vmax * new Vector3(Mathf.Cos(a5), 0, Mathf.Sin(a5));
        }
        else v5 = Vector3.zero;
        vnet = v1 + v2 + v3 + v4 + v5;
        return vnet;
    }
    static Vector3 self_force(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, Vector3 p5, float a1, float a2, float a3, float a4, float a5)
    {
        float alpha1 = 0.1f;
        Vector3 vnet, vr, va;
        vr = repulsion(p1, p2, p3, p4, p5, a1, a2, a3, a4, a5);
        va = attraction(p1, p2, p3, p4, p5, a1, a2, a3, a4, a5);
        vnet = alpha1 * (vr + va);
        return vnet;
    }
    static Vector3 mutual_attraction(Vector3 p1)
    {
        float vmax = 20f;
        Vector3 v1 = p1.normalized * vmax;
        return v1;
    }
    static Vector3 mutual_repulsion(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, Vector3 p5, Vector3 p6)
    {
        float d0 = 35f;
        float vrmax = 5f;
        float alpha = 3000f;
        Vector3 v, v1, v2, v3, v4, v5, v6;
        if (p1.magnitude <= d0)
        {
            v1 = alpha * (1 / p1.sqrMagnitude) * (1 / p1.magnitude - 1 / d0) * p1.normalized * vrmax;
        }
        else v1 = Vector3.zero;
        if (p2.magnitude <= d0)
        {
            v2 = alpha * (1 / p2.sqrMagnitude) * (1 / p2.magnitude - 1 / d0) * p2.normalized * vrmax;
        }
        else v2 = Vector3.zero;
        if (p3.magnitude <= d0)
        {
            v3 = alpha * (1 / p3.sqrMagnitude) * (1 / p3.magnitude - 1 / d0) * p3.normalized * vrmax;
        }
        else v3 = Vector3.zero;
        if (p4.magnitude <= d0)
        {
            v4 = alpha * (1 / p4.sqrMagnitude) * (1 / p4.magnitude - 1 / d0) * p4.normalized * vrmax;
        }
        else v4 = Vector3.zero;
        if (p5.magnitude <= d0)
        {
            v5 = alpha * (1 / p5.sqrMagnitude) * (1 / p5.magnitude - 1 / d0) * p5.normalized * vrmax;
        }
        else v5 = Vector3.zero;
        if (p6.magnitude <= d0)
        {
            v6 = alpha * (1 / p6.sqrMagnitude) * (1 / p6.magnitude - 1 / d0) * p6.normalized * vrmax;
        }
        else v6 = Vector3.zero;
        v = -(v1 + v2 + v3 + v4 + v5 + v6);
        return v;
    }
   
}
