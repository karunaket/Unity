using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    PlayerController _playerController;
    [SerializeField] GameObject _teleportLocation;

    Coroutine _coroutine;

    private void Start()
    {
        _playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _coroutine = StartCoroutine(TeleportDelay()); 
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            // StopAllCoroutines();

            StopCoroutine(_coroutine);
        }
    }

    IEnumerator TeleportDelay()  // Allows to skip frames inside the game...
    {
        _playerController._disableMovement = true;
        // yield return null;
        yield return new WaitForSeconds(3.5f);
        // After pressing Space it will wait for 3.5s and then further steps will be executed...

        gameObject.transform.position = _teleportLocation.transform.position;
        yield return null;
        _playerController._disableMovement = false;
    }
}
