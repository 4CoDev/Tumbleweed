using DotGod.Geometrics.Graphical.Meshes.ArrayMeshes.OfGodot;
using DotGod.Geometrics.Graphical.Surfaces.SurfaceTools.ToGodot;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Meshes.ArrayMeshes.ToGodot;

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
