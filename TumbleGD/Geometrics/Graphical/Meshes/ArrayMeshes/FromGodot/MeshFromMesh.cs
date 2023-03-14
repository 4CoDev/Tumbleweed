using Godot;
using TumbleGD.Geometrics.Graphical.SurfaceTools.ToGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Meshes.ArrayMeshes.FromGodot;

public sealed class MeshFromMesh : ScalarEnvelope<ArrayMesh>
{
	public MeshFromMesh(IMesh mesh) : base
	(
		new MeshWithSurfaceTools(
			new SurfaceToolsWithSurfaces(mesh.Surfaces),
			new ScalarOfNew<ArrayMesh>())
	)
	{
	}
}
