using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.OfGodot;

public sealed class MeshFromSurfaceTools : Envelope<Godot.ArrayMesh>
{
	public MeshFromSurfaceTools
	(
		IEnumerable<SurfaceTool> tools
	) : base
	(
		new MeshWithSurfaceTools(
			tools,
			new Tumbleweed.Scalar.Of.New<Godot.ArrayMesh>())
	)
	{
	}
}