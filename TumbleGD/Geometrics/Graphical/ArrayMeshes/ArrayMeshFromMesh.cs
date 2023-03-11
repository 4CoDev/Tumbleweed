using Godot;
using TumbleGD.Geometrics.Graphical.Meshes;
using TumbleGD.Geometrics.Graphical.Surfaces;
using TumbleGD.Geometrics.Graphical.SurfaceTools.FromGeometrics;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.ArrayMeshes;

public sealed class ArrayMeshFromMesh : ScalarEnvelope<ArrayMesh>
{
	public ArrayMeshFromMesh(IMesh mesh) : base
	(
		new ArrayMeshWithSurfaceTools(
			new SurfaceToolsWithSurfaces(mesh.Surfaces),
			new ScalarOfNew<ArrayMesh>())
	)
	{
	}
}
