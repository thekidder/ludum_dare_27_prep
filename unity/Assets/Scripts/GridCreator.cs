using UnityEngine;
using System.Collections;

public class GridCreator : MonoBehaviour {

	// Use this for initialization
	void Start () {
        for(int i = -8; i < 8; ++i)
        {
            for(int j = -8; j < 8; ++j)
            {
                OTSprite sprite = OT.CreateObject(OTObjectType.Sprite).GetComponent<OTSprite>();
                sprite.size = new Vector2(32,32);
                sprite.position = new Vector2(i * 32, j * 32);
                sprite.depth = 10;
                sprite.transparent = true;
                sprite.physics = OTObject.Physics.Trigger;
                float color = Random.Range(0.4f, 0.7f);
                sprite.tintColor = new Color(color, color, color);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
