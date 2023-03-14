using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces.FromArrayMeshes.FromGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Meshes.FromArrayMeshes.FromGodot;

public sealed class MeshFromGodot : MeshEnvelope
{
	public MeshFromGodot(IScalar<ArrayMesh> mesh) : base
	(
		new MeshWithSurfaces(
			new SurfacesFromMesh(mesh))
	)
	{
	}
}