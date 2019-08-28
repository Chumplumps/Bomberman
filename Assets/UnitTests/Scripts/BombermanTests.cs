using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.TestTools;
using NUnit.Framework;
public class BombermanTests
{
    private GameObject game;
    private Player[] players;

    Player GetPlayer(int index)
    {
        foreach (var player in players)
        {
            if(player.playerNumber == index)
            {
                return player;
            }
        }
        return null;
    }

    [SetUp]
    public void SetUp()
    {
        GameObject gamePrefab = Resources.Load<GameObject>("Prefabs/Game");
        game = Object.Instantiate(gamePrefab);
        players = Object.FindObjectsOfType<Player>();
    }

    [UnityTest]
    public IEnumerator PlayerDropsBomb()
    {
        Player player1 = GetPlayer(1);

        player1.DropBomb();

        yield return new WaitForEndOfFrame();

        Bomb bomb = Object.FindObjectOfType<Bomb>();

        Assert.IsTrue(bomb != null, "The Bomb didn't spawn");

        Debug.Break();
    }

    [UnityTest]
    public IEnumerator PlayerMovement()
    {
        Player player1 = GetPlayer(1);
        player1.Up
    }

    [TearDown]
    void TearDown()
    {
        Object.Destroy(game);
    }
}
