using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunkSystem : MonoBehaviour {

    private Dictionary<Vector2Int, Node> nodes;
    private Vector2Int playerPosOnGrid;
    public float nodeSize;
    private Node curNode;
    public GameObject Player;
    public int mapSize;
    public Node testNode;
    public GameObject nodePrefab;

    private void generateNodesGrid() { 
    

        int numberOfNodes = GameObject.FindGameObjectsWithTag("Node").Length;

        int sideSize = (int) Mathf.Sqrt(numberOfNodes);

        nodes = new Dictionary<Vector2Int, Node>(numberOfNodes);


        foreach (GameObject node in GameObject.FindGameObjectsWithTag("Node"))
        {

            Vector2Int nodePos = new Vector2Int((int)(node.transform.position.x / nodeSize), (int)(node.transform.position.z / nodeSize));
            print("x " + nodePos.x.ToString() + " y " + nodePos.y);
            
            nodes[new Vector2Int (nodePos.x, nodePos.y)] = node.GetComponent<Node> ();

        }
    }
    private void Start()
    {
        generateNodesGrid();
    }
    private void Update()
    {

        playerPosOnGrid = new Vector2Int((int)(Player.transform.position.x / (nodeSize / 1.75f)), (int)(Player.transform.position.z / (nodeSize / 1.75f)));
        print("player on grid x " + playerPosOnGrid.x + " y  " + playerPosOnGrid.y);
    
        foreach (Node _node in nodes.Values)
        {

            try
            {
                if (nodes[new Vector2Int(playerPosOnGrid.x, playerPosOnGrid.y)] != _node)
                {
                    _node.gameObject.SetActive(false);
                }
                if (nodes[new Vector2Int(playerPosOnGrid.x, playerPosOnGrid.y)] == _node)
                {
                    _node.gameObject.SetActive(true);

                }
            }catch {
                
            }
            try
            {
                nodes[new Vector2Int (playerPosOnGrid.x - 1, playerPosOnGrid.y - 1)].gameObject.SetActive(true);

            }
            catch { }
            try
            {
                nodes[new Vector2Int (playerPosOnGrid.x - 1, playerPosOnGrid.y)].gameObject.SetActive(true);

            }
            catch { }
            try
            {
                nodes[new Vector2Int (playerPosOnGrid.x - 1, playerPosOnGrid.y + 1)].gameObject.SetActive(true);

            }
            catch { }
            try
            {
                nodes[new Vector2Int (playerPosOnGrid.x, playerPosOnGrid.y - 1)].gameObject.SetActive(true);

            }
            catch { }

            try
            {
                nodes[new Vector2Int (playerPosOnGrid.x, playerPosOnGrid.y + 1)].gameObject.SetActive(true);

            }
            catch { }

            try
            {
                nodes[new Vector2Int (playerPosOnGrid.x + 1, playerPosOnGrid.y - 1)].gameObject.SetActive(true);
            }
            catch { }

            try
            {
                nodes[new Vector2Int (playerPosOnGrid.x + 1, playerPosOnGrid.y)].gameObject.SetActive(true);

            } catch { }

            try
            {
                nodes[new Vector2Int (playerPosOnGrid.x + 1, playerPosOnGrid.y + 1)].gameObject.SetActive(true);

            } catch { }
        }
    }
}
