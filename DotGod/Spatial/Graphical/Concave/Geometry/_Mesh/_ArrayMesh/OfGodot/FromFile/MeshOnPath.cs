using DotGod.Resource.FromFiles.ToGodot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.OfGodot.FromFile;

public sealed class MeshOnPath : Envelope<Godot.ArrayMesh>
{
	public MeshOnPath(String path) : this
	(
		new Tumbleweed.Scalar.Of.Value<String>(path)
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
