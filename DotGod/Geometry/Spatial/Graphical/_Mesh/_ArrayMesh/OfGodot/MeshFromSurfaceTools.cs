using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical._Mesh._ArrayMesh.OfGodot;

public sealed class MeshFromSurfaceTools : ScalarEnvelope<Godot.ArrayMesh>
{
	public MeshFromSurfaceTools
	(
		IEnumerable<SurfaceTool> tools
	) : base
	(
		new MeshWithSurfaceTools(
			tools,
			new ScalarOfNew<Godot.ArrayMesh>())
	)
	{
	}
}