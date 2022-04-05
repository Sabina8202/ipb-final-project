using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class Register : MonoBehaviour {
    public GameObject username;
    public GameObject email;
    public GameObject password;
    public GameObject confPassword;

    private string Username;
    private string Email;
    private string Password;
    private string ConfPassword;
    private string form;
    private bool EmailValid = false;

    



    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void RegisterButton(){
        bool UN = false;
        bool EM = false;
        bool PW = false;
        bool CPW = false;


        if(Username!=""){
          if(System.IO.File.Exists(@"D:/UnityFolder" +Username+ ".txt")){
            UN = true;
            Debug.Log("File exists");
         }
         else{
            Debug.LogWarning("Username Taken");
             }
        } else{
            Debug.LogWarning("Username is empty");
        }

        if(Email!=""){
            if(EmailValid){
                if(Email.Contains("@")){
                    if(Email.Contains(".")){
                        EM = true;
                    }
                    else{
                        Debug.LogWarning("Email is invalid");
                    }
                }
                else{
                    Debug.LogWarning("Email is invalid");
                }
            }else{
                Debug.LogWarning("Email is invalid");
            }
        }else{
            Debug.LogWarning("Email is empty");
        }
       
    
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if(username.GetComponent<InputField>().isFocused)
            {
                email.GetComponent<InputField>().Select();
            }
            if(email.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
            if(password.GetComponent<InputField>().isFocused)
            {
                confPassword.GetComponent<InputField>().Select();
            }
            
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(Password != "" && Email != "" && Password != "" && ConfPassword != "")
            {
                RegisterButton();
            }
        }
    
        Username = username.GetComponent<InputField>().text;
        Email = email.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
        ConfPassword = confPassword.GetComponent<InputField>().text;

    }
}
