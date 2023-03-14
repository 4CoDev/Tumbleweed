using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces.FromArrayMeshes.FromGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Meshes.FromArrayMeshes.FromGodot;

public sealed class MeshFromGodot : MeshEnvelope
{
	public MeshFromGodot(ArrayMesh mesh) : this
	(
		new ScalarOfValue<ArrayMesh>(mesh)
	)
	{
	}
	
	public MeshFromGodot(IScalar<ArrayMesh> mesh) : base
	(
		new MeshWithSurfaces(
			new SurfacesFromMesh(mesh))
	)
	{
	}
}