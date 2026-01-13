using UnityEditor;
using UnityEngine;

namespace Editor.Scripts
{
    public static class CreateAtCenter
    {
        [MenuItem("GameObject/Create Empty at Local Center", false, 0)]
        static void CreateEmptyAtCenter()
        {
            if (Selection.activeGameObject == null)
                return;

            var go = Selection.activeGameObject;
            var renderer = go.GetComponent<Renderer>();

            if (renderer == null)
                return;

            GameObject empty = new GameObject(go.name + "_Center");
            Undo.RegisterCreatedObjectUndo(empty, "Create Empty at Local Center");

            empty.transform.position = renderer.bounds.center;
            empty.transform.rotation = go.transform.rotation;
        }
    }
}