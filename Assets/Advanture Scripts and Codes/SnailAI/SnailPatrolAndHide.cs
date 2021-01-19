﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailPatrolAndHide : MonoBehaviour
{
	public float speed = 10f;
	public bool MoveRight;
	public Animator animator;
	private bool isInvulnerable = false;
	private float ignoreCollisionOverTime = 3.4f;
	public int snailHideDamage = -20;

	void Update()
	{
		if (MoveRight)
		{
			transform.Translate(2 * Time.deltaTime * speed, 0, 0);
			transform.localScale = new Vector2(-60, 60);
		}
		else
		{
			transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
			transform.localScale = new Vector2(60, 60);
		}
	}
	void OnTriggerEnter2D(Collider2D trig)
	{
		if (trig.gameObject.CompareTag("ShootAtMe"))
		{

			if (MoveRight)
			{
				MoveRight = false;
			}
			else
			{
				MoveRight = true;
			}
		}
		if (trig.gameObject.CompareTag("Hide_AI"))
		{
			StartCoroutine(GetInvulnerable());
		}
		if (trig.gameObject.tag == "Player_Knight_Advanturer"/* && other.gameObject.tag == "Hide_AI"*/)
		{
			HealthKnightAdvanturer eHealth = trig.gameObject.GetComponent<HealthKnightAdvanturer>();
			eHealth.ModifyHealth(snailHideDamage);
		}
	}
	IEnumerator GetInvulnerable()
	{
		Physics2D.IgnoreLayerCollision(21, 17, true); ;
		speed = 0f;
		isInvulnerable = true;
		animator.SetBool("IsHiding", isInvulnerable);
		yield return new WaitForSeconds(ignoreCollisionOverTime);
		speed = 10f;
		isInvulnerable = false;
		animator.SetBool("IsHiding", isInvulnerable);
		Physics2D.IgnoreLayerCollision(21, 17, false);
	}
}
