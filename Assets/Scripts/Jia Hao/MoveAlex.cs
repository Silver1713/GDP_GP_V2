using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAlex : MonoBehaviour
{
    ///<summary>
    /// This is use to move the transform thru nodes
    /// ...
    /// </summary>
    private int cIndex;
    private int numOfLocation;
    public Transform currentNode;
    private Rigidbody2D transformRigidBody;
    private Transform[] nodeList;
    public float minDistance = float.Epsilon;
    public bool inDialouge;
    public float speed;
    private Vector3 targetPosition;
    bool comeBack = false;
    public bool deEnded;
   

    private void Start()
    {
        cIndex = 0;
        
        nodeList = LocationManager2.locations;
        numOfLocation = LocationManager2.locations.Length;
        transformRigidBody = GetComponent<Rigidbody2D>();
        currentNode = LocationManager2.locations[cIndex];
        
    }

    private void Update()
    {
        deEnded = FindObjectOfType<DialogueManager>().isDiaEnded;
        if (FindObjectOfType<AlexTrigger>().isAlexTrigger == false)
        {
            return;
        }
        else
        {
            if (Vector2.Distance(transform.position, currentNode.position) <= minDistance)
            {
                getNextNode();
            }
            else
            {
                if (currentNode != null)
                {
                    targetPosition = currentNode.position;
                    transformRigidBody.MovePosition(Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed));
                }
            }
        }
        
    }

    void getNextNode()
    {
        if (cIndex < numOfLocation - 1 && comeBack == false)
        {
            cIndex++;
            currentNode = nodeList[cIndex];
        } else
        {
            if (inDialouge == false)
            {
                inDialouge = true;
                GetComponent<DialogueTrigger2>().TriggerDialogue();
               
            } else if (FindObjectOfType<DialogueManager>().isDiaEnded == true)
            {
                if (cIndex > 0)
                {
                    cIndex--;
                    currentNode = nodeList[cIndex];
                    comeBack = true;
                } else
                {
                    comeBack = true;
                }
            }
        }
    }
    
}
