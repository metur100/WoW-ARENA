﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOEAttackPrefab : MonoBehaviour
{
    public Rigidbody2D rb;
    public int damageDoneAOE = -50; //it deals 40 damage close range, 20 damage long range
    private readonly float speedOfMeleeAttack = 100f;

    void Start()
    {
        StartCoroutine(DestroyGameobject());
        rb.velocity = transform.right * speedOfMeleeAttack;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Slime_AI":
                SlimeHealthPatrol eHealth = other.gameObject.GetComponent<SlimeHealthPatrol>();
                eHealth.ModifyHealth(damageDoneAOE);
                break;
            case "Slime_AI_2":
                SlimeHealthPatrol2 eHealth1 = other.gameObject.GetComponent<SlimeHealthPatrol2>();
                eHealth1.ModifyHealth(damageDoneAOE);
                break;
            case "Slime_AI_3":
                SlimeHealthPatrol3 eHealth2 = other.gameObject.GetComponent<SlimeHealthPatrol3>();
                eHealth2.ModifyHealth(damageDoneAOE);
                break;
            case "Slime_AI_4":
                SlimeHealthPatrol4 eHealth3 = other.gameObject.GetComponent<SlimeHealthPatrol4>();
                eHealth3.ModifyHealth(damageDoneAOE);
                break;
            case "Trunk_AI":
                TrunkHealth eHealth4 = other.gameObject.GetComponent<TrunkHealth>();
                eHealth4.ModifyHealth(damageDoneAOE);
                break;
            case "Trunk_AI_2":
                TrunkHealth2 eHealth5 = other.gameObject.GetComponent<TrunkHealth2>();
                eHealth5.ModifyHealth(damageDoneAOE);
                break;
            case "Trunk_AI_3":
                TrunkHealth3 eHealth6 = other.gameObject.GetComponent<TrunkHealth3>();
                eHealth6.ModifyHealth(damageDoneAOE);
                break;
            case "Trunk_AI_4":
                TrunkHealth4 eHealth7 = other.gameObject.GetComponent<TrunkHealth4>();
                eHealth7.ModifyHealth(damageDoneAOE);
                break;
            case "Trunk_AI_5":
                TrunkHealth5 eHealth8 = other.gameObject.GetComponent<TrunkHealth5>();
                eHealth8.ModifyHealth(damageDoneAOE);
                break;
            case "Trunk_AI_6":
                TrunkHealth6 eHealth9 = other.gameObject.GetComponent<TrunkHealth6>();
                eHealth9.ModifyHealth(damageDoneAOE);
                break;
            case "Trunk_AI_7":
                TrunkHealth7 eHealth10 = other.gameObject.GetComponent<TrunkHealth7>();
                eHealth10.ModifyHealth(damageDoneAOE);
                break;
            case "Bee_AI":
                BeeHealth eHealth11 = other.gameObject.GetComponent<BeeHealth>();
                eHealth11.ModifyHealth(damageDoneAOE);
                break;
            case "Bee_AI_2":
                BeeHealth2 eHealth12 = other.gameObject.GetComponent<BeeHealth2>();
                eHealth12.ModifyHealth(damageDoneAOE);
                break;
            case "Snail_AI":
                SnailHealth eHealth13 = other.gameObject.GetComponent<SnailHealth>();
                eHealth13.ModifyHealth(damageDoneAOE);
                break;
            case "Snail_AI_2":
                SnailHealth2 eHealth14 = other.gameObject.GetComponent<SnailHealth2>();
                eHealth14.ModifyHealth(damageDoneAOE);
                break;
            case "Snail_AI_3":
                SnailHealth3 eHealth15 = other.gameObject.GetComponent<SnailHealth3>();
                eHealth15.ModifyHealth(damageDoneAOE);
                break;
            case "Snail_AI_4":
                SnailHealth4 eHealth16 = other.gameObject.GetComponent<SnailHealth4>();
                eHealth16.ModifyHealth(damageDoneAOE);
                break;
            case "Turtle_AI":
                TurtleHealth eHealth17 = other.gameObject.GetComponent<TurtleHealth>();
                eHealth17.ModifyHealth(damageDoneAOE);
                break;
            case "Turtle_AI_2":
                TurtleHealth2 eHealth18 = other.gameObject.GetComponent<TurtleHealth2>();
                eHealth18.ModifyHealth(damageDoneAOE);
                break;
            case "Turtle_AI_3":
                TurtleHealth3 eHealth19 = other.gameObject.GetComponent<TurtleHealth3>();
                eHealth19.ModifyHealth(damageDoneAOE);
                break;
            case "BlueBird_AI":
                BlueBirdHealth eHealth20 = other.gameObject.GetComponent<BlueBirdHealth>();
                eHealth20.ModifyHealth(damageDoneAOE);
                break;
            case "BlueBird_AI_2":
                BlueBirdHealth2 eHealth21 = other.gameObject.GetComponent<BlueBirdHealth2>();
                eHealth21.ModifyHealth(damageDoneAOE);
                break;
            case "BlueBird_AI_3":
                BlueBirdHealth3 eHealth22 = other.gameObject.GetComponent<BlueBirdHealth3>();
                eHealth22.ModifyHealth(damageDoneAOE);
                break;
            case "Ghost_AI":
                GhostHealth eHealth23 = other.gameObject.GetComponent<GhostHealth>();
                eHealth23.ModifyHealth(damageDoneAOE);
                break;
            case "Suprise_Box":
                SupriseBoxHealth eHealth24 = other.gameObject.GetComponent<SupriseBoxHealth>();
                eHealth24.ModifyHealth(damageDoneAOE);
                break;
            case "Suprise_Box_2":
                SupriseBoxHealth2 eHealth25 = other.gameObject.GetComponent<SupriseBoxHealth2>();
                eHealth25.ModifyHealth(damageDoneAOE);
                break;
            case "Suprise_Box_3":
                SupriseBoxHealth3 eHealth26 = other.gameObject.GetComponent<SupriseBoxHealth3>();
                eHealth26.ModifyHealth(damageDoneAOE);
                break;
            case "Bat_AI":
                BatHealth eHealth27 = other.gameObject.GetComponent<BatHealth>();
                eHealth27.ModifyHealth(damageDoneAOE);
                break;
            case "GreenPig_AI":
                GreenPigHealth eHealth28 = other.gameObject.GetComponent<GreenPigHealth>();
                eHealth28.ModifyHealth(damageDoneAOE);
                break;
            case "Plant_AI":
                PlantHealth eHealth29 = other.gameObject.GetComponent<PlantHealth>();
                eHealth29.ModifyHealth(damageDoneAOE);
                break;
            case "Plant_AI_2":
                PlantHealth2 eHealth30 = other.gameObject.GetComponent<PlantHealth2>();
                eHealth30.ModifyHealth(damageDoneAOE);
                break;
            case "Radish_AI":
                RadishHealth eHealth31 = other.gameObject.GetComponent<RadishHealth>();
                eHealth31.ModifyHealth(damageDoneAOE);
                break;
            case "Bunny_AI":
                BunnyHealth eHealth32 = other.gameObject.GetComponent<BunnyHealth>();
                eHealth32.ModifyHealth(damageDoneAOE);
                break;
            case "Mushroom_AI":
                MushroomHealth eHealth33 = other.gameObject.GetComponent<MushroomHealth>();
                eHealth33.ModifyHealth(damageDoneAOE);
                break;
        }
    }
    IEnumerator DestroyGameobject()
    {
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
}