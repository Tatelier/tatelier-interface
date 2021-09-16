using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatelier.Interface
{
	public abstract class Engine
	{

		public static void Start(Engine engine)
		{
			singleton = engine;
		}

		static Engine singleton;

		public static Engine Singleton => singleton;

		public abstract INowTime NowTime { get; }

		public abstract IScreenSize ScreenSize { get; }

		public abstract ILogWindow LogWindow { get; }
	}
}
