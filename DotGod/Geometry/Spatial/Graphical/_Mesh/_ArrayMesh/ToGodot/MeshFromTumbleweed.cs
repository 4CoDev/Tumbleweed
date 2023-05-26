using DotGod.Geometry.Spatial.Graphical._Mesh._ArrayMesh.OfGodot;
using DotGod.Geometry.Spatial.Graphical.Surface._SurfaceTool.ToGodot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical._Mesh._ArrayMesh.ToGodot;

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
