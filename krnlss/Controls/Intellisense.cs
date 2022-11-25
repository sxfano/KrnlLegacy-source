using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CefSharp;
using CefSharp.WinForms;

namespace Controls
{
	// Token: 0x0200000D RID: 13
	internal class Intellisense
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00004458 File Offset: 0x00002658
		public static void addIntellisense(ChromiumWebBrowser chrome)
		{
			Intellisense intellisense = new Intellisense();
			FieldInfo[] fields = intellisense.GetType().GetFields();
			for (int i = 0; i < fields.Length; i++)
			{
				Dictionary<string, string[]> dictionary = fields[i].GetValue(intellisense) as Dictionary<string, string[]>;
				for (int j = 0; j < dictionary.Keys.Count; j++)
				{
					string[] array;
					dictionary.TryGetValue(dictionary.Keys.ToList<string>()[j], out array);
					if (array != null)
					{
						try
						{
							WebBrowserExtensions.ExecuteScriptAsyncWhenPageLoaded(chrome, string.Concat(new string[]
							{
								"AddIntellisense('",
								dictionary.Keys.ToList<string>()[j],
								"', '",
								array[0],
								"', '",
								array[1],
								"', '",
								array[2],
								"')"
							}), true);
						}
						catch
						{
						}
					}
				}
			}
		}

		// Token: 0x04000028 RID: 40
		public static Dictionary<string, string[]> DOCKWIDGETPLUGINGUIINFO = new Dictionary<string, string[]>
		{
			{
				"DockWidgetPluginGuiInfo",
				new string[]
				{
					"Class",
					"",
					"DockWidgetPluginGuiInfo"
				}
			},
			{
				"DockWidgetPluginGuiInfo.new",
				new string[]
				{
					"Method",
					"",
					"DockWidgetPluginGuiInfo.new"
				}
			}
		};

		// Token: 0x04000029 RID: 41
		public static Dictionary<string, string[]> OS = new Dictionary<string, string[]>
		{
			{
				"os",
				new string[]
				{
					"Class",
					"",
					"os"
				}
			},
			{
				"os.clock",
				new string[]
				{
					"Method",
					"",
					"os.clock"
				}
			},
			{
				"os.difftime",
				new string[]
				{
					"Method",
					"",
					"os.difftime"
				}
			},
			{
				"os.time",
				new string[]
				{
					"Method",
					"",
					"os.time"
				}
			},
			{
				"os.date",
				new string[]
				{
					"Method",
					"",
					"os.date"
				}
			}
		};

		// Token: 0x0400002A RID: 42
		public static Dictionary<string, string[]> UDIM = new Dictionary<string, string[]>
		{
			{
				"UDim",
				new string[]
				{
					"Class",
					"",
					"UDim"
				}
			},
			{
				"UDim.new",
				new string[]
				{
					"Method",
					"",
					"UDim.new"
				}
			}
		};

		// Token: 0x0400002B RID: 43
		public static Dictionary<string, string[]> DEBUG = new Dictionary<string, string[]>
		{
			{
				"debug",
				new string[]
				{
					"Class",
					"",
					"debug"
				}
			},
			{
				"debug.getupvalue",
				new string[]
				{
					"Method",
					"",
					"debug.getupvalue"
				}
			},
			{
				"debug.getconstant",
				new string[]
				{
					"Method",
					"",
					"debug.getconstant"
				}
			},
			{
				"debug.getproto",
				new string[]
				{
					"Method",
					"",
					"debug.getproto"
				}
			},
			{
				"debug.profileend",
				new string[]
				{
					"Method",
					"",
					"debug.profileend"
				}
			},
			{
				"debug.profilebegin",
				new string[]
				{
					"Method",
					"",
					"debug.profilebegin"
				}
			},
			{
				"debug.getprotos",
				new string[]
				{
					"Method",
					"",
					"debug.getprotos"
				}
			},
			{
				"debug.traceback",
				new string[]
				{
					"Method",
					"",
					"debug.traceback"
				}
			},
			{
				"debug.getconstants",
				new string[]
				{
					"Method",
					"",
					"debug.getconstants"
				}
			},
			{
				"debug.getinfo",
				new string[]
				{
					"Method",
					"",
					"debug.getinfo"
				}
			},
			{
				"debug.setupvalue",
				new string[]
				{
					"Method",
					"",
					"debug.setupvalue"
				}
			},
			{
				"debug.setconstant",
				new string[]
				{
					"Method",
					"",
					"debug.setconstant"
				}
			},
			{
				"debug.getregistry",
				new string[]
				{
					"Method",
					"",
					"debug.getregistry"
				}
			},
			{
				"debug.getupvalues",
				new string[]
				{
					"Method",
					"",
					"debug.getupvalues"
				}
			}
		};

		// Token: 0x0400002C RID: 44
		public static Dictionary<string, string[]> COROUTINE = new Dictionary<string, string[]>
		{
			{
				"coroutine",
				new string[]
				{
					"Class",
					"",
					"coroutine"
				}
			},
			{
				"coroutine.resume",
				new string[]
				{
					"Method",
					"",
					"coroutine.resume"
				}
			},
			{
				"coroutine.yield",
				new string[]
				{
					"Method",
					"",
					"coroutine.yield"
				}
			},
			{
				"coroutine.running",
				new string[]
				{
					"Method",
					"",
					"coroutine.running"
				}
			},
			{
				"coroutine.status",
				new string[]
				{
					"Method",
					"",
					"coroutine.status"
				}
			},
			{
				"coroutine.wrap",
				new string[]
				{
					"Method",
					"",
					"coroutine.wrap"
				}
			},
			{
				"coroutine.create",
				new string[]
				{
					"Method",
					"",
					"coroutine.create"
				}
			},
			{
				"coroutine.isyieldable",
				new string[]
				{
					"Method",
					"",
					"coroutine.isyieldable"
				}
			}
		};

		// Token: 0x0400002D RID: 45
		public static Dictionary<string, string[]> SHARED = new Dictionary<string, string[]>
		{
			{
				"shared",
				new string[]
				{
					"Class",
					"",
					"shared"
				}
			}
		};

		// Token: 0x0400002E RID: 46
		public static Dictionary<string, string[]> PLUGINDRAG = new Dictionary<string, string[]>
		{
			{
				"PluginDrag",
				new string[]
				{
					"Class",
					"",
					"PluginDrag"
				}
			},
			{
				"PluginDrag.new",
				new string[]
				{
					"Method",
					"",
					"PluginDrag.new"
				}
			}
		};

		// Token: 0x0400002F RID: 47
		public static Dictionary<string, string[]> RAYCASTPARAMS = new Dictionary<string, string[]>
		{
			{
				"RaycastParams",
				new string[]
				{
					"Class",
					"",
					"RaycastParams"
				}
			},
			{
				"RaycastParams.new",
				new string[]
				{
					"Method",
					"",
					"RaycastParams.new"
				}
			}
		};

		// Token: 0x04000030 RID: 48
		public static Dictionary<string, string[]> TABLE = new Dictionary<string, string[]>
		{
			{
				"table",
				new string[]
				{
					"Class",
					"",
					"table"
				}
			},
			{
				"table.pack",
				new string[]
				{
					"Method",
					"",
					"table.pack"
				}
			},
			{
				"table.move",
				new string[]
				{
					"Method",
					"",
					"table.move"
				}
			},
			{
				"table.insert",
				new string[]
				{
					"Method",
					"",
					"table.insert"
				}
			},
			{
				"table.getn",
				new string[]
				{
					"Method",
					"",
					"table.getn"
				}
			},
			{
				"table.foreachi",
				new string[]
				{
					"Method",
					"",
					"table.foreachi"
				}
			},
			{
				"table.maxn",
				new string[]
				{
					"Method",
					"",
					"table.maxn"
				}
			},
			{
				"table.foreach",
				new string[]
				{
					"Method",
					"",
					"table.foreach"
				}
			},
			{
				"table.concat",
				new string[]
				{
					"Method",
					"",
					"table.concat"
				}
			},
			{
				"table.unpack",
				new string[]
				{
					"Method",
					"",
					"table.unpack"
				}
			},
			{
				"table.find",
				new string[]
				{
					"Method",
					"",
					"table.find"
				}
			},
			{
				"table.create",
				new string[]
				{
					"Method",
					"",
					"table.create"
				}
			},
			{
				"table.sort",
				new string[]
				{
					"Method",
					"",
					"table.sort"
				}
			},
			{
				"table.remove",
				new string[]
				{
					"Method",
					"",
					"table.remove"
				}
			}
		};

		// Token: 0x04000031 RID: 49
		public static Dictionary<string, string[]> TWEENINFO = new Dictionary<string, string[]>
		{
			{
				"TweenInfo",
				new string[]
				{
					"Class",
					"",
					"TweenInfo"
				}
			},
			{
				"TweenInfo.new",
				new string[]
				{
					"Method",
					"",
					"TweenInfo.new"
				}
			}
		};

		// Token: 0x04000032 RID: 50
		public static Dictionary<string, string[]> VECTOR3 = new Dictionary<string, string[]>
		{
			{
				"Vector3",
				new string[]
				{
					"Class",
					"",
					"Vector3"
				}
			},
			{
				"Vector3.FromNormalId",
				new string[]
				{
					"Method",
					"",
					"Vector3.FromNormalId"
				}
			},
			{
				"Vector3.FromAxis",
				new string[]
				{
					"Method",
					"",
					"Vector3.FromAxis"
				}
			},
			{
				"Vector3.fromAxis",
				new string[]
				{
					"Method",
					"",
					"Vector3.fromAxis"
				}
			},
			{
				"Vector3.fromNormalId",
				new string[]
				{
					"Method",
					"",
					"Vector3.fromNormalId"
				}
			},
			{
				"Vector3.new",
				new string[]
				{
					"Method",
					"",
					"Vector3.new"
				}
			}
		};

		// Token: 0x04000033 RID: 51
		public static Dictionary<string, string[]> VECTOR2INT16 = new Dictionary<string, string[]>
		{
			{
				"Vector2int16",
				new string[]
				{
					"Class",
					"",
					"Vector2int16"
				}
			},
			{
				"Vector2int16.new",
				new string[]
				{
					"Method",
					"",
					"Vector2int16.new"
				}
			}
		};

		// Token: 0x04000034 RID: 52
		public static Dictionary<string, string[]> FACES = new Dictionary<string, string[]>
		{
			{
				"Faces",
				new string[]
				{
					"Class",
					"",
					"Faces"
				}
			},
			{
				"Faces.new",
				new string[]
				{
					"Method",
					"",
					"Faces.new"
				}
			}
		};

		// Token: 0x04000035 RID: 53
		public static Dictionary<string, string[]> REGION3 = new Dictionary<string, string[]>
		{
			{
				"Region3",
				new string[]
				{
					"Class",
					"",
					"Region3"
				}
			},
			{
				"Region3.new",
				new string[]
				{
					"Method",
					"",
					"Region3.new"
				}
			}
		};

		// Token: 0x04000036 RID: 54
		public static Dictionary<string, string[]> MATH = new Dictionary<string, string[]>
		{
			{
				"math",
				new string[]
				{
					"Class",
					"",
					"math"
				}
			},
			{
				"math.log",
				new string[]
				{
					"Method",
					"",
					"math.log"
				}
			},
			{
				"math.ldexp",
				new string[]
				{
					"Method",
					"",
					"math.ldexp"
				}
			},
			{
				"math.rad",
				new string[]
				{
					"Method",
					"",
					"math.rad"
				}
			},
			{
				"math.cosh",
				new string[]
				{
					"Method",
					"",
					"math.cosh"
				}
			},
			{
				"math.random",
				new string[]
				{
					"Method",
					"",
					"math.random"
				}
			},
			{
				"math.frexp",
				new string[]
				{
					"Method",
					"",
					"math.frexp"
				}
			},
			{
				"math.tanh",
				new string[]
				{
					"Method",
					"",
					"math.tanh"
				}
			},
			{
				"math.floor",
				new string[]
				{
					"Method",
					"",
					"math.floor"
				}
			},
			{
				"math.max",
				new string[]
				{
					"Method",
					"",
					"math.max"
				}
			},
			{
				"math.sqrt",
				new string[]
				{
					"Method",
					"",
					"math.sqrt"
				}
			},
			{
				"math.modf",
				new string[]
				{
					"Method",
					"",
					"math.modf"
				}
			},
			{
				"math.pow",
				new string[]
				{
					"Method",
					"",
					"math.pow"
				}
			},
			{
				"math.atan",
				new string[]
				{
					"Method",
					"",
					"math.atan"
				}
			},
			{
				"math.tan",
				new string[]
				{
					"Method",
					"",
					"math.tan"
				}
			},
			{
				"math.cos",
				new string[]
				{
					"Method",
					"",
					"math.cos"
				}
			},
			{
				"math.sign",
				new string[]
				{
					"Method",
					"",
					"math.sign"
				}
			},
			{
				"math.clamp",
				new string[]
				{
					"Method",
					"",
					"math.clamp"
				}
			},
			{
				"math.log10",
				new string[]
				{
					"Method",
					"",
					"math.log10"
				}
			},
			{
				"math.noise",
				new string[]
				{
					"Method",
					"",
					"math.noise"
				}
			},
			{
				"math.acos",
				new string[]
				{
					"Method",
					"",
					"math.acos"
				}
			},
			{
				"math.abs",
				new string[]
				{
					"Method",
					"",
					"math.abs"
				}
			},
			{
				"math.sinh",
				new string[]
				{
					"Method",
					"",
					"math.sinh"
				}
			},
			{
				"math.asin",
				new string[]
				{
					"Method",
					"",
					"math.asin"
				}
			},
			{
				"math.min",
				new string[]
				{
					"Method",
					"",
					"math.min"
				}
			},
			{
				"math.deg",
				new string[]
				{
					"Method",
					"",
					"math.deg"
				}
			},
			{
				"math.fmod",
				new string[]
				{
					"Method",
					"",
					"math.fmod"
				}
			},
			{
				"math.randomseed",
				new string[]
				{
					"Method",
					"",
					"math.randomseed"
				}
			},
			{
				"math.atan2",
				new string[]
				{
					"Method",
					"",
					"math.atan2"
				}
			},
			{
				"math.ceil",
				new string[]
				{
					"Method",
					"",
					"math.ceil"
				}
			},
			{
				"math.sin",
				new string[]
				{
					"Method",
					"",
					"math.sin"
				}
			},
			{
				"math.exp",
				new string[]
				{
					"Method",
					"",
					"math.exp"
				}
			}
		};

		// Token: 0x04000037 RID: 55
		public static Dictionary<string, string[]> RANDOM = new Dictionary<string, string[]>
		{
			{
				"Random",
				new string[]
				{
					"Class",
					"",
					"Random"
				}
			},
			{
				"Random.new",
				new string[]
				{
					"Method",
					"",
					"Random.new"
				}
			}
		};

		// Token: 0x04000038 RID: 56
		public static Dictionary<string, string[]> AXES = new Dictionary<string, string[]>
		{
			{
				"Axes",
				new string[]
				{
					"Class",
					"",
					"Axes"
				}
			},
			{
				"Axes.new",
				new string[]
				{
					"Method",
					"",
					"Axes.new"
				}
			}
		};

		// Token: 0x04000039 RID: 57
		public static Dictionary<string, string[]> COLORSEQUENCEKEYPOINT = new Dictionary<string, string[]>
		{
			{
				"ColorSequenceKeypoint",
				new string[]
				{
					"Class",
					"",
					"ColorSequenceKeypoint"
				}
			},
			{
				"ColorSequenceKeypoint.new",
				new string[]
				{
					"Method",
					"",
					"ColorSequenceKeypoint.new"
				}
			}
		};

		// Token: 0x0400003A RID: 58
		public static Dictionary<string, string[]> CFRAME = new Dictionary<string, string[]>
		{
			{
				"CFrame",
				new string[]
				{
					"Class",
					"",
					"CFrame"
				}
			},
			{
				"CFrame.fromMatrix",
				new string[]
				{
					"Method",
					"",
					"CFrame.fromMatrix"
				}
			},
			{
				"CFrame.fromAxisAngle",
				new string[]
				{
					"Method",
					"",
					"CFrame.fromAxisAngle"
				}
			},
			{
				"CFrame.fromOrientation",
				new string[]
				{
					"Method",
					"",
					"CFrame.fromOrientation"
				}
			},
			{
				"CFrame.fromEulerAnglesXYZ",
				new string[]
				{
					"Method",
					"",
					"CFrame.fromEulerAnglesXYZ"
				}
			},
			{
				"CFrame.Angles",
				new string[]
				{
					"Method",
					"",
					"CFrame.Angles"
				}
			},
			{
				"CFrame.fromEulerAnglesYXZ",
				new string[]
				{
					"Method",
					"",
					"CFrame.fromEulerAnglesYXZ"
				}
			},
			{
				"CFrame.new",
				new string[]
				{
					"Method",
					"",
					"CFrame.new"
				}
			}
		};

		// Token: 0x0400003B RID: 59
		public static Dictionary<string, string[]> DATETIME = new Dictionary<string, string[]>
		{
			{
				"DateTime",
				new string[]
				{
					"Class",
					"",
					"DateTime"
				}
			},
			{
				"DateTime.fromUnixTimestamp",
				new string[]
				{
					"Method",
					"",
					"DateTime.fromUnixTimestamp"
				}
			},
			{
				"DateTime.now",
				new string[]
				{
					"Method",
					"",
					"DateTime.now"
				}
			},
			{
				"DateTime.fromIsoDate",
				new string[]
				{
					"Method",
					"",
					"DateTime.fromIsoDate"
				}
			},
			{
				"DateTime.fromUnixTimestampMillis",
				new string[]
				{
					"Method",
					"",
					"DateTime.fromUnixTimestampMillis"
				}
			},
			{
				"DateTime.fromLocalTime",
				new string[]
				{
					"Method",
					"",
					"DateTime.fromLocalTime"
				}
			},
			{
				"DateTime.fromUniversalTime",
				new string[]
				{
					"Method",
					"",
					"DateTime.fromUniversalTime"
				}
			}
		};

		// Token: 0x0400003C RID: 60
		public static Dictionary<string, string[]> COLOR3 = new Dictionary<string, string[]>
		{
			{
				"Color3",
				new string[]
				{
					"Class",
					"",
					"Color3"
				}
			},
			{
				"Color3.fromHSV",
				new string[]
				{
					"Method",
					"",
					"Color3.fromHSV"
				}
			},
			{
				"Color3.toHSV",
				new string[]
				{
					"Method",
					"",
					"Color3.toHSV"
				}
			},
			{
				"Color3.fromRGB",
				new string[]
				{
					"Method",
					"",
					"Color3.fromRGB"
				}
			},
			{
				"Color3.new",
				new string[]
				{
					"Method",
					"",
					"Color3.new"
				}
			}
		};

		// Token: 0x0400003D RID: 61
		public static Dictionary<string, string[]> ENUM = new Dictionary<string, string[]>();

		// Token: 0x0400003E RID: 62
		public static Dictionary<string, string[]> _G = new Dictionary<string, string[]>
		{
			{
				"_G",
				new string[]
				{
					"Class",
					"",
					"_G"
				}
			}
		};

		// Token: 0x0400003F RID: 63
		public static Dictionary<string, string[]> NUMBERRANGE = new Dictionary<string, string[]>
		{
			{
				"NumberRange",
				new string[]
				{
					"Class",
					"",
					"NumberRange"
				}
			},
			{
				"NumberRange.new",
				new string[]
				{
					"Method",
					"",
					"NumberRange.new"
				}
			}
		};

		// Token: 0x04000040 RID: 64
		public static Dictionary<string, string[]> PHYSICALPROPERTIES = new Dictionary<string, string[]>
		{
			{
				"PhysicalProperties",
				new string[]
				{
					"Class",
					"",
					"PhysicalProperties"
				}
			},
			{
				"PhysicalProperties.new",
				new string[]
				{
					"Method",
					"",
					"PhysicalProperties.new"
				}
			}
		};

		// Token: 0x04000041 RID: 65
		public static Dictionary<string, string[]> RAY = new Dictionary<string, string[]>
		{
			{
				"Ray",
				new string[]
				{
					"Class",
					"",
					"Ray"
				}
			},
			{
				"Ray.new",
				new string[]
				{
					"Method",
					"",
					"Ray.new"
				}
			}
		};

		// Token: 0x04000042 RID: 66
		public static Dictionary<string, string[]> NUMBERSEQUENCEKEYPOINT = new Dictionary<string, string[]>
		{
			{
				"NumberSequenceKeypoint",
				new string[]
				{
					"Class",
					"",
					"NumberSequenceKeypoint"
				}
			},
			{
				"NumberSequenceKeypoint.new",
				new string[]
				{
					"Method",
					"",
					"NumberSequenceKeypoint.new"
				}
			}
		};

		// Token: 0x04000043 RID: 67
		public static Dictionary<string, string[]> VECTOR2 = new Dictionary<string, string[]>
		{
			{
				"Vector2",
				new string[]
				{
					"Class",
					"",
					"Vector2"
				}
			},
			{
				"Vector2.new",
				new string[]
				{
					"Method",
					"",
					"Vector2.new"
				}
			}
		};

		// Token: 0x04000044 RID: 68
		public static Dictionary<string, string[]> CELLID = new Dictionary<string, string[]>
		{
			{
				"CellId",
				new string[]
				{
					"Class",
					"",
					"CellId"
				}
			},
			{
				"CellId.new",
				new string[]
				{
					"Method",
					"",
					"CellId.new"
				}
			}
		};

		// Token: 0x04000045 RID: 69
		public static Dictionary<string, string[]> VECTOR3INT16 = new Dictionary<string, string[]>
		{
			{
				"Vector3int16",
				new string[]
				{
					"Class",
					"",
					"Vector3int16"
				}
			},
			{
				"Vector3int16.new",
				new string[]
				{
					"Method",
					"",
					"Vector3int16.new"
				}
			}
		};

		// Token: 0x04000046 RID: 70
		public static Dictionary<string, string[]> BIT32 = new Dictionary<string, string[]>
		{
			{
				"bit32",
				new string[]
				{
					"Class",
					"",
					"bit32"
				}
			},
			{
				"bit32.band",
				new string[]
				{
					"Method",
					"",
					"bit32.band"
				}
			},
			{
				"bit32.extract",
				new string[]
				{
					"Method",
					"",
					"bit32.extract"
				}
			},
			{
				"bit32.bor",
				new string[]
				{
					"Method",
					"",
					"bit32.bor"
				}
			},
			{
				"bit32.bnot",
				new string[]
				{
					"Method",
					"",
					"bit32.bnot"
				}
			},
			{
				"bit32.arshift",
				new string[]
				{
					"Method",
					"",
					"bit32.arshift"
				}
			},
			{
				"bit32.rshift",
				new string[]
				{
					"Method",
					"",
					"bit32.rshift"
				}
			},
			{
				"bit32.rrotate",
				new string[]
				{
					"Method",
					"",
					"bit32.rrotate"
				}
			},
			{
				"bit32.replace",
				new string[]
				{
					"Method",
					"",
					"bit32.replace"
				}
			},
			{
				"bit32.lshift",
				new string[]
				{
					"Method",
					"",
					"bit32.lshift"
				}
			},
			{
				"bit32.lrotate",
				new string[]
				{
					"Method",
					"",
					"bit32.lrotate"
				}
			},
			{
				"bit32.btest",
				new string[]
				{
					"Method",
					"",
					"bit32.btest"
				}
			},
			{
				"bit32.bxor",
				new string[]
				{
					"Method",
					"",
					"bit32.bxor"
				}
			}
		};

		// Token: 0x04000047 RID: 71
		public static Dictionary<string, string[]> REGION3INT16 = new Dictionary<string, string[]>
		{
			{
				"Region3int16",
				new string[]
				{
					"Class",
					"",
					"Region3int16"
				}
			},
			{
				"Region3int16.new",
				new string[]
				{
					"Method",
					"",
					"Region3int16.new"
				}
			}
		};

		// Token: 0x04000048 RID: 72
		public static Dictionary<string, string[]> NUMBERSEQUENCE = new Dictionary<string, string[]>
		{
			{
				"NumberSequence",
				new string[]
				{
					"Class",
					"",
					"NumberSequence"
				}
			},
			{
				"NumberSequence.new",
				new string[]
				{
					"Method",
					"",
					"NumberSequence.new"
				}
			}
		};

		// Token: 0x04000049 RID: 73
		public static Dictionary<string, string[]> UTF8 = new Dictionary<string, string[]>
		{
			{
				"utf8",
				new string[]
				{
					"Class",
					"",
					"utf8"
				}
			},
			{
				"utf8.offset",
				new string[]
				{
					"Method",
					"",
					"utf8.offset"
				}
			},
			{
				"utf8.codepoint",
				new string[]
				{
					"Method",
					"",
					"utf8.codepoint"
				}
			},
			{
				"utf8.nfdnormalize",
				new string[]
				{
					"Method",
					"",
					"utf8.nfdnormalize"
				}
			},
			{
				"utf8.char",
				new string[]
				{
					"Method",
					"",
					"utf8.char"
				}
			},
			{
				"utf8.codes",
				new string[]
				{
					"Method",
					"",
					"utf8.codes"
				}
			},
			{
				"utf8.len",
				new string[]
				{
					"Method",
					"",
					"utf8.len"
				}
			},
			{
				"utf8.graphemes",
				new string[]
				{
					"Method",
					"",
					"utf8.graphemes"
				}
			},
			{
				"utf8.nfcnormalize",
				new string[]
				{
					"Method",
					"",
					"utf8.nfcnormalize"
				}
			}
		};

		// Token: 0x0400004A RID: 74
		public static Dictionary<string, string[]> PATHWAYPOINT = new Dictionary<string, string[]>
		{
			{
				"PathWaypoint",
				new string[]
				{
					"Class",
					"",
					"PathWaypoint"
				}
			},
			{
				"PathWaypoint.new",
				new string[]
				{
					"Method",
					"",
					"PathWaypoint.new"
				}
			}
		};

		// Token: 0x0400004B RID: 75
		public static Dictionary<string, string[]> COLORSEQUENCE = new Dictionary<string, string[]>
		{
			{
				"ColorSequence",
				new string[]
				{
					"Class",
					"",
					"ColorSequence"
				}
			},
			{
				"ColorSequence.new",
				new string[]
				{
					"Method",
					"",
					"ColorSequence.new"
				}
			}
		};

		// Token: 0x0400004C RID: 76
		public static Dictionary<string, string[]> UDIM2 = new Dictionary<string, string[]>
		{
			{
				"UDim2",
				new string[]
				{
					"Class",
					"",
					"UDim2"
				}
			},
			{
				"UDim2.fromOffset",
				new string[]
				{
					"Method",
					"",
					"UDim2.fromOffset"
				}
			},
			{
				"UDim2.fromScale",
				new string[]
				{
					"Method",
					"",
					"UDim2.fromScale"
				}
			},
			{
				"UDim2.new",
				new string[]
				{
					"Method",
					"",
					"UDim2.new"
				}
			}
		};

		// Token: 0x0400004D RID: 77
		public static Dictionary<string, string[]> INSTANCE = new Dictionary<string, string[]>
		{
			{
				"Instance",
				new string[]
				{
					"Class",
					"",
					"Instance"
				}
			},
			{
				"Instance.new",
				new string[]
				{
					"Method",
					"",
					"Instance.new"
				}
			}
		};

		// Token: 0x0400004E RID: 78
		public static Dictionary<string, string[]> RECT = new Dictionary<string, string[]>
		{
			{
				"Rect",
				new string[]
				{
					"Class",
					"",
					"Rect"
				}
			},
			{
				"Rect.new",
				new string[]
				{
					"Method",
					"",
					"Rect.new"
				}
			}
		};

		// Token: 0x0400004F RID: 79
		public static Dictionary<string, string[]> BRICKCOLOR = new Dictionary<string, string[]>
		{
			{
				"BrickColor",
				new string[]
				{
					"Class",
					"",
					"BrickColor"
				}
			},
			{
				"BrickColor.Blue",
				new string[]
				{
					"Method",
					"",
					"BrickColor.Blue"
				}
			},
			{
				"BrickColor.White",
				new string[]
				{
					"Method",
					"",
					"BrickColor.White"
				}
			},
			{
				"BrickColor.Yellow",
				new string[]
				{
					"Method",
					"",
					"BrickColor.Yellow"
				}
			},
			{
				"BrickColor.Red",
				new string[]
				{
					"Method",
					"",
					"BrickColor.Red"
				}
			},
			{
				"BrickColor.Gray",
				new string[]
				{
					"Method",
					"",
					"BrickColor.Gray"
				}
			},
			{
				"BrickColor.palette",
				new string[]
				{
					"Method",
					"",
					"BrickColor.palette"
				}
			},
			{
				"BrickColor.New",
				new string[]
				{
					"Method",
					"",
					"BrickColor.New"
				}
			},
			{
				"BrickColor.Black",
				new string[]
				{
					"Method",
					"",
					"BrickColor.Black"
				}
			},
			{
				"BrickColor.Green",
				new string[]
				{
					"Method",
					"",
					"BrickColor.Green"
				}
			},
			{
				"BrickColor.Random",
				new string[]
				{
					"Method",
					"",
					"BrickColor.Random"
				}
			},
			{
				"BrickColor.DarkGray",
				new string[]
				{
					"Method",
					"",
					"BrickColor.DarkGray"
				}
			},
			{
				"BrickColor.random",
				new string[]
				{
					"Method",
					"",
					"BrickColor.random"
				}
			},
			{
				"BrickColor.new",
				new string[]
				{
					"Method",
					"",
					"BrickColor.new"
				}
			}
		};

		// Token: 0x04000050 RID: 80
		public static Dictionary<string, string[]> STRING = new Dictionary<string, string[]>
		{
			{
				"string",
				new string[]
				{
					"Class",
					"",
					"string"
				}
			},
			{
				"string.sub",
				new string[]
				{
					"Method",
					"",
					"string.sub"
				}
			},
			{
				"string.split",
				new string[]
				{
					"Method",
					"",
					"string.split"
				}
			},
			{
				"string.upper",
				new string[]
				{
					"Method",
					"",
					"string.upper"
				}
			},
			{
				"string.len",
				new string[]
				{
					"Method",
					"",
					"string.len"
				}
			},
			{
				"string.find",
				new string[]
				{
					"Method",
					"",
					"string.find"
				}
			},
			{
				"string.match",
				new string[]
				{
					"Method",
					"",
					"string.match"
				}
			},
			{
				"string.char",
				new string[]
				{
					"Method",
					"",
					"string.char"
				}
			},
			{
				"string.rep",
				new string[]
				{
					"Method",
					"",
					"string.rep"
				}
			},
			{
				"string.gmatch",
				new string[]
				{
					"Method",
					"",
					"string.gmatch"
				}
			},
			{
				"string.reverse",
				new string[]
				{
					"Method",
					"",
					"string.reverse"
				}
			},
			{
				"string.byte",
				new string[]
				{
					"Method",
					"",
					"string.byte"
				}
			},
			{
				"string.format",
				new string[]
				{
					"Method",
					"",
					"string.format"
				}
			},
			{
				"string.gsub",
				new string[]
				{
					"Method",
					"",
					"string.gsub"
				}
			},
			{
				"string.lower",
				new string[]
				{
					"Method",
					"",
					"string.lower"
				}
			}
		};

		// Token: 0x04000051 RID: 81
		public static Dictionary<string, string[]> standalone = new Dictionary<string, string[]>
		{
			{
				"tostring",
				new string[]
				{
					"Function",
					"",
					"tostring"
				}
			},
			{
				"lockModule",
				new string[]
				{
					"Function",
					"",
					"lockModule"
				}
			},
			{
				"getsenv",
				new string[]
				{
					"Function",
					"",
					"getsenv"
				}
			},
			{
				"setrawmetatable",
				new string[]
				{
					"Function",
					"",
					"setrawmetatable"
				}
			},
			{
				"queue_on_teleport",
				new string[]
				{
					"Function",
					"",
					"queue_on_teleport"
				}
			},
			{
				"tonumber",
				new string[]
				{
					"Function",
					"",
					"tonumber"
				}
			},
			{
				"Stats",
				new string[]
				{
					"Function",
					"",
					"Stats"
				}
			},
			{
				"setthreadcontext",
				new string[]
				{
					"Function",
					"",
					"setthreadcontext"
				}
			},
			{
				"getrenv",
				new string[]
				{
					"Function",
					"",
					"getrenv"
				}
			},
			{
				"newcclosure",
				new string[]
				{
					"Function",
					"",
					"newcclosure"
				}
			},
			{
				"request",
				new string[]
				{
					"Function",
					"",
					"request"
				}
			},
			{
				"isluau",
				new string[]
				{
					"Function",
					"",
					"isluau"
				}
			},
			{
				"decompile",
				new string[]
				{
					"Function",
					"",
					"decompile"
				}
			},
			{
				"loadstring",
				new string[]
				{
					"Function",
					"",
					"loadstring"
				}
			},
			{
				"printidentity",
				new string[]
				{
					"Function",
					"",
					"printidentity"
				}
			},
			{
				"Version",
				new string[]
				{
					"Function",
					"",
					"Version"
				}
			},
			{
				"getprotos",
				new string[]
				{
					"Function",
					"",
					"getprotos"
				}
			},
			{
				"spawn",
				new string[]
				{
					"Function",
					"",
					"spawn"
				}
			},
			{
				"hookfunction",
				new string[]
				{
					"Function",
					"",
					"hookfunction"
				}
			},
			{
				"stats",
				new string[]
				{
					"Function",
					"",
					"stats"
				}
			},
			{
				"getproto",
				new string[]
				{
					"Function",
					"",
					"getproto"
				}
			},
			{
				"print",
				new string[]
				{
					"Function",
					"",
					"print"
				}
			},
			{
				"getupvalue",
				new string[]
				{
					"Function",
					"",
					"getupvalue"
				}
			},
			{
				"elapsedTime",
				new string[]
				{
					"Function",
					"",
					"elapsedTime"
				}
			},
			{
				"ipairs",
				new string[]
				{
					"Function",
					"",
					"ipairs"
				}
			},
			{
				"mouse1click",
				new string[]
				{
					"Function",
					"",
					"mouse1click"
				}
			},
			{
				"collectgarbage",
				new string[]
				{
					"Function",
					"",
					"collectgarbage"
				}
			},
			{
				"gethiddenproperty",
				new string[]
				{
					"Function",
					"",
					"gethiddenproperty"
				}
			},
			{
				"getinstancecachekey",
				new string[]
				{
					"Function",
					"",
					"getinstancecachekey"
				}
			},
			{
				"getnilinstances",
				new string[]
				{
					"Function",
					"",
					"getnilinstances"
				}
			},
			{
				"time",
				new string[]
				{
					"Function",
					"",
					"time"
				}
			},
			{
				"getupvalues",
				new string[]
				{
					"Function",
					"",
					"getupvalues"
				}
			},
			{
				"type",
				new string[]
				{
					"Function",
					"",
					"type"
				}
			},
			{
				"ElapsedTime",
				new string[]
				{
					"Function",
					"",
					"ElapsedTime"
				}
			},
			{
				"setclipboard",
				new string[]
				{
					"Function",
					"",
					"setclipboard"
				}
			},
			{
				"mouse2click",
				new string[]
				{
					"Function",
					"",
					"mouse2click"
				}
			},
			{
				"getinfo",
				new string[]
				{
					"Function",
					"",
					"getinfo"
				}
			},
			{
				"sethiddenproperty",
				new string[]
				{
					"Function",
					"",
					"sethiddenproperty"
				}
			},
			{
				"loadfile",
				new string[]
				{
					"Function",
					"",
					"loadfile"
				}
			},
			{
				"getconstant",
				new string[]
				{
					"Function",
					"",
					"getconstant"
				}
			},
			{
				"warn",
				new string[]
				{
					"Function",
					"",
					"warn"
				}
			},
			{
				"gcinfo",
				new string[]
				{
					"Function",
					"",
					"gcinfo"
				}
			},
			{
				"tick",
				new string[]
				{
					"Function",
					"",
					"tick"
				}
			},
			{
				"checkcaller",
				new string[]
				{
					"Function",
					"",
					"checkcaller"
				}
			},
			{
				"getfenv",
				new string[]
				{
					"Function",
					"",
					"getfenv"
				}
			},
			{
				"setreadonly",
				new string[]
				{
					"Function",
					"",
					"setreadonly"
				}
			},
			{
				"mouse1up",
				new string[]
				{
					"Function",
					"",
					"mouse1up"
				}
			},
			{
				"wait",
				new string[]
				{
					"Function",
					"",
					"wait"
				}
			},
			{
				"Delay",
				new string[]
				{
					"Function",
					"",
					"Delay"
				}
			},
			{
				"getconstants",
				new string[]
				{
					"Function",
					"",
					"getconstants"
				}
			},
			{
				"traceback",
				new string[]
				{
					"Function",
					"",
					"traceback"
				}
			},
			{
				"UserSettings",
				new string[]
				{
					"Function",
					"",
					"UserSettings"
				}
			},
			{
				"readfile",
				new string[]
				{
					"Function",
					"",
					"readfile"
				}
			},
			{
				"PluginManager",
				new string[]
				{
					"Function",
					"",
					"PluginManager"
				}
			},
			{
				"getreg",
				new string[]
				{
					"Function",
					"",
					"getreg"
				}
			},
			{
				"HttpPost",
				new string[]
				{
					"Function",
					"",
					"HttpPost"
				}
			},
			{
				"delay",
				new string[]
				{
					"Function",
					"",
					"delay"
				}
			},
			{
				"HttpGetAsync",
				new string[]
				{
					"Function",
					"",
					"HttpGetAsync"
				}
			},
			{
				"HttpGet",
				new string[]
				{
					"Function",
					"",
					"HttpGet"
				}
			},
			{
				"ypcall",
				new string[]
				{
					"Function",
					"",
					"ypcall"
				}
			},
			{
				"getregistry",
				new string[]
				{
					"Function",
					"",
					"getregistry"
				}
			},
			{
				"getgenv",
				new string[]
				{
					"Function",
					"",
					"getgenv"
				}
			},
			{
				"setconstant",
				new string[]
				{
					"Function",
					"",
					"setconstant"
				}
			},
			{
				"profilebegin",
				new string[]
				{
					"Function",
					"",
					"profilebegin"
				}
			},
			{
				"setupvalue",
				new string[]
				{
					"Function",
					"",
					"setupvalue"
				}
			},
			{
				"profileend",
				new string[]
				{
					"Function",
					"",
					"profileend"
				}
			},
			{
				"typeof",
				new string[]
				{
					"Function",
					"",
					"typeof"
				}
			},
			{
				"getcallingscript",
				new string[]
				{
					"Function",
					"",
					"getcallingscript"
				}
			},
			{
				"is_luau",
				new string[]
				{
					"Function",
					"",
					"is_luau"
				}
			},
			{
				"require",
				new string[]
				{
					"Function",
					"",
					"require"
				}
			},
			{
				"writefile",
				new string[]
				{
					"Function",
					"",
					"writefile"
				}
			},
			{
				"mouse2up",
				new string[]
				{
					"Function",
					"",
					"mouse2up"
				}
			},
			{
				"setmetatable",
				new string[]
				{
					"Function",
					"",
					"setmetatable"
				}
			},
			{
				"next",
				new string[]
				{
					"Function",
					"",
					"next"
				}
			},
			{
				"mousemoverel",
				new string[]
				{
					"Function",
					"",
					"mousemoverel"
				}
			},
			{
				"mouse2down",
				new string[]
				{
					"Function",
					"",
					"mouse2down"
				}
			},
			{
				"mouse1down",
				new string[]
				{
					"Function",
					"",
					"mouse1down"
				}
			},
			{
				"unlockModule",
				new string[]
				{
					"Function",
					"",
					"unlockModule"
				}
			},
			{
				"islclosure",
				new string[]
				{
					"Function",
					"",
					"islclosure"
				}
			},
			{
				"version",
				new string[]
				{
					"Function",
					"",
					"version"
				}
			},
			{
				"xpcall",
				new string[]
				{
					"Function",
					"",
					"xpcall"
				}
			},
			{
				"pairs",
				new string[]
				{
					"Function",
					"",
					"pairs"
				}
			},
			{
				"newproxy",
				new string[]
				{
					"Function",
					"",
					"newproxy"
				}
			},
			{
				"Spawn",
				new string[]
				{
					"Function",
					"",
					"Spawn"
				}
			},
			{
				"assert",
				new string[]
				{
					"Function",
					"",
					"assert"
				}
			},
			{
				"appendfile",
				new string[]
				{
					"Function",
					"",
					"appendfile"
				}
			},
			{
				"getrawmetatable",
				new string[]
				{
					"Function",
					"",
					"getrawmetatable"
				}
			},
			{
				"rawset",
				new string[]
				{
					"Function",
					"",
					"rawset"
				}
			},
			{
				"getgc",
				new string[]
				{
					"Function",
					"",
					"getgc"
				}
			},
			{
				"settings",
				new string[]
				{
					"Function",
					"",
					"settings"
				}
			},
			{
				"iscclosure",
				new string[]
				{
					"Function",
					"",
					"iscclosure"
				}
			},
			{
				"isreadonly",
				new string[]
				{
					"Function",
					"",
					"isreadonly"
				}
			},
			{
				"getthreadcontext",
				new string[]
				{
					"Function",
					"",
					"getthreadcontext"
				}
			},
			{
				"GetObjects",
				new string[]
				{
					"Function",
					"",
					"GetObjects"
				}
			},
			{
				"run_secure",
				new string[]
				{
					"Function",
					"",
					"run_secure"
				}
			},
			{
				"getnamecallmethod",
				new string[]
				{
					"Function",
					"",
					"getnamecallmethod"
				}
			},
			{
				"rawequal",
				new string[]
				{
					"Function",
					"",
					"rawequal"
				}
			},
			{
				"fireclickdetector",
				new string[]
				{
					"Function",
					"",
					"fireclickdetector"
				}
			},
			{
				"unpack",
				new string[]
				{
					"Function",
					"",
					"unpack"
				}
			},
			{
				"rawget",
				new string[]
				{
					"Function",
					"",
					"rawget"
				}
			},
			{
				"Wait",
				new string[]
				{
					"Function",
					"",
					"Wait"
				}
			},
			{
				"getmetatable",
				new string[]
				{
					"Function",
					"",
					"getmetatable"
				}
			},
			{
				"setfenv",
				new string[]
				{
					"Function",
					"",
					"setfenv"
				}
			},
			{
				"select",
				new string[]
				{
					"Function",
					"",
					"select"
				}
			},
			{
				"pcall",
				new string[]
				{
					"Function",
					"",
					"pcall"
				}
			},
			{
				"error",
				new string[]
				{
					"Function",
					"",
					"error"
				}
			}
		};

		// Token: 0x04000052 RID: 82
		public static Dictionary<string, string[]> keywords = new Dictionary<string, string[]>
		{
			{
				"if",
				new string[]
				{
					"Keyword",
					"",
					"if"
				}
			},
			{
				"else",
				new string[]
				{
					"Keyword",
					"",
					"else"
				}
			},
			{
				"elseif",
				new string[]
				{
					"Keyword",
					"",
					"elseif"
				}
			},
			{
				"while",
				new string[]
				{
					"Keyword",
					"",
					"while"
				}
			},
			{
				"do",
				new string[]
				{
					"Keyword",
					"",
					"do"
				}
			},
			{
				"function",
				new string[]
				{
					"Keyword",
					"",
					"function"
				}
			},
			{
				"repeat",
				new string[]
				{
					"Keyword",
					"",
					"repeat"
				}
			},
			{
				"until",
				new string[]
				{
					"Keyword",
					"",
					"until"
				}
			},
			{
				"for",
				new string[]
				{
					"Keyword",
					"",
					"for"
				}
			},
			{
				"in",
				new string[]
				{
					"Keyword",
					"",
					"in"
				}
			},
			{
				"next",
				new string[]
				{
					"Keyword",
					"",
					"next"
				}
			},
			{
				"continue",
				new string[]
				{
					"Keyword",
					"",
					"continue"
				}
			},
			{
				"break",
				new string[]
				{
					"Keyword",
					"",
					"break"
				}
			},
			{
				"return",
				new string[]
				{
					"Keyword",
					"",
					"return"
				}
			},
			{
				"true",
				new string[]
				{
					"Keyword",
					"",
					"true"
				}
			},
			{
				"false",
				new string[]
				{
					"Keyword",
					"",
					"false"
				}
			},
			{
				"and",
				new string[]
				{
					"Keyword",
					"",
					"and"
				}
			},
			{
				"or",
				new string[]
				{
					"Keyword",
					"",
					"or"
				}
			},
			{
				"end",
				new string[]
				{
					"Keyword",
					"",
					"end"
				}
			},
			{
				"local",
				new string[]
				{
					"Keyword",
					"",
					"local"
				}
			},
			{
				"then",
				new string[]
				{
					"Keyword",
					"",
					"then"
				}
			}
		};
	}
}
