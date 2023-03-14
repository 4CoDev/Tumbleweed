using Godot;
using TumbleGD.Resources.FromFiles.ToGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Meshes.ArrayMeshes.FromGodot.FromFiles;

public sealed class MeshOnPath : ScalarEnvelope<ArrayMesh>
{
	public MeshOnPath(IScalar<String> path) : base
	(
		new ResourceOnPath<ArrayMesh>(path)
	)
	{
	}
}
