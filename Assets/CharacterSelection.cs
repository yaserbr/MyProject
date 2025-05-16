using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characters;   
    private int selectedCharacter = 0;  
    public GameObject BlueRocketButton;
    public GameObject PlaneButton;
    public GameObject UFOButton;



    void Start()
    {
     
        foreach (GameObject character in characters)
        {
            character.SetActive(false);
        }

        
        characters[selectedCharacter].SetActive(true);
        Debug.Log("Default character shown: " + characters[selectedCharacter].name);



        int coins = PlayerPrefs.GetInt("CoinsCollected", 0);
        if (coins >= 5)
        {
            BlueRocketButton.SetActive(true);
        }
        if (coins >= 10)
        {
            PlaneButton.SetActive(true);
        }
        if (coins >= 15)
        {
            UFOButton.SetActive(true);
        }

    }

    
    public void SelectCharacter(int index)
    {
        if (index >= 0 && index < characters.Length)
        {
            
            characters[selectedCharacter].SetActive(false);

          
            selectedCharacter = index;
            characters[selectedCharacter].SetActive(true);

            Debug.Log("Character selected: " + characters[selectedCharacter].name);
        }
        else
        {
            Debug.LogError("Invalid character index selected: " + index);
        }
    }

     public void StartGame()
    {
         if (selectedCharacter >= 0 && selectedCharacter < characters.Length)
        {
            PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);
            Debug.Log("Character index saved: " + selectedCharacter);
        }
        else
        {
            Debug.LogError("Invalid character index selected: " + selectedCharacter);
        }

         SceneManager.LoadScene(1, LoadSceneMode.Single);  
    }


}
