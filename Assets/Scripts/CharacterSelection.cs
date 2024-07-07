using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using FishNet.Connection;
using FishNet.Managing.Scened;
using FishNet.Object;
using JetBrains.Annotations;

public class CharacterSelection : NetworkBehaviour
{
    [SerializeField] private List<GameObject> characters = new List<GameObject>();
    [SerializeField] private GameObject characterSelectorPanel;
    [SerializeField] private GameObject canvasObject;

    public override void OnStartClient()
    {
        base.OnStartClient();

        if(!base.IsOwner)
            canvasObject.SetActive(false);
    }

    private void Start()
    {
        characterSelectorPanel.SetActive(true);
    }

    public void SpawnArslan()
    {
        characterSelectorPanel.SetActive(false);
        Spawn(0, LocalConnection);
    }
    public void SpawnSuzan()
    {
        characterSelectorPanel.SetActive(false);
        Spawn(1, LocalConnection);
    }

    [ServerRpc(RequireOwnership = false)]
    void Spawn(int spawnIndex, NetworkConnection con)
    {
        GameObject player = Instantiate(characters[spawnIndex], SpawnPoint.instance.transform.position, Quaternion.identity);
        Spawn(player, con);
    }
}
