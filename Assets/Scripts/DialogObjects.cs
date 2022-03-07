using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[SerializeField]
public class DialogObject
{
    public string[] dialogs;
    public string charactesNames;
    public int questNumber;
}
public class DialogObjects : MonoBehaviour
{
    private Player player;
    public Text nameTextBox;
    public Text dialogTextBox;
    public int curretDialogNumber = 0;
    private DialogObject currentDialog = null;
    [Header("DialogObjects")]
    public DialogObject dialog1;
    private void OnEnable()
    {
        switch (player.dialogNumber)
        {
            case 1:
                Debug.Log("need to replace with dialogbox1");
                PlayDialog(dialog1);
                currentDialog = dialog1;
                break;
            default:
                break;
        }
    }

    private void PlayDialog(DialogObject tempdialogs)
    {
        nameTextBox.text = tempdialogs.charactesNames;
        if (curretDialogNumber < tempdialogs.dialogs.Length)
        {
            dialogTextBox.text = tempdialogs.dialogs[0];
        }
        else
        {
            //end the dialog
        }
    }
    public void NextDialogButton()
    {
        if (currentDialog != null)
        {
            //need to add the logic for next button
            curretDialogNumber++;
            PlayDialog(currentDialog);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
