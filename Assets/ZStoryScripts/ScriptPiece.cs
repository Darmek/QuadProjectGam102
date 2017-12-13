using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
[CreateAssetMenu(fileName = "Script Piece", menuName = "scriptPiece")]
public class ScriptPiece : ScriptableObject {
    public List<string> script;
}
