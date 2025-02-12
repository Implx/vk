﻿using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using VkNet.Enums.SafetyEnums;
using VkNet.Tests.Infrastructure;

namespace VkNet.Tests.Categories.AppWidgets
{
	[TestFixture]

	public class GetGroupImagesTest : CategoryBaseTest
	{
		protected override string Folder => "AppWidgets";

		[Test]
		public void GetGroupImages()
		{
			Url = "https://api.vk.com/method/appWidgets.getGroupImages";

			ReadCategoryJsonPath(nameof(GetGroupImages));

			var result = Api.AppWidgets.GetGroupImages(0, 10, AppWidgetImageType.FiftyOnFifty);

			result.Items.First().Images.First().Url.Should().NotBeNull();
		}
	}
}