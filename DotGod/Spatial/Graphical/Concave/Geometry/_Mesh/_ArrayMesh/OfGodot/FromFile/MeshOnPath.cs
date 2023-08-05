using DotGod.Resource.On.Path.From.File;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.OfGodot.FromFile;

public sealed class MeshOnPath : Envelope<Godot.ArrayMesh>
{
	public MeshOnPath(String path) : this
	(
		new Value<String>(path)
	)
	{
	}
	
	public MeshOnPath(Any<String> path) : base
	(
		new Actual<Godot.ArrayMesh>(path)
	)
	{
	}
}
