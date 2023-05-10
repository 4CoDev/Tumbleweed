using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Meshes.ArrayMeshes.OfGodot;

public sealed class MeshFromSurfaceTools : ScalarEnvelope<ArrayMesh>
{
	public MeshFromSurfaceTools
	(
		IEnumerable<SurfaceTool> tools
	) : base
	(
		new MeshWithSurfaceTools(
			tools,
			new ScalarOfNew<ArrayMesh>())
	)
	{
	}
}