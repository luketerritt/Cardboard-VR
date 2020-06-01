using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KeypadUiInteract : MonoBehaviour
{
    //Input and combination
    public string inputKeys = "";
    public string combination;

    public Image[] inputDots = new Image[4];

    public Color defaultDot = new Color(123, 123, 123), filledDot = new Color(255, 255, 255);

    public TextMeshProUGUI back;

    public bool lockScreen = false;

    //Animator States
    /*
    Animator animator;
    AnimatorStateInfo currentState;
    readonly int emptyStateHash = Animator.StringToHash("Base Layer.EmptyState");
    */

    private void Start()
    {
        //animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (inputKeys.Length == combination.Length)
        {
            Debug.Log(inputKeys);
            if (combination == inputKeys)
            {
                Debug.Log("Correct");
                if (lockScreen)
                {
                    SceneManager.LoadScene("Home");
                }
                else
                {
                    transform.root.gameObject.SetActive(false);
                }
                //Correct Combo
            }
            else
            {
                Debug.Log("Incorrect");
                for (int i = 0; i < inputKeys.Length; i++)
                {
                    inputDots[i].color = defaultDot;
                }
                //Incorrect Combo
            }
            inputKeys = "";

        }

        if (inputKeys.Length == 0)
        {
            back.text = "Back";
        }
        else
        {
            back.text = "Delete";
        }
    }

    /// <summary>
    /// Appends the pressed key to the internal combination string
    /// </summary>
    /// <param name="key">The key to add</param>
    public void AddKey(TextMeshProUGUI key)
    {
        inputKeys += key.text;
        inputDots[inputKeys.Length - 1].color = filledDot;
    }

    /// <summary>
    /// Clears the internal combination string
    /// </summary>
    public void Clear()
    {
        inputKeys = "";
    }

    /// <summary>
    /// Removes the last key from tthe internal combination string
    /// </summary>
    public void Delete()
    {
        if (inputKeys.Length != 0)
        {
            inputKeys = inputKeys.Substring(0, inputKeys.Length - 1);
        }
        else
        {
            Clear();
        }
    }

    public void Back(GameObject activate)
    {
        if (inputKeys.Length != 0)
        {
            inputDots[inputKeys.Length - 1].color = defaultDot;
            inputKeys = inputKeys.Substring(0, inputKeys.Length - 1);
        }
        else
        {
            activate.SetActive(true);
            transform.root.gameObject.SetActive(false);
        }
    }

    /*

    /// <summary>
    /// Closes (slides out) the keypad
    /// </summary>
    public void CloseKeypad()
    {
        animator.SetTrigger("closeKeypad");
    }

    /// <summary>
    /// Opens (slides in) the keypad
    /// </summary>
    public void OpenKeypad()
    {
        animator.SetTrigger("openKeypad");
    }

    */
}
