using DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.OfGodot;
using DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.ToGodot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.ToGodot;

public sealed class MeshFromTumbleweed : ScalarEnvelope<Godot.ArrayMesh>
{
	public MeshFromTumbleweed(IMesh mesh) : base
	(
		new MeshFromSurfaceTools(
			new SurfaceToolsWithMesh(mesh))
	)
	{
	}
}
