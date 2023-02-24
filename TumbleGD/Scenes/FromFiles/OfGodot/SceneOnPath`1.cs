using Godot;
using TumbleGD.Resources.FromFiles.ToGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Scenes.FromFiles.OfGodot;

public sealed class SceneOnPath<T> : ScalarEnvelope<T> where T : Node
{
	public SceneOnPath(string path) : this
	(
		new ScalarOfValue<string>(path)
	)
	{
	}
	
	public SceneOnPath(IScalar<string> path) : base
	(
		new ScalarOfDelegate<T>(
			() => new ScalarOnPath<PackedScene>(path).Value.Instantiate<T>())
	)
	{
	}
}