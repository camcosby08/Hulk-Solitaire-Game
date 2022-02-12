using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    Vector3 mousePosition;
    
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
       
        if (Input.GetMouseButton(0))
        {
           GetMouseClick();
        } 
    }

    /*void OnMouseClick()
    {

        mousePosition = Camera.main.ScreenToWorldPoint(
                               new Vector3(Input.mousePosition.x,
                               Input.mousePosition.y, -10));
        RaycastHit2D hit;
        hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit)
        {
            Rigidbody2D wasHit = hit.rigidbody;
            if (wasHit.gameObject.name == "Deck")
            {

                TheLogger.PrintLog(wasHit.tag);

            }

        }
    }*/

    // Might want to change to on click down, need to investigate this
    void GetMouseClick(){
        //To store the mouse's position

        mousePosition = Camera.main.ScreenToWorldPoint(
                               new Vector3(Input.mousePosition.x,
                               Input.mousePosition.y, -10));
        // https://docs.unity3d.com/ScriptReference/RaycastHit-collider.html 
        RaycastHit2D hit;

       // if (Input.GetMouseButton(0)){
            
        

            hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            
            // What we will do depends on what has been clicked
            if (hit){

                // The tag is associated with various game objects
                
                Rigidbody2D wasHit = hit.rigidbody;
                Selectable cardFace = wasHit.GetComponent<Selectable>();
            
                wasHit.transform.forward = Vector3.forward;
            

                if (!cardFace.IsFaceUp())  
                {
                    return;
                    //cardFace.FlipCard();
                }
                wasHit.position = mousePosition;
                

                //string whatHit = hit.collider.tag;
                //print(whatHit);

                /*switch(whatHit){
                    case "Deck":
                        Deck();
                        break;
                    case "Card":
                        Card();
                        break;
                    case "Top":
                        Top();
                        break;
                    case "Bottom":
                        Bottom();
                        break;
                    default:
                    //This is the bad place
                        print("You missed");
                        break;
                }*/
            }
        //}
    }

    // This is where we will call the algorithm for if Deck is touched
    void Deck(){
        print("Hit Deck");
        // Deal cards
        print("Deal 1 or 3 more cards");
    }

    // This is where we will call the algorithm for if a card is selected
    void Card(){
        print("Hit Card");
        // select the card for moving somewhere
        // if double clicked, and can go to top spot, go there
        print("Pick this card up to move it somewhere");
        print("But if double clicked, and can go to top, move it there");
    }

    // Call algorithm for if top spot is selected
    void Top(){
        print("Hit Top");
        // cards on top can be moved back to the bottom
        print("Pick this card up to move it somewhere");
    }

    // Call algorithm for if bottom spot is selected
    void Bottom(){
        print("Hit Bottom");
        // cards on the bottom can be picked up individually or as a stack
        print("Pick up this card (or cards if stack selected)");
        // if stack, make sure it is moveable as a stack
    }
}
