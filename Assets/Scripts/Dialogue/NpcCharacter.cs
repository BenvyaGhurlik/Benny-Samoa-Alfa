using UnityEngine;
using DialogueEditor;
using JetBrains.Annotations;

public class NpcCharacter : MonoBehaviour
{
    public NPCConversation myConversation;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ConversationManager.Instance.StartConversation(myConversation);
        }
    }
}
