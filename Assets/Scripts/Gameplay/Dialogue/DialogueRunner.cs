using UnityEngine;
using UnityEngine.UI;
using Dialogue;

public class DialogueRunner : MonoBehaviour 
{
    [SerializeField]
    DialogueGraph currentConversation;

    [SerializeField]
    Text dialogueBox;

    [SerializeField]
    Text[] responses;

    public void ShowNextDialogue()
    {
        dialogueBox.text = currentConversation.current.text;
        int currentResponse = -1;
        for(int i = 0; i < currentConversation.current.answers.Count; i++)
        {
            responses[i].text = currentConversation.current.answers[i].text;
            currentResponse = i;
        }
        for(int i = currentResponse + 1; i < responses.Length; i++)
        {
            responses[i].text = "";
        }
    }

    public void ChooseDialogue(int choiceIndex)
    {
        currentConversation.AnswerQuestion(choiceIndex);
    }

    void Start()
    {
        currentConversation.Restart();
        ShowNextDialogue();
    }
}
