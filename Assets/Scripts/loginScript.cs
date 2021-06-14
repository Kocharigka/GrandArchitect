using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loginScript : MonoBehaviour
{
    public InputField nickInput;
    public InputField nameInput;
    public InputField groupInput;
    public Text nickField;
    public Text nameField;
    public Text groupField;
    public Button loginButton;
    public Button logoutButton;
    private static  string nick="";
    private static string name="";
    private static string group="";
    public GameObject gmobj;
    private GameManager gm;
    private void Start()
    {
        gm = gmobj.GetComponent<GameManager>();
        if (nick != "" || name != "" || group != "")
        {
            nickField.text = nick;
            nameField.text = name;
            groupField.text = group;
            nickInput.gameObject.SetActive(false);
            nameInput.gameObject.SetActive(false);
            groupInput.gameObject.SetActive(false);

            nickField.gameObject.SetActive(true);
            nameField.gameObject.SetActive(true);
            groupField.gameObject.SetActive(true);
            loginButton.gameObject.SetActive(false);
            logoutButton.gameObject.SetActive(true);
        }
        else
        {
            Logout();
        }

    }
    // Start is called before the first frame update
    public void Login()
    {
        if(nickInput.text!="")
        {      
            nickField.text = nickInput.text;
            if (nick != nickInput.text)
            {
                nick = nickInput.text;
                gm.dropProgr();
            }
        }
        else
        {
            nickField.text = "<BLANK>";
            nick = "<BLANK>";
        }
        if (nameInput.text != "")
        {          
            nameField.text = nameInput.text;
            name = nameInput.text;
        }
        else
        {
            nameField.text = "<BLANK>";
            name = "<BLANK>";
        }
        if ( groupInput.text != "")
        {           
            groupField.text = groupInput.text;
            group = groupInput.text;
        }
        else
        {
            groupField.text = "<BLANK>";
            group = "<BLANK>";
        }
        gm.setNick(nick);
        nickInput.gameObject.SetActive(false);
        nameInput.gameObject.SetActive(false);
        groupInput.gameObject.SetActive(false);

        nickField.gameObject.SetActive(true);
        nameField.gameObject.SetActive(true);
        groupField.gameObject.SetActive(true);
        loginButton.gameObject.SetActive(false);
        logoutButton.gameObject.SetActive(true);
    }
    public void Logout()
    {
        nickField.text = "";
        nameField.text = "";
        groupField.text = "";
        nickInput.text = "";
        nameInput.text = "";
        groupInput.text = "";
        nick = "";
        name = "";
        group = "";

        nickInput.gameObject.SetActive(true);
        nameInput.gameObject.SetActive(true);
        groupInput.gameObject.SetActive(true);

        nickField.gameObject.SetActive(false);
        nameField.gameObject.SetActive(false);
        groupField.gameObject.SetActive(false);
        logoutButton.gameObject.SetActive(false);
        loginButton.gameObject.SetActive(true);
    }
}
