using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableBlocks", menuName = "ScriptableObjects/ScriptableBlocks")]
public class ScriptableBlocks : ScriptableObject
{
    public PhysicsMaterial2D Material;
    public int Score;
    public int DoubleScore;
    public Sprite NormalSprite;
    public Sprite HitSprite;
    public Sprite DoubleSprite;
}
