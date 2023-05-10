using DotGod.Geometry.Graphical.Meshes.ArrayMeshes.OfGodot;
using DotGod.Geometry.Graphical.Surfaces.SurfaceTools.ToGodot;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Meshes.ArrayMeshes.ToGodot;

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
