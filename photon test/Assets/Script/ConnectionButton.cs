using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConnectionButton : MonoBehaviour
{
   public  int status = 0;
    public LobbyController lobbyController;
    private void Update()
    {
        switch (status)
        {
            case 0:
                GetComponentInChildren<UnityEngine.UI.Text>().text = "Start";
                gameObject.GetComponent<Button>().interactable = true;
                break;
            case 1:
                GetComponentInChildren<UnityEngine.UI.Text>().text = "Loading";
                gameObject.GetComponent<Button>().interactable = false;
                break;
            case 2:
                GetComponentInChildren<UnityEngine.UI.Text>().text = "Exit";
                gameObject.GetComponent<Button>().interactable = true;
                break;
        }
    }
   
    public void OnClicked()
    {
        switch (status)
        {
            case 0:
                lobbyController.StartConnection();
                break;
            case 1:
                
                break;
            case 2:
                lobbyController.CancelConnection();
                break;
        }
    }
}
