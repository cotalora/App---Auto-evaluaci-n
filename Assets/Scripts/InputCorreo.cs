using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputCorreo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputField iField = GetComponent<InputField>();
        iField.characterValidation = InputField.CharacterValidation.EmailAddress;
    }
}
