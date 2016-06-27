﻿/* The contents of this file are subject to the Mozilla Public License
 * Version 1.1 (the "License"); you may not use this file except in
 * compliance with the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 * 
 * Software distributed under the License is distributed on an "AS IS"
 * basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See the
 * License for the specific language governing rights and limitations
 * under the License.
 * 
 * 
 * The Initial Developer of the Original Code is Callum McGing (mailto:callum.mcging@gmail.com).
 * Portions created by the Initial Developer are Copyright (C) 2013-2016
 * the Initial Developer. All Rights Reserved.
 */
using System;
using LibreLancer.Ini;
namespace LibreLancer.Compatibility.GameData.Solar
{
	public class Spines
	{
		public string Nickname;
		public int RadiusScale;
		public string Shape;
		public int MinRadius;
		public int MaxRadius;
		public Spines(Section s)
		{
			foreach (var e in s)
			{
				switch (e.Name.ToLowerInvariant())
				{
					case "nickname":
						Nickname = e[0].ToString();
						break;
					case "radius_scale":
						RadiusScale = e[0].ToInt32();
						break;
					case "shape":
						Shape = e[0].ToString();
						break;
					case "min_radius":
						MinRadius = e[0].ToInt32();
						break;
					case "max_radius":
						MaxRadius = e[0].ToInt32();
						break;
					case "spine":
						//TODO: wtf is this
						break;
				}
			}
		}
	}
}

