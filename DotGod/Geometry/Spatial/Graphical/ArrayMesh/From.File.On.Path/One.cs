using DotGod.Resource.On.Path.From.File;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Geometry.Spatial.Graphical.ArrayMesh.From.File.On.Path;

public sealed class One : Envelope<Godot.ArrayMesh>
{
	public One(String path) : this
	(
		new Value<String>(path)
	)
	{
	}
	
	public One(Any<String> path) : base
	(
		new Actual<Godot.ArrayMesh>(path)
	)
	{
	}
}
