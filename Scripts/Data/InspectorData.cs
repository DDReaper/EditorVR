﻿using ListView;
using System.Collections.Generic;
using UnityEditor;

namespace UnityEngine.Experimental.EditorVR.Data
{
	class InspectorData : ListViewItemNestedData<InspectorData, int>
	{
#if UNITY_EDITOR
		public SerializedObject serializedObject { get { return m_SerializedObject; } }
		readonly SerializedObject m_SerializedObject;

		public override int index
		{
			get { return serializedObject.targetObject.GetInstanceID(); }
		}

		public InspectorData(string template, SerializedObject serializedObject, List<InspectorData> children)
		{
			this.template = template;
			m_SerializedObject = serializedObject;
			m_Children = children;
		}
#endif
	}
}