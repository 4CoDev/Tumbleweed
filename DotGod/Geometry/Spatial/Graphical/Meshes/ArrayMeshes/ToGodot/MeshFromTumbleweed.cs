using DotGod.Geometry.Spatial.Graphical.Meshes.ArrayMeshes.OfGodot;
using DotGod.Geometry.Spatial.Graphical.Surfaces.SurfaceTools.ToGodot;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Meshes.ArrayMeshes.ToGodot;

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
