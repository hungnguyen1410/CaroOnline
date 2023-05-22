using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isUsed;
    public int x;
    public int y;
    public ChessPieceType type = new ChessPieceType();
    [SerializeField] private SpriteRenderer sprite;
    void Start()
    {
        Vector2 pos = transform.position;
        x = int.Parse(pos.x.ToString());
        y = int.Parse(pos.y.ToString());
    }

    private void OnMouseUp()
    { 
        if(ManagerPlayer.instance.isMyTurn && ManagerPlayer.instance.isStartGame)
        {
            if (!isUsed)
            {
                if (BoardManager.instance.preBoxChoose == null || BoardManager.instance.preBoxChoose != gameObject)
                {
                    if(BoardManager.instance.preBoxChoose != null)
                    {
                        BoardManager.instance.preBoxChoose.GetComponent<SpriteRenderer>().color = Color.white;
                    }    
                    BoardManager.instance.preBoxChoose = gameObject;
                    sprite.color = BoardManager.instance.colorSelect;
                }
                else if (BoardManager.instance.preBoxChoose == gameObject)
                {
                    sprite.color = Color.white;
                    ManagerPlayer.instance.isMyTurn = false;
                    isUsed = true;
                    BoardManager.instance.PlaceChessPiece(BoardManager.instance.turnCurrent, x, y);
                    DataSend data = new DataSend();
                    data.x = x;
                    data.y = y;
                    ManagerPlayer.instance.SendData(x, y);

                    ManagerPlayer.instance.timeP1.SetActive(false);
                    ManagerPlayer.instance.timeP2.SetActive(true);
                    ManagerPlayer.instance.TimeDefauld();
                }
            }
        }    
        
    }
}
