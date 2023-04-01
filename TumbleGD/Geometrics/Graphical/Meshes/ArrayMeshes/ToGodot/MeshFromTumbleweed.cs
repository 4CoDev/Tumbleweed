using Godot;
using TumbleGD.Geometrics.Graphical.Meshes.ArrayMeshes.OfGodot;
using TumbleGD.Geometrics.Graphical.Surfaces.SurfaceTools.ToGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Meshes.ArrayMeshes.ToGodot;

public sealed class MeshFromTumbleweed : ScalarEnvelope<ArrayMesh>
{
	public MeshFromTumbleweed(IMesh mesh) : base
	(
		new MeshFromSurfaceTools(
			new SurfaceToolsWithMesh(mesh))
	)
	{
	}
}
