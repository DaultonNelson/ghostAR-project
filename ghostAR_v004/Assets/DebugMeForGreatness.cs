﻿using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class DebugMeForGreatness : MonoBehaviour {
    public Text theGreatDebugger;
    WorldSpaceButton ThisWorldButton() {
        return GetComponent<WorldSpaceButton>();
    }

    private void Update () {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Pos: " + transform.position.ToString());
        sb.AppendLine("Local Pos: " + transform.localPosition.ToString());

        theGreatDebugger.text = sb.ToString();
    }
}