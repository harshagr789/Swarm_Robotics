using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker_Defender_movement : MonoBehaviour
{
    public Transform attacker1, attacker2, attacker3, attacker4, attacker5, attacker6, cam;
    public Rigidbody att1, att2, att3, att4, att5, att6;
    public Transform defender1, defender2, defender3, defender4, defender5, defender6;
    public Rigidbody def1, def2, def3, def4, def5, def6;
    //public Transform ob1, ob2, ob3, ob4, ob5, ob6;
    Vector3 offset = new Vector3(0, 20, -40);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a11 = attacker2.position - attacker1.position;   Vector3 a12 = attacker3.position - attacker1.position;   Vector3 a13 = attacker4.position - attacker1.position;
        Vector3 a14 = attacker5.position - attacker1.position;   Vector3 a15 = attacker6.position - attacker1.position;
        Vector3 a21 = attacker1.position - attacker2.position;   Vector3 a22 = attacker3.position - attacker2.position;   Vector3 a23 = attacker4.position - attacker2.position;
        Vector3 a24 = attacker5.position - attacker2.position;   Vector3 a25 = attacker6.position - attacker2.position;
        Vector3 a31 = attacker1.position - attacker3.position;   Vector3 a32 = attacker2.position - attacker3.position;   Vector3 a33 = attacker4.position - attacker3.position;
        Vector3 a34 = attacker5.position - attacker3.position;   Vector3 a35 = attacker6.position - attacker3.position;
        Vector3 a41 = attacker1.position - attacker4.position;   Vector3 a42 = attacker2.position - attacker4.position;   Vector3 a43 = attacker3.position - attacker4.position;
        Vector3 a44 = attacker5.position - attacker4.position;   Vector3 a45 = attacker6.position - attacker4.position;
        Vector3 a51 = attacker1.position - attacker5.position;   Vector3 a52 = attacker2.position - attacker5.position;   Vector3 a53 = attacker3.position - attacker5.position;
        Vector3 a54 = attacker4.position - attacker5.position;   Vector3 a55 = attacker6.position - attacker5.position;
        Vector3 a61 = attacker1.position - attacker6.position;   Vector3 a62 = attacker2.position - attacker6.position;   Vector3 a63 = attacker3.position - attacker6.position;
        Vector3 a64 = attacker4.position - attacker6.position;   Vector3 a65 = attacker5.position - attacker6.position;

        float ang11 = Mathf.Atan2(a11.z, a11.x);     float ang12 = Mathf.Atan2(a12.z, a12.x);     float ang13 = Mathf.Atan2(a13.z, a13.x);
        float ang14 = Mathf.Atan2(a14.z, a14.x);     float ang15 = Mathf.Atan2(a15.z, a15.x);
        float ang21 = Mathf.Atan2(a21.z, a21.x);     float ang22 = Mathf.Atan2(a22.z, a22.x);     float ang23 = Mathf.Atan2(a23.z, a23.x);
        float ang24 = Mathf.Atan2(a24.z, a24.x);     float ang25 = Mathf.Atan2(a25.z, a25.x);
        float ang31 = Mathf.Atan2(a31.z, a31.x);     float ang32 = Mathf.Atan2(a32.z, a32.x);     float ang33 = Mathf.Atan2(a33.z, a33.x);
        float ang34 = Mathf.Atan2(a34.z, a34.x);     float ang35 = Mathf.Atan2(a35.z, a35.x);
        float ang41 = Mathf.Atan2(a41.z, a41.x);     float ang42 = Mathf.Atan2(a42.z, a42.x);     float ang43 = Mathf.Atan2(a43.z, a43.x);
        float ang44 = Mathf.Atan2(a44.z, a44.x);     float ang45 = Mathf.Atan2(a45.z, a45.x);
        float ang51 = Mathf.Atan2(a51.z, a51.x);     float ang52 = Mathf.Atan2(a52.z, a52.x);     float ang53 = Mathf.Atan2(a53.z, a53.x);
        float ang54 = Mathf.Atan2(a54.z, a54.x);     float ang55 = Mathf.Atan2(a55.z, a55.x);
        float ang61 = Mathf.Atan2(a61.z, a61.x);     float ang62 = Mathf.Atan2(a62.z, a62.x);     float ang63 = Mathf.Atan2(a63.z, a63.x);
        float ang64 = Mathf.Atan2(a64.z, a64.x);     float ang65 = Mathf.Atan2(a65.z, a65.x);

        Vector3 d11 = defender2.position - defender1.position;   Vector3 d12 = defender3.position - defender1.position;   Vector3 d13 = defender4.position - defender1.position;
        Vector3 d14 = defender5.position - defender1.position;   Vector3 d15 = defender6.position - defender1.position;
        Vector3 d21 = defender1.position - defender2.position;   Vector3 d22 = defender3.position - defender2.position;   Vector3 d23 = defender4.position - defender2.position;
        Vector3 d24 = defender5.position - defender2.position;   Vector3 d25 = defender6.position - defender2.position;
        Vector3 d31 = defender1.position - defender3.position;   Vector3 d32 = defender2.position - defender3.position;   Vector3 d33 = defender4.position - defender3.position;
        Vector3 d34 = defender5.position - defender3.position;   Vector3 d35 = defender6.position - defender3.position;
        Vector3 d41 = defender1.position - defender4.position;   Vector3 d42 = defender2.position - defender4.position;   Vector3 d43 = defender3.position - defender4.position;
        Vector3 d44 = defender5.position - defender4.position;   Vector3 d45 = defender6.position - defender4.position;
        Vector3 d51 = defender1.position - defender5.position;   Vector3 d52 = defender2.position - defender5.position;   Vector3 d53 = defender3.position - defender5.position;
        Vector3 d54 = defender4.position - defender5.position;   Vector3 d55 = defender6.position - defender5.position;
        Vector3 d61 = defender1.position - defender6.position;   Vector3 d62 = defender2.position - defender6.position;   Vector3 d63 = defender3.position - defender6.position;
        Vector3 d64 = defender4.position - defender6.position;   Vector3 d65 = defender5.position - defender6.position;

        float dang11 = Mathf.Atan2(d11.z, d11.x);     float dang12 = Mathf.Atan2(d12.z, d12.x);   float dang13 = Mathf.Atan2(d13.z, d13.x);
        float dang14 = Mathf.Atan2(d14.z, d14.x);     float dang15 = Mathf.Atan2(d15.z, d15.x);
        float dang21 = Mathf.Atan2(d21.z, d21.x);     float dang22 = Mathf.Atan2(d22.z, d22.x);   float dang23 = Mathf.Atan2(d23.z, d23.x);
        float dang24 = Mathf.Atan2(d24.z, d24.x);     float dang25 = Mathf.Atan2(d25.z, d25.x);
        float dang31 = Mathf.Atan2(d31.z, d31.x);     float dang32 = Mathf.Atan2(d32.z, d32.x);   float dang33 = Mathf.Atan2(d33.z, d33.x);
        float dang34 = Mathf.Atan2(d34.z, d34.x);     float dang35 = Mathf.Atan2(d35.z, d35.x);
        float dang41 = Mathf.Atan2(d41.z, d41.x);     float dang42 = Mathf.Atan2(d42.z, d42.x);   float dang43 = Mathf.Atan2(d43.z, d43.x);
        float dang44 = Mathf.Atan2(d44.z, d44.x);     float dang45 = Mathf.Atan2(d45.z, d45.x);
        float dang51 = Mathf.Atan2(d51.z, d51.x);     float dang52 = Mathf.Atan2(d52.z, d52.x);   float dang53 = Mathf.Atan2(d53.z, d53.x);
        float dang54 = Mathf.Atan2(d54.z, d54.x);     float dang55 = Mathf.Atan2(d55.z, d55.x);
        float dang61 = Mathf.Atan2(d61.z, d61.x);     float dang62 = Mathf.Atan2(d62.z, d62.x);   float dang63 = Mathf.Atan2(d63.z, d63.x);
        float dang64 = Mathf.Atan2(d64.z, d64.x);     float dang65 = Mathf.Atan2(d65.z, d65.x);

        Vector3 ad11 = defender1.position - attacker1.position;   Vector3 ad12 = defender2.position - attacker1.position;   Vector3 ad13 = defender3.position - attacker1.position;
        Vector3 ad14 = defender4.position - attacker1.position;   Vector3 ad15 = defender5.position - attacker1.position;   Vector3 ad16 = defender6.position - attacker1.position;
        Vector3 ad21 = defender1.position - attacker2.position;   Vector3 ad22 = defender2.position - attacker2.position;   Vector3 ad23 = defender3.position - attacker2.position;
        Vector3 ad24 = defender4.position - attacker2.position;   Vector3 ad25 = defender5.position - attacker2.position;   Vector3 ad26 = defender6.position - attacker2.position;
        Vector3 ad31 = defender1.position - attacker3.position;   Vector3 ad32 = defender2.position - attacker3.position;   Vector3 ad33 = defender3.position - attacker3.position;
        Vector3 ad34 = defender4.position - attacker3.position;   Vector3 ad35 = defender5.position - attacker3.position;   Vector3 ad36 = defender6.position - attacker3.position;
        Vector3 ad41 = defender1.position - attacker4.position;   Vector3 ad42 = defender2.position - attacker4.position;   Vector3 ad43 = defender3.position - attacker4.position;
        Vector3 ad44 = defender4.position - attacker4.position;   Vector3 ad45 = defender5.position - attacker4.position;   Vector3 ad46 = defender6.position - attacker4.position;
        Vector3 ad51 = defender1.position - attacker5.position;   Vector3 ad52 = defender2.position - attacker5.position;   Vector3 ad53 = defender3.position - attacker5.position;
        Vector3 ad54 = defender4.position - attacker5.position;   Vector3 ad55 = defender5.position - attacker5.position;   Vector3 ad56 = defender6.position - attacker5.position;
        Vector3 ad61 = defender1.position - attacker6.position;   Vector3 ad62 = defender2.position - attacker6.position;   Vector3 ad63 = defender3.position - attacker6.position;
        Vector3 ad64 = defender4.position - attacker6.position;   Vector3 ad65 = defender5.position - attacker6.position;   Vector3 ad66 = defender6.position - attacker6.position;

        /*Vector3 dob11 = ob1.position - defender1.position;        Vector3 dob12 = ob2.position - defender1.position;        Vector3 dob13 = ob3.position - defender1.position;
        Vector3 dob14 = ob4.position - defender1.position;        Vector3 dob15 = ob5.position - defender1.position;        Vector3 dob16 = ob6.position - defender1.position;

        Vector3 aob11 = ob1.position - attacker1.position;        Vector3 aob12 = ob2.position - attacker1.position;        Vector3 aob13 = ob3.position - attacker1.position;
        Vector3 aob14 = ob4.position - attacker1.position;        Vector3 aob15 = ob5.position - attacker1.position;        Vector3 aob16 = ob6.position - attacker1.position;
        Vector3 aob21 = ob1.position - attacker2.position;        Vector3 aob22 = ob2.position - attacker2.position;        Vector3 aob23 = ob3.position - attacker2.position;
        Vector3 aob24 = ob4.position - attacker2.position;        Vector3 aob25 = ob5.position - attacker2.position;        Vector3 aob26 = ob6.position - attacker2.position;
        Vector3 aob31 = ob1.position - attacker3.position;        Vector3 aob32 = ob2.position - attacker3.position;        Vector3 aob33 = ob3.position - attacker3.position;
        Vector3 aob34 = ob4.position - attacker3.position;        Vector3 aob35 = ob5.position - attacker3.position;        Vector3 aob36 = ob6.position - attacker3.position;
        Vector3 aob41 = ob1.position - attacker4.position;        Vector3 aob42 = ob2.position - attacker4.position;        Vector3 aob43 = ob3.position - attacker4.position;
        Vector3 aob44 = ob4.position - attacker4.position;        Vector3 aob45 = ob5.position - attacker4.position;        Vector3 aob46 = ob6.position - attacker4.position;
        Vector3 aob51 = ob1.position - attacker5.position;        Vector3 aob52 = ob2.position - attacker5.position;        Vector3 aob53 = ob3.position - attacker5.position;
        Vector3 aob54 = ob4.position - attacker5.position;        Vector3 aob55 = ob5.position - attacker5.position;        Vector3 aob56 = ob6.position - attacker5.position;
        Vector3 aob61 = ob1.position - attacker6.position;        Vector3 aob62 = ob2.position - attacker6.position;        Vector3 aob63 = ob3.position - attacker6.position;
        Vector3 aob64 = ob4.position - attacker6.position;        Vector3 aob65 = ob5.position - attacker6.position;        Vector3 aob66 = ob6.position - attacker6.position;*/

        att1.velocity = self_force(a11, a12, a13, a14, a15, ang11, ang12, ang13, ang14, ang15) + mutual_attraction(ad11, ad12, ad13, ad14, ad15, ad16); 
        att2.velocity = self_force(a21, a22, a23, a24, a25, ang21, ang22, ang23, ang24, ang25) + mutual_attraction(ad21, ad22, ad23, ad24, ad25, ad26);
        att3.velocity = self_force(a31, a32, a33, a34, a35, ang31, ang32, ang33, ang34, ang35) + mutual_attraction(ad31, ad32, ad33, ad34, ad35, ad36);
        att4.velocity = self_force(a41, a42, a43, a44, a45, ang41, ang42, ang43, ang44, ang45) + mutual_attraction(ad41, ad42, ad43, ad44, ad45, ad46);
        att5.velocity = self_force(a51, a52, a53, a54, a55, ang51, ang52, ang53, ang54, ang55) + mutual_attraction(ad51, ad52, ad53, ad54, ad55, ad56);
        att6.velocity = self_force(a61, a62, a63, a64, a65, ang61, ang62, ang63, ang64, ang65) + mutual_attraction(ad61, ad62, ad63, ad64, ad65, ad66);

        def1.velocity = self_force(d11, d12, d13, d14, d15, dang11, dang12, dang13, dang14, dang15) + mutual_repulsionion(ad11, ad12, ad13, ad14, ad15, ad16); 
        def2.velocity = self_force(d21, d22, d23, d24, d25, dang21, dang22, dang23, dang24, dang25) + mutual_repulsionion(ad21, ad22, ad23, ad24, ad25, ad26);
        def3.velocity = self_force(d31, d32, d33, d34, d35, dang31, dang32, dang33, dang34, dang35) + mutual_repulsionion(ad31, ad32, ad33, ad34, ad35, ad36);
        def4.velocity = self_force(d41, d42, d43, d44, d45, dang41, dang42, dang43, dang44, dang45) + mutual_repulsionion(ad41, ad42, ad43, ad44, ad45, ad46);
        def5.velocity = self_force(d51, d52, d53, d54, d55, dang51, dang52, dang53, dang54, dang55) + mutual_repulsionion(ad51, ad52, ad53, ad54, ad55, ad56);
        def6.velocity = self_force(d61, d62, d63, d64, d65, dang61, dang62, dang63, dang64, dang65) + mutual_repulsionion(ad61, ad62, ad63, ad64, ad65, ad66);

        cam.position = transform.position + offset;
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
        float r1 = 6.5f;   float r2 = 12f;
        float vmax = 250f;
        Vector3 vnet, v1, v2, v3, v4, v5;
        if (p1.magnitude >= r1 && p1.magnitude<=r2)
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
        vnet= alpha1 * (vr + va);
        return vnet;
    }
    static Vector3 mutual_attraction(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, Vector3 p5, Vector3 p6)
    {
        float vmax = 2.5f;
        Vector3 v1 = p1.normalized * vmax;
        Vector3 v2 = p2.normalized * vmax;
        Vector3 v3 = p3.normalized * vmax;
        Vector3 v4 = p4.normalized * vmax;
        Vector3 v5 = p5.normalized * vmax;
        Vector3 v6 = p6.normalized * vmax;
        Vector3 vnet = v1 + v2 + v3 + v4 + v5 + v6;
        return vnet;
    }
    static Vector3 mutual_repulsionion(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, Vector3 p5, Vector3 p6)
    {
        float d0 = 50f;
        float vrmax = 5f;
        float alpha = 300f;
        Vector3 v,v1,v2,v3,v4,v5,v6;
        if (p1.magnitude <= d0)
        {
           v1 = alpha*(1 / p1.sqrMagnitude) * (1 / p1.magnitude - 1 / d0)*p1.normalized * vrmax;
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
        v = v1 + v2 + v3 + v4 + v5 + v6;
        return v;
    }
}
