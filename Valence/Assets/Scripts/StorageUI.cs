using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StorageUI : MonoBehaviour {

    public Transform infoUI;

    public Text potatoeAmount;
    public Text carrotAmount;
    public Text lettuceAmount;
    public Text cabbageAmount;

    public GameController _gameController;

    // Use this for initialization

    //Bool checks if the user has clicked once or twice on the building
    //used to toggle between UI components
    bool checkClick;
    void Start () {
        
        //Find child UI gameobjects of this building
        infoUI = transform.Find("BuildingInfo");

        potatoeAmount = transform.Find("BuildingInfo/Inventory/Potatoes/PotatoeAmount").GetComponent<Text>();
        carrotAmount = transform.Find("BuildingInfo/Inventory/Carrots/CarrotAmount").GetComponent<Text>();
        lettuceAmount = transform.Find("BuildingInfo/Inventory/Lettuce/LettuceAmount").GetComponent<Text>();
        cabbageAmount = transform.Find("BuildingInfo/Inventory/Cabbage/CabbageAmount").GetComponent<Text>();

        _gameController = GameObject.Find("GameController").GetComponent<GameController>();

        checkClick = true;
    }

    void OnMouseDown(){

        if (checkClick){

            infoUI.gameObject.SetActive(true);

            checkClick = false;
        }
        else{

            infoUI.gameObject.SetActive(false);

            checkClick = true;
        }
    }

    // Update is called once per frame
    void Update () {
        potatoeAmount.text = _gameController.food.ToString();
        carrotAmount.text = _gameController.food.ToString();
        lettuceAmount.text = _gameController.food.ToString();
        cabbageAmount.text = _gameController.food.ToString();
    }
}
