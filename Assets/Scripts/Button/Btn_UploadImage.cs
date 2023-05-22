using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Btn_UploadImage : MonoBehaviour
{
    public Texture2D displayTexture;
    private Button btn;
    [SerializeField] private Image avatar;

    private void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);
    }

    public void OnButtonClick()
    {

        // Open the gallery to select an image
        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
        {
            if (path != null)
            {
                // Load the selected image and display it on the screen
                displayTexture = NativeGallery.LoadImageAtPath(path);
                Sprite sprite = Sprite.Create(displayTexture, new Rect(0, 0, displayTexture.width, displayTexture.height), Vector2.one * 0.5f);
                avatar.sprite = sprite;
            }
        }, "Select a PNG image", "image/png");

        Debug.Log("Permission result: " + permission);
    }
}
