using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour {
    private GameObject _mainCamera;
    [SerializeField]
    private RaycastHit _hittedTarget;

    private static PlayerCasting instance = null;

    public static PlayerCasting Instance
    {
        get{return instance;}
    }

    public RaycastHit HittedTarget
    {
        get { return _hittedTarget; }

        set { _hittedTarget = value; }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    // Use this for initialization
    void Start () {
        _hittedTarget = new RaycastHit();
        _mainCamera = GameObject.FindWithTag("MainCamera");
    }
	
	// Update is called once per frame
	void Update () {
        int x = Screen.width / 2;
        int y = Screen.height / 2;

        Ray ray = _mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
        Physics.Raycast(ray, out _hittedTarget);
    }
}
