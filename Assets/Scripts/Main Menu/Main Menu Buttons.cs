using UnityEngine;

/*Placing any of the four start menu buttons into the envionerment and giving it this script
 * with a collider will automattically assign the command to the right button.
 */



public class Button_Test : MonoBehaviour {
    //Though this may not be the best way to do it, 
    //a boolean is assigned for if this gameobject can be clicked
    [SerializeField]
    bool clickable = false;
    [SerializeField]


    // Use this for initialization
    void Start(){
        clickable = false; //Clickable is set to false at start to ensure they're all false
    }
	private void OnMouseOver(){
        clickable = true; //When the cursor goes over the button's colider clickable becomes true
	}
	private void OnMouseExit(){
        clickable = false; //When the cursor leaves the button's coldier clickable becomes false
	}


	// Update is called once per frame
	void Update () { //If the mouse button is clicked and is hovering over the button, that button will be clicked
            if (Input.GetMouseButtonDown(0) && clickable){
            switch (gameObject.name){ //The buttons have to be named one of the cases in Unity for them to work
                case "Start_Button":
                    Debug.Log("Start Button Pressed"); // Result of clicking on the Start Button
                    break;
                case "Options_Button":
                    Debug.Log("Options Button Pressed"); //Result of clicking on the options button
                    break;
                case "About_Button":
                    Debug.Log("About Button Pressed"); //Result of click on the About button
                    break;
                case "Exit_Button":
                    Debug.Log("Exit Button Pressed"); // result of clicking on the Exit button
                    break;
            }
        }
	}
}
