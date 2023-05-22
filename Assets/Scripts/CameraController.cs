using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public RawImage image;

    private WebCamTexture webCamTexture;
    [SerializeField] private Image Avatar;

    void Start()
    {
        webCamTexture = new WebCamTexture();
        image.texture = webCamTexture;
        webCamTexture.Play();
    }

    public void TakePhoto()
    {
        StartCoroutine(TakePhotoCoroutine());
    }

    IEnumerator TakePhotoCoroutine()
    {
        yield return new WaitForEndOfFrame();

        Texture2D texture = new Texture2D(webCamTexture.width, webCamTexture.height);
        texture.SetPixels(webCamTexture.GetPixels());
        texture.Apply();

        // Do something with the texture, e.g. save it to disk or display it on a UI Image
        // For example:
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        Avatar.sprite = sprite;
        image.gameObject.SetActive(false);
    }
}