using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueBrackley dialogueBrackley;

    public void StartDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogueBrackley);
    }
}
