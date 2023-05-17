using DotGod.Resources.FromFiles.ToGodot;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Meshes.ArrayMeshes.OfGodot.FromFiles;

public sealed class MeshOnPath : ScalarEnvelope<ArrayMesh>
{
	public MeshOnPath(String path) : this
	(
		new ScalarValue<String>(path)
	)
	{
	}
	
	public MeshOnPath(IScalar<String> path) : base
	(
		new ResourceOnPath<ArrayMesh>(path)
	)
	{
	}
}
