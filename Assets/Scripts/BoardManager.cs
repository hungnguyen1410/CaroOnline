using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public enum ChessPieceType
{
    X,
    O
}

public class BoardManager : MonoBehaviourPun
{
    public static BoardManager instance;
    public int boardSize = 15; // kích thước của bàn cờ
    public GameObject boardTilePrefab; // prefab để tạo ô vuông

    private Box[,] boardTiles; // mảng lưu trữ các ô vuông

    public GameObject XPrefab; // prefab để tạo quân cờ X
    public GameObject OPrefab; // prefab để tạo quân cờ O
    public ChessPieceType turnCurrent;
    public GameObject preBoxChoose;
    public Color colorSelect;
    [SerializeField] private GameObject popup_Win;
    [SerializeField] private GameObject popup_Lose;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }    
    }
    void Start()
    {
        //mặc định là x đi trước
        turnCurrent = ChessPieceType.X;
        CreateBoard();
        Vector3 posCenter = boardTiles[boardSize / 2, boardSize / 2].transform.position;
        Camera.main.transform.position = new Vector3(posCenter.x, posCenter.y, -10);
    }

    public void TurnNext()
    {
        if(turnCurrent == ChessPieceType.X)
        {
            turnCurrent = ChessPieceType.O;
        }    
        else
        {
            turnCurrent = ChessPieceType.X;
        }    
    }    

    public bool CheckWin(ChessPieceType type, int x, int y)
    {
        // kiểm tra hàng ngang
        int count = 0;
        for (int i = x - 4; i <= x + 4; i++)
        {
            if (i >= 0 && i < boardSize && boardTiles[i, y].type == type && boardTiles[i, y].isUsed)
            {
                count++;
                if (count >= 5) return true;
            }
            else
            {
                count = 0;
            }
        }

        // kiểm tra hàng dọc
        count = 0;
        for (int j = y - 4; j <= y + 4; j++)
        {
            if (j >= 0 && j < boardSize && boardTiles[x, j].type == type && boardTiles[x, j].isUsed)
            {
                count++;
                if (count >= 5) return true;
            }
            else
            {
                count = 0;
            }
        }

        // kiểm tra đường chéo chính
        count = 0;
        for (int i = -4; i <= 4; i++)
        {
            int tx = x + i;
            int ty = y + i;
            if (tx >= 0 && tx < boardSize && ty >= 0 && ty < boardSize && boardTiles[tx, ty].type == type && boardTiles[tx, ty].isUsed)
            {
                count++;
                if (count >= 5) return true;
            }
            else
            {
                count = 0;
            }
        }

        // kiểm tra đường chéo phụ
        count = 0;
        for (int i = -4; i <= 4; i++)
        {
            int tx = x + i;
            int ty = y - i;
            if (tx >= 0 && tx < boardSize && ty >= 0 && ty < boardSize && boardTiles[tx, ty].type == type && boardTiles[tx, ty].isUsed)
            {
                count++;
                if (count >= 5) return true;
            }
            else
            {
                count = 0;
            }
        }

        return false;
    }

// Hàm tạo bàn cờ với kích thước boardSize
void CreateBoard()
    {
        boardTiles = new Box[boardSize, boardSize];

        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                // tạo ô vuông mới
                Box newTile = Instantiate(boardTilePrefab, new Vector3(i, j), Quaternion.identity).GetComponent<Box>();
                newTile.name = "Tile_" + i + "_" + j;

                // lưu trữ ô vuông vào mảng
                boardTiles[i, j] = newTile;
            }
        }
    }
    // Hàm đặt quân cờ tại vị trí (x, y) trên bàn cờ
    public void PlaceChessPiece(ChessPieceType type, int x, int y)
    {
        if(x == -1 && y == -1)
        {
            return;
        }    
        // kiểm tra vị trí hợp lệ
        boardTiles[x, y].isUsed = true;
        boardTiles[x, y].type = type;
        if (x >= 0 && x < boardSize && y >= 0 && y < boardSize)
        {
            // lấy prefab tương ứng với loại quân cờ
            GameObject prefab = (type == ChessPieceType.X) ? XPrefab : OPrefab;

            // tạo quân cờ mới
            GameObject newChessPiece = Instantiate(prefab, new Vector3(x, 1, y), Quaternion.identity);
            newChessPiece.name = type.ToString() + "_" + x + "_" + y;

            // đặt quân cờ lên ô vuông tương ứng
            newChessPiece.transform.parent = boardTiles[x, y].transform;
            newChessPiece.transform.localPosition = Vector3.zero;
            newChessPiece.transform.localScale = Vector3.one * 0.8f;
            if(CheckWin(ChessPieceType.O, x, y))
            {
                Debug.Log("O - Win . END GAME");
                if(ManagerPlayer.instance.thisPlayer == ChessPieceType.O)
                {
                    popup_Win.SetActive(true);
                }
                else
                {
                    popup_Lose.SetActive(true);
                }
                Invoke(nameof(BackToRoom), 1.5f);
            }
            if(CheckWin(ChessPieceType.X, x, y))
            {
                Debug.Log("X - Win . END GAME");
                if (ManagerPlayer.instance.thisPlayer == ChessPieceType.X)
                {
                    popup_Win.SetActive(true);
                }
                else
                {
                    popup_Lose.SetActive(true);
                }
                Invoke(nameof(BackToRoom), 1.5f);
            }
            TurnNext();
        }
        else
        {
            Debug.LogWarning("Invalid position for chess piece: (" + x + ", " + y + ")");
        }
    }

    void BackToRoom()
    {
        UI_Loading.instance.LoadScene("InRoom");
    }
}
