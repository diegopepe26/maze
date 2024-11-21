using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject finishBox;
    public bool playerInRange;

    // Start is called before the first frame update
    void Start()
    {
        // Assicura che la schermata sia nascosta all'inizio
        finishBox.SetActive(false);
    }

    void Update()
    {
        // Non è necessario alternare qui lo stato di finishBox
        // La logica di attivazione/disattivazione è gestita da OnTriggerEnter2D e OnTriggerExit2D
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            finishBox.SetActive(true); // Attiva la schermata quando il player entra
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            finishBox.SetActive(false); // Disattiva la schermata quando il player esce
        }
    }
}
