using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    // Start is called before the first frame update
    public int lives = 3;
    public Image[] livesUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){

    }
        private void OnCollisionEnter2D(Collision2D colision) {
            if(colision.collider.gameObject.tag == "enemy"){
                Destroy(colision.gameObject);
                lives -=1;
                for(int i = 0; i <livesUI.Length; i++){
                    livesUI[i].enabled = true;
                if(i < lives){
                    livesUI[i].enabled =true;
                }
                else{
                    livesUI[i].enabled =false;
                }
                if(lives <=0){
                    Destroy(gameObject);
                }}
            }

        }
    }

