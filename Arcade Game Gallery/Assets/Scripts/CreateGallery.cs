using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGallery : MonoBehaviour
{
    // Start is called before the first frame update
    List<GallerySceneThumb> galleryItems;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class GallerySceneThumb
{
    public Sprite thumbnailSprite;
    public string Description;
    public string Title;
    public string SceneName;

}