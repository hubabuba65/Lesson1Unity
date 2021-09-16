using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour {

    private void Start() {

        //CalculateNumbers();
        //CalculateTwoNumbers(20, 35);

        //float sum = ReturnNumbers();
        //Debug.Log("suma to " + sum);

        Debug.Log("sum of a and b is " + ReturnTwoNumbers(20, 98));

        //Wyświetli informacje z skryptu o nazwie Class();
        //Class comando = new Class(1, 2, "Comando");

        //comando.Health = 100;

        //comando.Info();

        //comando.Info();
        //archer.Info();
    }

    //a function that dosen't return a value and dosen't take parameters
    void CalculateNumbers() {

        float a = 5;
        float b = 20;
        float c = b + a;

        Debug.Log("suma a i b =" + c);
    }

    // a function that dosen't return value but takes parameters
    void CalculateTwoNumbers(float a, float b) {
        Debug.Log("suma a i b to: " + (a + b));
    }

    float ReturnNumbers() {
        return 20 + 35;
    }

    float ReturnTwoNumbers(float a, float b) {
        return a + b;
    }
}

/*
    //variables
    float speed = 5f;

    int health = 100;

    string name = "Comando";

    bool isDead = false; 
*/

/*
    //Awake is the first function that is called
    void Awake() {

    }

    //Start is the 3rd function that is called
    void Start() {

    }

*/