#define USE
#if USE
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

namespace EM.SnapPlugin.Editor
{
	[CanEditMultipleObjects, CustomEditor(typeof(Transform), true)]
    public partial class SnapButtonsForInspectorGUI : UnityEditor.Editor
    {
    }
}
#endif