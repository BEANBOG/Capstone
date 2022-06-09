using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Message[] messages;
    public Actor[] actors;
    public Transform talkDetect;
    public float rayDist;
    void Update()
    {
        RaycastHit2D reveal = Physics2D.Raycast(talkDetect.position, Vector2.right * transform.localScale, rayDist);

        if(reveal.collider != null && reveal.collider.tag == "Deaf")
        {
            if(Input.GetKey(KeyCode.R))
            {
                StartDialogue();
            }
        }
    }
    public void StartDialogue()
    {
        FindObjectOfType<DialogueManager>().OpenDialogue(messages,actors);
    }
}

[System.Serializable]
public class Message
{
    public int actorId;
    public string message;
}

[System.Serializable]
public class Actor
{
    public string name;
    public Sprite sprite;
}
