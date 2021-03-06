﻿using System.Diagnostics;
using System.Xml.Linq;
using DNNSelenium.Common.BaseClasses;
using DNNSelenium.Common.CorePages;
using DNNSelenium.Platform.Properties;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DNNSelenium.Platform.BVT
{
	[TestFixture]
	[Category("BVT")]
	public class BVTZLogs : Common.Tests.BVT.BVTZLogs
	{
		protected override string DataFileLocation
		{
			get { return @"BVT\" + Settings.Default.BVTDataFile; }
		}
	}
}