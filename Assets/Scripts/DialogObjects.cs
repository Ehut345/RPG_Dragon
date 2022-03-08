using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[Serializable]
public class DialogObject
{
    public string[] dialogs;
    public string charactesNames;
    public int questNumber;
}
public class DialogObjects : MonoBehaviour
{
    public Player player;
    public Text nameTextBox;
    public Text dialogTextBox;
    public int curretDialogNumber = 0;
    private DialogObject currentDialog = null;
    public NonPlayerCharacter npc;
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
            dialogTextBox.text = tempdialogs.dialogs[curretDialogNumber];
        }
        else
        {
            npc.diaglogText.SetActive(false);
            curretDialogNumber = 0;
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
        //player = FindObjectOfType<Player>();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
