using DotGod.Resource.FromFiles.ToGodot;
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
		new ResourceOnPath<Godot.ArrayMesh>(path)
	)
	{
	}
}
