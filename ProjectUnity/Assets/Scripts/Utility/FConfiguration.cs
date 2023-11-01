using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;


public class FConfiguration : MonoBehaviour
{
    public UnityEngine.Object obj;
    [SerializeField]
    public Dictionary<string, string> strConfig = new Dictionary<string, string>();
    [SerializeField]
    public Dictionary<string, UnityEngine.Object> objConfig;
#if UNITY_EDITOR

    [CustomEditor(typeof(FConfiguration))]
    public class MyComponentEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            FConfiguration myComponent = (FConfiguration)target;

            // 显示和编辑 Dictionary 字段
            SerializedObject serializedObject = new SerializedObject(myComponent);
            SerializedProperty dictionaryProperty = serializedObject.FindProperty("strConfig");
            EditorGUILayout.PropertyField(dictionaryProperty, true);

            // 应用修改
            serializedObject.ApplyModifiedProperties();

            // 显示默认 Inspector
            DrawDefaultInspector();
        }
    }

    [CustomPropertyDrawer(typeof(Dictionary<string, string>))]
    public class DictionaryStringStringDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            EditorGUI.LabelField(position, label);

            EditorGUI.indentLevel++;

            SerializedProperty keysProperty = property.FindPropertyRelative("keys");
            SerializedProperty valuesProperty = property.FindPropertyRelative("values");

            for (int i = 0; i < keysProperty.arraySize; i++)
            {
                Rect keyRect = new Rect(position.x, position.y + EditorGUIUtility.singleLineHeight * (i + 1), position.width * 0.4f, EditorGUIUtility.singleLineHeight);
                EditorGUI.PropertyField(keyRect, keysProperty.GetArrayElementAtIndex(i), GUIContent.none);

                Rect valueRect = new Rect(position.x + position.width * 0.4f, position.y + EditorGUIUtility.singleLineHeight * (i + 1), position.width * 0.6f, EditorGUIUtility.singleLineHeight);
                EditorGUI.PropertyField(valueRect, valuesProperty.GetArrayElementAtIndex(i), GUIContent.none);
            }

            EditorGUI.indentLevel--;

            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            SerializedProperty keysProperty = property.FindPropertyRelative("keys");
            float lineHeight = EditorGUIUtility.singleLineHeight;
            return (keysProperty.arraySize + 1) * lineHeight;
        }
    }

#endif

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
