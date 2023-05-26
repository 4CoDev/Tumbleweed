using DotGod.Resource.FromFiles.ToGodot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical._Mesh._ArrayMesh.OfGodot.FromFile;

public sealed class MeshOnPath : ScalarEnvelope<Godot.ArrayMesh>
{
	public MeshOnPath(String path) : this
	(
		new ScalarValue<String>(path)
	)
	{
	}
	
	public MeshOnPath(IScalar<String> path) : base
	(
		new ResourceOnPath<Godot.ArrayMesh>(path)
	)
	{
	}
}
