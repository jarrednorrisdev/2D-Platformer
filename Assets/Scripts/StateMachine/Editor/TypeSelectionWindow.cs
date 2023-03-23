using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using Sirenix.Serialization;
using UnityEditor;
using UnityEngine;

namespace StateMachine.Editor
{
    public class TypeSelectionWindow : OdinEditorWindow
    {
        [OdinSerialize, HideLabel, ValueDropdown(nameof(GetAllTypes))]
        Type _selectedType;

        [
            OdinSerialize,
            HideLabel,
            FolderPath(AbsolutePath = false, RequireExistingPath = true)
        ]
        string outputFolderPath;

        List<Type> GetAllTypes()
        {
            // Get all types that can be used for T
            return (
                from assembly in AppDomain.CurrentDomain.GetAssemblies()
                from type in assembly.GetTypes()
                where IsValidTypeForT(type)
                select type
            ).ToList();
        }

        static bool IsValidTypeForT(Type type)
        {
            // Add conditions to exclude unwanted types from the dropdown list
            return type.Namespace != null
                && !type.IsAbstract
                && !type.IsGenericType
                && type.Namespace.StartsWith("Pawn")
                && type.Name.Contains("Context");
        }

        [Button("Populate Lists and Create Scriptable Objects"), HorizontalGroup("Lists")]
        void PopulateLists()
        {
            if (_selectedType == null)
            {
                Debug.LogError("No type selected");
                return;
            }

            if (string.IsNullOrEmpty(outputFolderPath))
            {
                Debug.LogError("Output folder path is not set");
                return;
            }

            IEnumerable<Type> stateTransitions = FindScriptsOfType(
                typeof(StateTransition<>).MakeGenericType(_selectedType)
            );
            IEnumerable<Type> transitionConditions = FindScriptsOfType(
                typeof(TransitionCondition<>).MakeGenericType(_selectedType)
            );
            IEnumerable<Type> states = FindScriptsOfType(
                typeof(State<>).MakeGenericType(_selectedType)
            );

            string contextName = _selectedType.Name.Replace("Context", "");
            CreateScriptableObjects(stateTransitions, "Transitions", contextName);
            CreateScriptableObjects(transitionConditions, "Conditions", contextName);
            CreateScriptableObjects(states, "States", contextName);
        }

        void CreateScriptableObjects(
            IEnumerable<Type> types,
            string subfolderName,
            string contextName
        )
        {
            string folderPath = $"{outputFolderPath}/{contextName}/FSM/{subfolderName}";
            if (!AssetDatabase.IsValidFolder(folderPath))
            {
                string guid = AssetDatabase.CreateFolder(
                    $"{outputFolderPath}/{contextName}",
                    subfolderName
                );
                folderPath = AssetDatabase.GUIDToAssetPath(guid);
            }

            foreach (Type type in types)
            {
                ScriptableObject obj = ScriptableObject.CreateInstance(type);
                AssetDatabase.CreateAsset(obj, $"{folderPath}/{type.Name}.asset");
            }

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        static IEnumerable<Type> FindScriptsOfType(Type targetType)
        {
            List<Type> types = new List<Type>();
            for (int i = 0; i < AppDomain.CurrentDomain.GetAssemblies().Length; i++)
            {
                Assembly assembly = AppDomain.CurrentDomain.GetAssemblies()[i];
                types.AddRange(
                    assembly
                        .GetTypes()
                        .Where(
                            type =>
                                targetType.IsAssignableFrom(type)
                                && !type.IsAbstract
                                && !type.IsGenericType
                        )
                );
            }

            return types;
        }

        [MenuItem("Tools/Type Selection Window")]
        static void OpenWindow()
        {
            GetWindow<TypeSelectionWindow>().Show();
        }
    }
}
