using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Interfaces;
using UnityEngine.SceneManagement;

public class Init : MonoBehaviour
{

    public Button NewGameButton;
    public Button LoadGameButton;
    public Button OptionsButton;

    public Slider ActionBarIndicator;
    private float _actionAmount;
    private float _actionReadyAmount=100f;
    private bool _actionAvailable;
    //GameState _gameState = new GameState();
    //MenuState _menuState = new MenuState();

    // Use this for initialization
    void Start()
    {

        NewGameButton.onClick.AddListener(() => { NewGame(NewGameButton); });


    }

    private void NewGame(Button btnPressed)
    {
        SceneManager.LoadScene("SystemView");
    }




    // Update is called once per frame
    void Update()
    {
        _actionAmount += Time.deltaTime * 5;

        ActionBarIndicator.minValue = 0f;
        ActionBarIndicator.maxValue = _actionReadyAmount;
        ActionBarIndicator.value = _actionAmount;

        if (_actionAmount >= _actionReadyAmount)
        {
            _actionAmount = _actionReadyAmount;
            _actionAvailable = true;

        }

    }
}
