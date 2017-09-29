using System;
using DemoApp.Common.Interfaces;
using System.Diagnostics;

namespace DemoApp.Forms.iOS.Utils
{
	public class StackFrameHelper : IStackFrameHelper
	{
		public string GetCallerFullTypeName(int? skipFrames = null)
		{
			var type = GetCallerFullType(skipFrames);
			return type?.FullName;
		}

		public Type GetCallerFullType(int? skipFrames = null)
		{
			if (skipFrames == null)
			{
				skipFrames = 3;
			}

			var type = new StackFrame(skipFrames.Value).GetMethod()?.DeclaringType;

			return type;
		}
	}
}
