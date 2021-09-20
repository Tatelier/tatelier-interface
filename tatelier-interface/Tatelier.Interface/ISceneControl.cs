using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatelier.Interface.Scene
{
	public interface ISceneControl
	{
		int CreateScene<T>(string name, out T scene, params object[] args)
			where T : Scene.IScene, new();
	}
}
