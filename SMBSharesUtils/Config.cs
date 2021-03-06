﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SMBSharesUtils
{
	public static class Config
	{
		public static bool Debug = false;
		
		public static uint MaxThreads = 1;

		public static bool PrintACL = false;

		public static bool TryResolveSID = true;
		public static bool TryResolveHostName = false;
		public static int RecursiveLevel = 0;

		public static bool ScanForNewShares = true;
		public static int ScanForNewSharesRecusiveLevel = -1;
		public static bool ScanForNewSharesTryResolveHostName = true;

		public static uint ThreadJoinMaxAttempts = 20;
		public static int ThreadJoinTimeout = 100;

		// List of shares names to not scan recursively 
		public static List<string> SharesRecursiveScanBlackList = new List<string> { "ADMIN$" };

		public static void ShowConfig()
		{

			Console.WriteLine(String.Format("{0,-40}  {1,-10}", "Field", "Value"));
			Console.WriteLine(new String('-', 50));
			foreach (FieldInfo fieldInfo in typeof(Config).GetFields(BindingFlags.Static | BindingFlags.Public))
			{
				Console.WriteLine(String.Format("{0,-40}  {1,-10}", fieldInfo.Name,fieldInfo.GetValue(null).ToString()));
			}
			
		}
	}
}
