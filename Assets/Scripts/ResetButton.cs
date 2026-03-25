using UnityEngine;
using UnityEngine.Events;
using Autohand;

public class Reset_Button : PhysicsGadgetButton
{
    [SerializeField] private string tagReset = "reset";

    private GameObject[] objReset;
    private Vector3[] posIni;
    private Quaternion[] rotIni;
    private Rigidbody[] rbCache;

    protected new void Start()
    {
        base.Start();
        GuardarPosicionesIniciales();

    }

    void GuardarPosicionesIniciales()
    {
        objReset = GameObject.FindGameObjectsWithTag(tagReset);
        posIni = new Vector3[objReset.Length];
        rotIni = new Quaternion[objReset.Length];

        for (int i = 0; i < objReset.Length; i++)
        {
            posIni[i] = objReset[i].transform.position;
            rotIni[i] = objReset[i].transform.rotation;
        }

    }

    public void ResetearObjetos()
    {
        for (int i = 0; i < objReset.Length; i++)
        {
            if (objReset[i] != null)
            {
                objReset[i].transform.position = posIni[i];
                objReset[i].transform.rotation = rotIni[i];

                Rigidbody rb = objReset[i].GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.linearVelocity = Vector3.zero;
                    rb.angularVelocity = Vector3.zero;
                }
            }
        }
    }
}