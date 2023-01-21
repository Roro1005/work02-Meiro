using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class Gui : MonoBehaviour
{
    [SerializeField] private GameObject m_copsel;
    public GameObject Copsel { get { return m_copsel; } }

    [SerializeField] private UnityEngine.UI.Button m_UpButton;
    public UnityEngine.UI.Button UpButton { get { return m_UpButton; } }

    [SerializeField] private UnityEngine.UI.Button m_DownButton;
    public UnityEngine.UI.Button DownButton { get { return m_DownButton; } }
    [SerializeField] private UnityEngine.UI.Button m_LButton;
    public UnityEngine.UI.Button LButton { get { return m_LButton; } }
    [SerializeField] private UnityEngine.UI.Button m_RButton;
    public UnityEngine.UI.Button RButton { get { return m_RButton; } }
    // Start is called before the first frame update
    void Start()
    {
        System.IDisposable UpButtonListener = UpButton.OnPointerDownAsObservable().Subscribe(_ =>
        {
            Vector3 posishon = Copsel.transform.position;
            posishon.z += 100.0f * Time.deltaTime; ;
            Copsel.transform.position = posishon;
        });

        System.IDisposable DownButtonListener = DownButton.OnPointerDownAsObservable().Subscribe(_ =>
        {
            Vector3 posishon = Copsel.transform.position;
            posishon.z -= 100.0f * Time.deltaTime; ;
            Copsel.transform.position = posishon;
        });

        System.IDisposable LButtonListener = LButton.OnPointerDownAsObservable().Subscribe(_ =>
        {
            Vector3 posishon = Copsel.transform.position;
            posishon.x -= 100.0f * Time.deltaTime; ;
            Copsel.transform.position = posishon;
        });
        System.IDisposable RButtonListener = RButton.OnPointerDownAsObservable().Subscribe(_ =>
        {
            Vector3 posishon = Copsel.transform.position;
            posishon.x += 100.0f * Time.deltaTime; ;
            Copsel.transform.position = posishon;
        });
    }


    // Update is called once per frame
    void Update()
    {
    }
}
