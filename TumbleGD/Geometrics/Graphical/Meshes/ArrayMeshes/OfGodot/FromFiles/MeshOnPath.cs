using Godot;
using TumbleGD.Resources.FromFiles.ToGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Meshes.ArrayMeshes.OfGodot.FromFiles;

public sealed class MeshOnPath : ScalarEnvelope<ArrayMesh>
{
	public MeshOnPath(String path) : this
	(
		new ScalarOfValue<String>(path)
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
