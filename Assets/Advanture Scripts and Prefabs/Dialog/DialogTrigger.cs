﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public GameObject activateDialogStart;
    public GameObject activateGhostDialog;
    public PlayerMovementAdvanturerKnight moveSpeed;
    public GameObject triggerDialogStart;
    public GameObject triggerGhostDialog;
    public GameObject triggerQuest;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("MonD_NPC"))
        {
            activateDialogStart.SetActive(true);
            triggerQuest.SetActive(true);
            moveSpeed.normalMovementSpeed = 0f;
            Destroy(triggerDialogStart);
        }
        if (other.CompareTag("MonD_Ghost"))
        {
            activateGhostDialog.SetActive(true);
            moveSpeed.normalMovementSpeed = 0f;
            Destroy(triggerGhostDialog);
        }
        
    }
}
