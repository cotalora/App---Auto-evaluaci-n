using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginData : MonoBehaviour
{
    public string pNombre;
    public string pApellido;
    public string sNombre;
    public string sApellido;
    public string codigo;
    public string correo;
    public GameObject errrr;

    float count = 0;

    protected Scene defaultScene;
 
     void Awake()
    {
        defaultScene = gameObject.scene;
    }

    public void ResetDestroyOnLoad()
    {
        SceneManager.MoveGameObjectToScene(gameObject, defaultScene);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pNombre != "" && pApellido != "" && codigo != "" && correo != "")
        {
            DontDestroyOnLoad(this.gameObject);
        }

        if (errrr.activeSelf)
        {
            count += Time.deltaTime;
            if (count >= 3)
            {
                errrr.SetActive(false);
                count = 0;
            }
        }
    }

    public IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("pNombre", pNombre);
        form.AddField("sNombre", sNombre);
        form.AddField("pApellido", pApellido);
        form.AddField("sApellido", sApellido);
        form.AddField("codigo", codigo);
        form.AddField("correo", correo);

        WWW www = new WWW("https://invensoft.tech/AutoEvaluacion/register.php", form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("Usuario creado");
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("Usuario fallo " + www.text);
            if (www.text == "17")
            {
                errrr.SetActive(true);
            }
        }
    }
}
